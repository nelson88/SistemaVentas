using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaEntidad;

namespace CapaDatos
{
    public class CompraDataAccess : ConnectionSql
    {
        SqlDataReader leer;
        DataTable dt = new DataTable();
        SqlCommand command = new SqlCommand();

        public DataTable ObtnerCompras()
        {
            command.Connection = AbrirConexion();
            command.CommandText = @"SELECT cp.ClientProducId, cp.ClienteId, c.Cedula, c.PrimerNombre,
                                           c.PrimerApellido, p.ProductoId, p.Nombre,
                                           cp.Monto, cp.Nuevo_Saldo, cp.FechaAdquisicion, cp.MesesPagar,
                                           cp.FrecuenciaId, f.Nombre Frecuenca, d.Nombre Dia, cp.MontoPrima,
                                           cp.DiaSemana, cp.DiaPrimeraQuincena, cp.DiaSegundaQuincena, cp.DiaMes,
                                           cp.Creado, cp.Modificado
                                    FROM dbo.Client_Produc cp
                                    INNER JOIN dbo.Cliente c ON c.ClienteId = cp.ClienteId
                                    INNER JOIN dbo.Producto p ON p.ProductoId = cp.ProductoId
                                    INNER JOIN dbo.Frecuencia f ON f.FrecuenciaId = cp.FrecuenciaId
                                    LEFT JOIN dbo.Dias d ON d.DiaId = cp.DiaSemana";
            leer = command.ExecuteReader();
            dt.Load(leer);
            leer.Close();
            CerrarConexion();
            return dt;

        }

        public DataTable ObtnerFrecuencia()
        {
            command.Connection = AbrirConexion();
            command.CommandText = @"SELECT f.FrecuenciaId, f.Nombre  
                                    FROM dbo.Frecuencia f";
            leer = command.ExecuteReader();
            dt.Load(leer);
            leer.Close();
            CerrarConexion();
            return dt;

        }

        public DataTable ObtnerDiasSemana()
        {
            command.Connection = AbrirConexion();
            command.CommandText = @"SELECT d.DiaId, d.Nombre
                                    FROM dbo.Dias d";
            leer = command.ExecuteReader();
            dt.Load(leer);
            leer.Close();
            CerrarConexion();
            return dt;

        }

        public bool InsertarCompra(FacturacionModel compra)
        {
            bool succes = true;

            using (var cn = GetConnection())
            {
                cn.Open();
                using (var comm = new SqlCommand())
                {
                    comm.Connection = cn;
                    comm.CommandText = @"INSERT INTO dbo.Facturacion(FacturacionId, VendedorId, ClienteId, Fecha, TipoPago, 
                                                                     AbonoInicial, Descuento, TotalPago, FrecuenciaId, Creado, 
                                         							 Modificado, Dias, Monto, Observaciones)
                                         VALUES(@FacturacionId, @VendedorId, @ClienteId, @Fecha, @TipoPago, 
                                                @AbonoInicial, @Descuento, @TotalPago, @FrecuenciaId, GETDATE(), 
                                          	    GETDATE(), 0, 0, @Observaciones)";
                    try
                    {
                        comm.Parameters.AddWithValue("@FacturacionId", compra.FacturacionId);
                        comm.Parameters.AddWithValue("@VendedorId", compra.VendedorId);
                        comm.Parameters.AddWithValue("@ClienteId", compra.ClienteId);
                        comm.Parameters.AddWithValue("@Fecha", compra.Fecha);
                        comm.Parameters.AddWithValue("@TipoPago", compra.TipoPago);
                        comm.Parameters.AddWithValue("@AbonoInicial", compra.AbonoInicial);
                        comm.Parameters.AddWithValue("@Descuento", compra.Descuento);
                        comm.Parameters.AddWithValue("@TotalPago", compra.TotalPago);
                        comm.Parameters.AddWithValue("@FrecuenciaId", compra.FrecuenciaId);
                        comm.Parameters.AddWithValue("@Observaciones", compra.Observaciones);


                        comm.CommandType = CommandType.Text;
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        succes = false;
                    }
                }
            }

