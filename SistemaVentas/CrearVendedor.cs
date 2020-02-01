using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas
{
    public partial class CrearVendedor : Form
    {
        VendedorModel vendedormodel = new VendedorModel();
        CompraController comprac = new CompraController();

        public bool isedit = false;
        public string vendedorId;
        public string vendedor;
        public string direccion;
        public string telefono;
        public string cedula;

        public CrearVendedor()
        {
            InitializeComponent();
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            bool sucess = false;
            sucess = ClienteValidacion();

            if (sucess)
            {
                vendedormodel.vendedor = txtnombre.Text;
                vendedormodel.Direccion = txtdireccion.Text;
                vendedormodel.Telefono = txttelefono.Text;
                vendedormodel.Cedula = txtcedula.Text;

                if (isedit == false)
                {
                    if (comprac.InsertarVendedor(vendedormodel))
                    {

                        //BuscarClientes bclientes = new BuscarClientes();
                        //bclientes.ListClientes();
                        this.Close();
                    }
                }
                else
                {
                    vendedormodel.VendedorId = new Guid(vendedorId);
                    try
                    {
                        if (comprac.ActualizarVendedor(vendedormodel))
                        {
                            //BuscarClientes bclientes = new BuscarClientes();
                            //bclientes.ListClientes();
                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo insertar los datos por: " + ex);
                    }
                }
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CrearVendedor_Load(object sender, EventArgs e)
        {
            if (isedit)
            {
                this.txtnombre.Text = vendedor;
                this.txtdireccion.Text = direccion;
                this.txttelefono.Text = telefono;
                this.txtcedula.Text = cedula;
            }
        }

        public bool ClienteValidacion()
        {
            bool success = false;
            string nombre = txtnombre.Text;

            if (nombre != "")
            {
                success = true;
            }


            return success;
        }
    }
}
