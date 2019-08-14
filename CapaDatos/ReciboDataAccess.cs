﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaEntidad;

namespace CapaDatos
{
    public class ReciboDataAccess : ConnectionSql
    {
        SqlDataReader leer;
        DataTable dt = new DataTable();
        SqlCommand command = new SqlCommand();

        public DataTable ObtnerRecibos()
        {
            command.Connection = AbrirConexion();
            command.CommandText = @"SELECT r.ReciboId, r.Codigo, r.ClienteId, cp.ClientProducId,  c.PrimerNombre, c.PrimerApellido, 
                                           r.FechaAbono, r.Concepto, p.Nombre Compra, r.MontoAbono, r.NuevoSaldo, r.Creado, r.Modificado
                                    FROM dbo.Recibo r
                                    INNER JOIN dbo.Cliente c ON c.ClienteId = r.ClienteId
                                    INNER JOIN dbo.Client_Produc cp ON cp.ClientProducId = r.ClientProducId
                                    INNER JOIN dbo.Producto p ON p.ProductoId = cp.ProductoId";
            leer = command.ExecuteReader();
            dt.Load(leer);
            leer.Close();
            CerrarConexion();
            return dt;

        }
        public bool InsertarRecibo(Recibo recibo)
        {
            bool succes = true;

            using (var cn = GetConnection())
            {
                cn.Open();
                using (var comm = new SqlCommand())
                {
                    comm.Connection = cn;
                    comm.CommandText = @"UPDATE dbo.Client_Produc
                                         SET Nuevo_Saldo = @NuevoSaldo
                                         WHERE ClientProducId = @ClientProducId
                                         
                                         INSERT INTO dbo.Recibo(ReciboId, Codigo, ClienteId, ClientProducId, FechaAbono, Concepto, MontoAbono,
                                                                NuevoSaldo, Creado, Modificado)
                                         VALUES(NEWID(), @Codigo, @ClienteId, @ClientProducId, @FechaAbono, @Concepto, @MontoAbono,
                                                @NuevoSaldo, GETDATE(), GETDATE())";
                    try
                    {
                        comm.Parameters.AddWithValue("@Codigo", recibo.Codigo);
                        comm.Parameters.AddWithValue("@ClienteId", recibo.ClienteId);
                        comm.Parameters.AddWithValue("@FechaAbono", recibo.FechaAbono);
                        comm.Parameters.AddWithValue("@Concepto", recibo.Concepto);
                        comm.Parameters.AddWithValue("@MontoAbono", recibo.MontoAbono);
                        comm.Parameters.AddWithValue("@NuevoSaldo", recibo.NuevoSaldo);
                        comm.Parameters.AddWithValue("@ClientProducId", recibo.ClientProducId);

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

        public bool ActualizarRecibo(Recibo recibo)
        {
            bool succes = true;

            using (var cn = GetConnection())
            {
                cn.Open();
                using (var comm = new SqlCommand())
                {
                    comm.Connection = cn;
                    comm.CommandText = @"UPDATE dbo.Recibo
                                         SET Codigo = @Codigo,
                                             ClienteId = @ClienteId,
                                             FechaAbono = @FechaAbono,
                                             Concepto = @Concepto,
                                             MontoAbono = @MontoAbono,
                                             NuevoSaldo = @NuevoSaldo,
                                             ClientProducId = @ClientProducId,
                                             Modificado = GETDATE()
                                         WHERE ReciboId = @ReciboId";
                    try
                    {
                        comm.Parameters.AddWithValue("@ReciboId", recibo.ReciboId);
                        comm.Parameters.AddWithValue("@Codigo", recibo.Codigo);
                        comm.Parameters.AddWithValue("@ClienteId", recibo.ClienteId);
                        comm.Parameters.AddWithValue("@FechaAbono", recibo.FechaAbono);
                        comm.Parameters.AddWithValue("@Concepto", recibo.Concepto);
                        comm.Parameters.AddWithValue("@MontoAbono", recibo.MontoAbono);
                        comm.Parameters.AddWithValue("@NuevoSaldo", recibo.NuevoSaldo);
                        comm.Parameters.AddWithValue("@ClientProducId", recibo.ClientProducId);
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

        public bool EliminarRecibo(Guid reciboId)
        {
            bool succes = true;

            using (var cn = GetConnection())
            {
                cn.Open();
                using (var comm = new SqlCommand())
                {
                    comm.Connection = cn;
                    comm.CommandText = @"DELETE dbo.Recibo
                                         WHERE ReciboId = @ReciboId";
                    try
                    {
                        comm.Parameters.AddWithValue("@ReciboId", reciboId);

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