            return succes;
        }

        public bool InsertarArticulosPorFaturas(List<ArticuloFactura> af, Guid facturacionId)
        {
            bool succes = true;
            
            foreach(ArticuloFactura articFac in af)
            {
                using (var cn = GetConnection())
                {
                    cn.Open();
                    using (var comm = new SqlCommand())
                    {
                        comm.Connection = cn;
                        comm.CommandText = @"INSERT INTO dbo.ArticulosFactura(ArticulosFacturaId, FacturacionId, ProductoId, Cantidad, Precio, Descuento, Creado, Modificado)
                                             VALUES(NEWID(), @FacturacionId, @ProductoId, @Cantidad, @Precio, @Descuento, GETDATE(), GETDATE())
                                             
                                             UPDATE dbo.Producto
                                             SET Cantidad = p.Cantidad - @Cantidad
                                             FROM dbo.Producto p
                                             WHERE p.ProductoId = @ProductoId";
                        try
                        {
                            comm.Parameters.AddWithValue("@FacturacionId", facturacionId);
                            comm.Parameters.AddWithValue("@ProductoId", articFac.ProductoId);
                            comm.Parameters.AddWithValue("@Cantidad", articFac.Cantidad);
                            comm.Parameters.AddWithValue("@Precio", articFac.Precio);
                            comm.Parameters.AddWithValue("@Descuento", articFac.Descuento);

                            comm.CommandType = CommandType.Text;
                            comm.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            succes = false;
                        }
                    }
                }
            }
            

            return succes;
        }

        public bool ActualizarCompra(Client_Produc clienteProducto)
        {
            bool succes = true;

            using (var cn = GetConnection())
            {
                cn.Open();
                using (var comm = new SqlCommand())
                {
                    comm.Connection = cn;
                    comm.CommandText = @"UPDATE dbo.Client_Produc
                                         SET ClienteId = @ClienteId,
                                             ProductoId = @ProductoId,
                                         	 FechaAdquisicion = @FechaAdquisicion,
                                             MesesPagar = @MesesPagar,
                                             MontoPrima = @MontoPrima,
                                             Nuevo_Saldo = @Nuevo_Saldo,
                                             FrecuenciaId = @FrecuenciaId,
                                             DiaSemana = @DiaSemana,
                                             DiaPrimeraQuincena = @DiaPrimeraQuincena,
                                             DiaSegundaQuincena = @DiaSegundaQuincena,
                                             DiaMes = @DiaMes,
                                             Modificado = GETDATE()
                                         WHERE ClientProducId = @ClientProducId";
                    try
                    {
                        comm.Parameters.AddWithValue("@ClientProducId", clienteProducto.ClientProducId);
                        comm.Parameters.AddWithValue("@ClienteId", clienteProducto.ClienteId);
                        comm.Parameters.AddWithValue("@ProductoId", clienteProducto.ProductoId);
                        comm.Parameters.AddWithValue("@Monto", clienteProducto.Monto);
                        comm.Parameters.AddWithValue("@Nuevo_Saldo", clienteProducto.Nuevo_Saldo);
                        comm.Parameters.AddWithValue("@FechaAdquisicion", clienteProducto.FechaAdquisicion);
                        comm.Parameters.AddWithValue("@MesesPagar", clienteProducto.MesesPagar);
                        comm.Parameters.AddWithValue("@MontoPrima", clienteProducto.MontoPrima);
                        comm.Parameters.AddWithValue("@FrecuenciaId", clienteProducto.FrecuenciaId);
                        comm.Parameters.AddWithValue("@DiaSemana", clienteProducto.DiaSemana);
                        comm.Parameters.AddWithValue("@DiaPrimeraQuincena", clienteProducto.DiaPrimeraQuincena);
                        comm.Parameters.AddWithValue("@DiaSegundaQuincena", clienteProducto.DiaSegundaQuincena);
                        comm.Parameters.AddWithValue("@DiaMes", clienteProducto.DiaMes);

                        comm.CommandType = CommandType.Text;
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        succes = false;
                    }
                }
            }

            return succes;
        }

