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
    public class ProductoDataAccess : ConnectionSql
    {
        SqlDataReader leer;
        DataTable dt = new DataTable();
        SqlCommand command = new SqlCommand();
        public DataTable ObtnerProductos()
        {
            command.Connection = AbrirConexion();
            command.CommandText = @"SELECT p.ProductoId, pc.ProductoCategoriaId, 'BMC-'+p.Codigo Codigo, pc.Categoria, p.Nombre, p.Cantidad, p.Descripcion, p.Monto, p.Modificado
                                   FROM dbo.Producto p
                                   INNER JOIN dbo.ProductoCategoria pc ON pc.ProductoCategoriaId = p.ProductoCategoriaId";
            leer = command.ExecuteReader();
            dt.Load(leer);
            CerrarConexion();
            return dt;

        }

        public DataTable ObtnerProductosByCategoria(int ProductoCategoriaId, string nombre)
        {
            command.Connection = AbrirConexion();
            command.CommandText = @"
                                    IF @ProductoCategoriaId <> 1
                                    BEGIN
                                        SELECT p.ProductoId, pc.ProductoCategoriaId, 'BMC-'+p.Codigo Codigo, pc.Categoria, p.Nombre, p.Cantidad, p.Descripcion, p.Monto, p.Modificado
                                        FROM dbo.Producto p
                                        INNER JOIN dbo.ProductoCategoria pc ON pc.ProductoCategoriaId = p.ProductoCategoriaId
                                        WHERE p.ProductoCategoriaId = @ProductoCategoriaId
                                        ORDER BY p.Codigo
                                    END
                                    ELSE
                                    BEGIN
                                        SELECT p.ProductoId, pc.ProductoCategoriaId, 'BMC-'+p.Codigo Codigo, pc.Categoria, p.Nombre, p.Cantidad, p.Descripcion, p.Monto, p.Modificado
                                        FROM dbo.Producto p
                                        INNER JOIN dbo.ProductoCategoria pc ON pc.ProductoCategoriaId = p.ProductoCategoriaId
                                    END";




            command.Parameters.AddWithValue("@ProductoCategoriaId", ProductoCategoriaId);
            command.Parameters.AddWithValue("@nombre", nombre);

            leer = command.ExecuteReader();
            dt.Load(leer);
            CerrarConexion();
            return dt;

        }

        public Producto ObtnerProductos(Guid productoId)
        {
            Producto data = new Producto();

            using (var cn = GetConnection())
            {
                cn.Open();
                using (var comm = new SqlCommand())
                {
                    comm.Connection = cn;
                    comm.CommandText = @"SELECT p.ProductoId, 
                                                p.Codigo,
                                         	    p.Nombre, 
                                         	    p.Cantidad, 
                                         	    p.Descripcion, 
                                         	    p.Monto,
                                         	    p.Creado,
                                         	    p.Modificado
                                         FROM dbo.Producto p
                                         WHERE p.ProductoId = @productoId";
                    try
                    {
                        comm.Parameters.AddWithValue("@productoId", productoId);
                        comm.CommandType = CommandType.Text;
                        SqlDataReader reader = comm.ExecuteReader();
                        if (reader.HasRows)
                        {
                            data.ProductoId = (Guid)reader["ProductoId"];
                            data.Codigo = reader["Codigo"] as string;
                            data.Nombre = reader["Nombre"] as string;
                            data.Cantidad = (int)reader["Cantidad"];
                            data.Descripcion = reader["Descripcion"] as string;
                            data.Monto = (decimal)reader["Monto"];
                            data.Creado = (DateTime)reader["Creado"];
                            data.Modificado = (DateTime)reader["Modificado"];
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }

            return data;
        }

        public DataTable ObtnerCategoria()
        {
            command.Connection = AbrirConexion();
            command.CommandText = @"SELECT pc.ProductoCategoriaId, pc.Categoria FROM dbo.ProductoCategoria pc";
            leer = command.ExecuteReader();
            dt.Load(leer);
            leer.Close();
            CerrarConexion();
            return dt;

        }

        public bool InsertarProducto(Producto producto)
        {
            bool succes = true;

            using (var cn = GetConnection())
            {
                cn.Open();
                using (var comm = new SqlCommand())
                {
                    comm.Connection = cn;
                    comm.CommandText = @"DECLARE @CodigoMax VARCHAR(10)
                                         DECLARE @CodigoNuevo VARCHAR(10)

                                         SELECT @CodigoMax = ISNULL(max(Codigo), '00000')
                                         FROM  dbo.Producto p
                                         WHERE p.ProductoCategoriaId = @ProductoCategoriaId

                                         SELECT @CodigoNuevo = dbo.GeneradorCodigoProducto(@CodigoMax);

                                         INSERT INTO dbo.Producto(ProductoId, Codigo, ProductoCategoriaId, Nombre, Cantidad, Descripcion, Monto, Creado, Modificado)
                                         VALUES(NEWID(), @CodigoNuevo, @ProductoCategoriaId, @nombre, @cantidad, @descripcion, @monto, GETDATE(), GETDATE())";
                    try
                    {
                        comm.Parameters.AddWithValue("@productoId", producto.ProductoId);
                        comm.Parameters.AddWithValue("@ProductoCategoriaId", producto.ProductoCategoriaId);
                        comm.Parameters.AddWithValue("@nombre", producto.Nombre);
                        comm.Parameters.AddWithValue("@cantidad", producto.Cantidad);
                        comm.Parameters.AddWithValue("@descripcion", producto.Descripcion);
                        comm.Parameters.AddWithValue("@monto", producto.Monto);

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

        public bool ActualizarProducto(Producto producto)
        {
            bool succes = true;

            using (var cn = GetConnection())
            {
                cn.Open();
                using (var comm = new SqlCommand())
                {
                    comm.Connection = cn;
                    comm.CommandText = @"UPDATE dbo.Producto
                                         SET Nombre = @nombre,
                                             Cantidad = @cantidad,
                                         	 Descripcion = @descripcion,
                                         	 Monto = @monto,
	                                         Modificado = GETDATE()
                                         WHERE ProductoId = @productoId";
                    try
                    {
                        comm.Parameters.AddWithValue("@productoId", producto.ProductoId);
                        comm.Parameters.AddWithValue("@nombre", producto.Nombre);
                        comm.Parameters.AddWithValue("@cantidad", producto.Cantidad);
                        comm.Parameters.AddWithValue("@descripcion", producto.Descripcion);
                        comm.Parameters.AddWithValue("@monto", producto.Monto);

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

        public bool EliminarProducto(Guid productoId)
        {
            bool succes = true;

            using (var cn = GetConnection())
            {
                cn.Open();
                using (var comm = new SqlCommand())
                {
                    comm.Connection = cn;
                    comm.CommandText = @"DELETE dbo.Producto
                                         WHERE ProductoId = @productoId";
                    try
                    {
                        comm.Parameters.AddWithValue("@productoId", productoId);

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
    }
}
