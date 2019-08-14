using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class LoginDataAccess : ConnectionSql
    {
        public bool LoginValidate(string user, string pass)
        {
            using (var cn = GetConnection())
            {
                cn.Open();
                using (var comm = new SqlCommand())
                {
                    comm.Connection = cn;
                    comm.CommandText = @"SELECT * FROM dbo.Usuario u 
                                         WHERE u.Nombre = @nombre AND u.Password = @password";
                    comm.Parameters.AddWithValue("@nombre", user);
                    comm.Parameters.AddWithValue("@password", pass);
                    comm.CommandType = CommandType.Text;
                    SqlDataReader reader = comm.ExecuteReader();
                    if(reader.HasRows)
                    {
                        return true;
                    }else
                    {
                        return false;
                    }
                }
            }
        }
    }
}