        public bool EliminarCompra(Guid ClientProducId)
        {
            bool succes = true;

            using (var cn = GetConnection())
            {
                cn.Open();
                using (var comm = new SqlCommand())
                {
                    comm.Connection = cn;
                    comm.CommandText = @"DELETE dbo.Client_Produc
                                         WHERE ClientProducId = @ClientProducId";
                    try
                    {
                        comm.Parameters.AddWithValue("@ClientProducId", ClientProducId);

                        comm.CommandType = CommandType.Text;
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        succes = false;
                    }
                }
            }

            return succes;
        }

        public bool GenerarPlandePago(Guid ClientProducId)
        {
            bool succes = true;

            using (var cn = GetConnection())
            {
                cn.Open();
                using (var comm = new SqlCommand())
                {
                    comm.Connection = cn;
                    comm.CommandText = @"";
                    try
                    {
                        comm.Parameters.AddWithValue("@ClientProducId", ClientProducId);

                        comm.CommandType = CommandType.Text;
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        succes = false;
                    }
                }
            }

            return succes;
        }

        #region vendedor

        public DataTable MostrarVendedores()
        {
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand();
            SqlDataReader leer;

            command.Connection = AbrirConexion();
            command.CommandText = "SELECT VendedorId, Vendedor, Codigo, Direccion, Telefono, Cedula FROM dbo.Vendedor v";
            leer = command.ExecuteReader();
            dt.Load(leer);
            CerrarConexion();
            return dt;

        }

        public bool InsertarVendedor(VendedorModel vendedorModel)
        {
            bool succes = true;

            using (var cn = GetConnection())
            {
                cn.Open();
                using (var comm = new SqlCommand())
                {
                    comm.Connection = cn;
                    comm.CommandText = @"INSERT INTO dbo.Vendedor(VendedorId, Codigo, Vendedor, Direccion, Telefono, Cedula, Creado, Modificado)
                                         VALUES(NEWID(), '', @vendedor, @direccion, @telefono, @cedula, GETDATE(), GETDATE())";
                    try
                    {
                        comm.Parameters.AddWithValue("@vendedor", vendedorModel.vendedor);
                        comm.Parameters.AddWithValue("@Direccion", vendedorModel.Direccion);
                        comm.Parameters.AddWithValue("@Telefono", vendedorModel.Telefono);
                        comm.Parameters.AddWithValue("@Cedula", vendedorModel.Cedula);

                        comm.CommandType = CommandType.Text;
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        succes = false;
                    }
                }
            }

            return succes;

        }

        public bool ActualizarVendedor(VendedorModel vendedorModel)
        {
            bool succes = true;

            using (var cn = GetConnection())
            {
                cn.Open();
                using (var comm = new SqlCommand())
                {
                    comm.Connection = cn;
                    comm.CommandText = @"UPDATE dbo.Vendedor
                                         SET Vendedor = @vendedor,
                                         	 Direccion = @direccion,
                                         	 Telefono = @telefono,
                                         	 Cedula = @cedula,
                                         	 Modificado = GETDATE()
                                         WHERE VendedorId = @vendedorId";
                    try
                    {
                        comm.Parameters.AddWithValue("@vendedor", vendedorModel.vendedor);
                        comm.Parameters.AddWithValue("@direccion", vendedorModel.Direccion);
                        comm.Parameters.AddWithValue("@telefono", vendedorModel.Telefono);
                        comm.Parameters.AddWithValue("@cedula", vendedorModel.Cedula);
                        comm.Parameters.AddWithValue("@vendedorId", vendedorModel.VendedorId);

                        comm.CommandType = CommandType.Text;
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        succes = false;
                    }
                }
            }

            return succes;
        }

        #endregion
    }
}
