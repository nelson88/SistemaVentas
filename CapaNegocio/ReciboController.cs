using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class ReciboController
    {
        ReciboDataAccess data = new ReciboDataAccess();

        public DataTable ObtenerRecibos()
        {
            DataTable dt = new DataTable();
            dt = data.ObtnerRecibos();
            return dt;
        }

        public DataTable ListarAbonos(Guid FacturacionId)
        {
            DataTable dt = new DataTable();
            dt = data.ListarAbonos(FacturacionId);
            return dt;
        }

        public bool InsertarAbono(AbonoModel abonoModel)
        {
            bool succes = true;
            succes = data.InsertarAbono(abonoModel);
            
            return succes;
        }

        public DataTable ListarProductoFacturados(Guid FacturacionId)
        {
            DataTable dt = new DataTable();
            dt = data.ListarProductoFacturados(FacturacionId);
            return dt;
        }

        public bool InsertarRecibo(Recibo recibo)
        {
            bool succes = true;
            succes = data.InsertarRecibo(recibo);
            return succes;
        }

        public bool ActualizarRecibo(Recibo recibo)
        {
            bool succes = true;
            data.ActualizarRecibo(recibo);
            return succes;
        }

        public bool EliminarRecibo(Guid reciboId)
        {
            bool succes = true;
            data.EliminarRecibo(reciboId);
            return succes;
        }
    }
}
