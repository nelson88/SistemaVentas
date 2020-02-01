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
    public partial class CrearCliente : Form
    {
        ClienteController cli = new ClienteController();
        VentaModel venta = new VentaModel();
        public bool isedit = false;
        public string clienteId;
        public string nombre;
        public string direccion;
        public string telefono;
        public string cedula;

        public CrearCliente()
        {
            InitializeComponent();
        }

        private void CrearCliente_Load(object sender, EventArgs e)
        {
            if(isedit)
            {
                this.txtnombre.Text = nombre;
                this.txtdireccion.Text = direccion;
                this.txttelefono.Text= telefono;
                this.txtcedula.Text = cedula;
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            bool sucess = false;
            sucess = ClienteValidacion();

            if (sucess)
            {
                venta.cliente.PrimerNombre = txtnombre.Text;
                venta.cliente.Direccion = txtdireccion.Text;
                venta.cliente.Telefono = txttelefono.Text;
                venta.cliente.Cedula = Convert.ToString(txtcedula.Text);
                venta.cliente.SegundoNombre = "";
                venta.cliente.PrimerApellido = "";
                venta.cliente.SegundoApellido = "";


                if (isedit == false)
                {
                    if (cli.Insertarcli(venta.cliente))
                    {
                        
                        BuscarClientes bclientes = new BuscarClientes();
                        bclientes.ListClientes();
                        this.Close();
                        //LimpiarTextBox();
                        //ObtenerClientes();
                    }
                }else{
                    venta.cliente.ClienteId = new Guid(clienteId);
                    try
                    {
                        if (cli.ActualizarClientes(venta.cliente))
                        {
                            BuscarClientes bclientes = new BuscarClientes();
                            bclientes.ListClientes();
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
