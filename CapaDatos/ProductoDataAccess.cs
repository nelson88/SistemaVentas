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
            command.CommandText = "SELECT * FROM dbo.Producto";
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

        public bool InsertarProducto(Producto producto)
        {
            bool succes = true;

            using (var cn = GetConnection())
            {
                cn.Open();
                using (var comm = new SqlCommand())
                {
                    comm.Connection = cn;
                    comm.CommandText = @"INSERT INTO dbo.Producto(ProductoId, Codigo, Nombre, Cantidad, Descripcion, Monto, Creado, Modificado)
                                         VALUES(NEWID(), @codigo, @nombre, @cantidad, @descripcion, @monto, GETDATE(), GETDATE())";
                    try
                    {
                        comm.Parameters.AddWithValue("@productoId", producto.ProductoId);
                        comm.Parameters.AddWithValue("@codigo", producto.Codigo);
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
                                         SET Codigo = @codigo,
                                             Nombre = @nombre,
                                             Cantidad = @cantidad,
                                         	 Descripcion = @descripcion,
                                         	 Monto = @monto,
	                                         Modificado = GETDATE()
                                         WHERE ProductoId = @productoId";
                    try
                    {
                        comm.Parameters.AddWithValue("@productoId", producto.ProductoId);
                        comm.Parameters.AddWithValue("@codigo", producto.Codigo);
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
