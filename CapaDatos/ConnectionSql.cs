using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public abstract class ConnectionSql
    {
        private readonly string connectionString;
        private SqlConnection Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconeccion"].ConnectionString);
        public ConnectionSql()
        {
            connectionString = ConfigurationManager.ConnectionStrings["sqlconeccion"].ConnectionString;
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}
