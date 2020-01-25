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
    public class ClienteDataAccess : ConnectionSql
    {   
        public DataTable mostrar()
        {
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand();
            SqlDataReader leer;

            command.Connection = AbrirConexion();
            command.CommandText = "SELECT c.ClienteId, PrimerNombre, Telefono, Cedula, Direccion FROM dbo.Cliente c";
            leer = command.ExecuteReader();
            dt.Load(leer);
            CerrarConexion();
            return dt;

        }

        public DataTable ObtnerDeudores()
        {
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand();
            SqlDataReader leer;

            command.Connection = AbrirConexion();
            command.CommandText = "SELECT * FROM dbo.Cliente";
            leer = command.ExecuteReader();
            dt.Load(leer);
            CerrarConexion();
            return dt;

        }
        public bool ActualizarClientes(Cliente c)
        {
            bool succes = true;

            using (var cn = GetConnection())
            {
                cn.Open();
                using (var comm = new SqlCommand())
                {
                    comm.Connection = cn;
                    comm.CommandText = @"UPDATE dbo.Cliente
                                         SET Cedula = @cedula,
                                             PrimerNombre = @primernombre,
                                             SegundoNombre = @Segundonombre,
                                             PrimerApellido= @primerapellido,
                                             SegundoApellido = @segundoapellido,
                                         	 Direccion = @direccion,
                                             Telefono= @telefono,
                                             Creado = GETDATE(),
	                                         Modificado = GETDATE()
                                         WHERE ClienteId = @clienteId";
                    try
                    {
                        comm.Parameters.AddWithValue("@clienteId", c.ClienteId);
                        comm.Parameters.AddWithValue("@cedula",c.Cedula );
                        comm.Parameters.AddWithValue("@primernombre", c.PrimerNombre);
                        comm.Parameters.AddWithValue("@segundonombre", c.SegundoNombre);
                        comm.Parameters.AddWithValue("@primerapellido", c.PrimerApellido);
                        comm.Parameters.AddWithValue("@segundoapellido", c.SegundoApellido);
                        comm.Parameters.AddWithValue("@direccion", c.Direccion);
                        comm.Parameters.AddWithValue("@telefono", c.Telefono);


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
        public bool InsertarClientes( Cliente clien) 
        {
            bool succes = true;

            using (var cn = GetConnection())
            {
                cn.Open();
                using (var comm = new SqlCommand())
                {
                    comm.Connection = cn;
                    comm.CommandText = @"INSERT INTO dbo.Cliente(ClienteId, Cedula, PrimerNombre, PrimerApellido, SegundoNombre, SegundoApellido, Direccion, Telefono,Creado,Modificado)
                                         VALUES(NEWID(), @cedula, @primernombre, @primerapellido, @segundonombre, @segundoapellido,@direccion,@telefono, GETDATE(), GETDATE())";
                    try
                    {
                        comm.Parameters.AddWithValue("@cedula", clien.Cedula);
                        comm.Parameters.AddWithValue("@primernombre", clien.PrimerNombre);
                        comm.Parameters.AddWithValue("@segundonombre", clien.SegundoNombre);
                        comm.Parameters.AddWithValue("@primerapellido", clien.PrimerApellido);
                        comm.Parameters.AddWithValue("@segundoapellido", clien.SegundoApellido);
                        comm.Parameters.AddWithValue("@direccion", clien.Direccion);
                        comm.Parameters.AddWithValue("@telefono", clien.Telefono);
                       

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
        public bool EliminarClientes(Guid clienteId)
        {
            bool succes = true;

            using (var cn = GetConnection())
            {
                cn.Open();
                using (var comm = new SqlCommand())
                {
                    comm.Connection = cn;
                    comm.CommandText = @"DELETE dbo.Cliente
                                         WHERE ClienteId = @clienteId";
                    try
                    {
                        comm.Parameters.AddWithValue("@clienteId", clienteId);

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