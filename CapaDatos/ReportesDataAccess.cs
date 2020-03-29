using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ReportesDataAccess : ConnectionSql
    {
        public DataTable ObtnerSaldoDiario(DateTime fromDate, DateTime toDate)
        {
            SqlDataReader leer;
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand();

            command.Connection = AbrirConexion();
            command.CommandText = @"SELECT f.FacturacionId, a.AbonoId, a.Creado, a.Fecha, a.Abono
	                                FROM dbo.Facturacion f
	                                INNER JOIN dbo.Abono a ON a.FacturacionId = f.FacturacionId
	                                INNER JOIN dbo.Cliente c ON c.ClienteId = f.ClienteId
	                                where a.Creado between @fromDate  and @toDate 
	                                GROUP BY f.FacturacionId, a.AbonoId, a.Creado, a.Fecha, a.Abono
	                                ORDER BY a.Creado ASC";

            command.Parameters.AddWithValue("@fromDate", fromDate);
            command.Parameters.AddWithValue("@toDate", toDate);

            leer = command.ExecuteReader();
            dt.Load(leer);
            leer.Close();
            CerrarConexion();
            return dt;
        }


    }
}
