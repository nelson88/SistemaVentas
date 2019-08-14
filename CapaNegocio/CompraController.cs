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
    public class CompraController
    {
        CompraDataAccess data = new CompraDataAccess();

        public DataTable ObtenerCompra()
        {
            DataTable dt = new DataTable();
            dt = data.ObtnerCompras();
            return dt;
        }

        public DataTable ObtnerFrecuencia()
        {
            DataTable dt = new DataTable();
            dt = data.ObtnerFrecuencia();
            return dt;
        }

        public DataTable ObtnerDiasSemana()
        {
            DataTable dt = new DataTable();
            dt = data.ObtnerDiasSemana();
            return dt;
        }

        public bool InsertarCompra(Client_Produc compra)
        {
            bool succes = true;
            succes = data.InsertarCompra(compra);
            return succes;
        }

        public bool ActualizarCompra(Client_Produc compra)
        {
            bool succes = true;
            data.ActualizarCompra(compra);
            return succes;
        }

        public bool EliminarCompra(Guid compraId)
        {
            bool succes = true;
            data.EliminarCompra(compraId);
            return succes;
        }

        public bool GenerarPlandePago(Guid compraId)
        {
            bool succes = true;
            data.GenerarPlandePago(compraId);
            return succes;
        }

    }
}
