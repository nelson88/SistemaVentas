using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaNegocio
{
    public class ClienteController
    {
        ClienteDataAccess data = new ClienteDataAccess();

        public DataTable mostrarCliente()
        {
            DataTable dt = new DataTable();
            dt = data.mostrar();
            return dt;
        }

        public DataTable ObtnerDeudores()
        {
            DataTable dt = new DataTable();
            dt = data.ObtnerDeudores();
            return dt;
        }

        public bool Insertarcli(Cliente cli)
        {
            bool succes = true;
            succes = data.InsertarClientes(cli);
            return succes;
        }

        public bool ActualizarClientes(Cliente cliente)
        {
            bool succes = true;
            data.ActualizarClientes(cliente);
            return succes;
        }
        public bool EliminarCli(Guid clienteId)
        {
            bool succes = true;
            data.EliminarClientes(clienteId);
            return succes;
        }
    }

}
