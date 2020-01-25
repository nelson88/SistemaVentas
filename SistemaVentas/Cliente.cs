using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;

namespace SistemaVentas
{
    
    public partial class Cliente : Form
    {
        ClienteController cli = new ClienteController();
        VentaModel venta = new VentaModel();
        private bool Editar = false;
        private string clienteId = null;
        public Cliente()
        {
            InitializeComponent();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            MostrarClientes();
            dataGridView1.Columns["ClienteId"].Visible = false;
        }

        private void MostrarClientes()
        {
            dataGridView1.DataSource = cli.mostrarCliente();            
        }
        private void LimpiarTextBox()
        {
            textBoxcedula.Text= "";
            textBoxprimernombre.Text= "";
            //textBoxsegundonombre.Text= "";
            //textBoxprimerapellido.Text= "";
            //textBoxsegundoapellido.Text = "";
            textBoxdireccion.Text= "";
            textBoxtelefono.Text= "";
        }
        
        private void ObtenerClientes()
        {
            ClienteController con = new ClienteController();
            dataGridView1.DataSource = con.mostrarCliente();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            bool sucess = false;
            sucess = ClienteValidacion();

            if (sucess)
            {
                venta.cliente.PrimerNombre = textBoxprimernombre.Text;
                venta.cliente.Cedula = Convert.ToString(textBoxcedula.Text);
                venta.cliente.Telefono = textBoxtelefono.Text;
                venta.cliente.Direccion = textBoxdireccion.Text;
                venta.cliente.SegundoNombre = "";
                venta.cliente.PrimerApellido = "";
                venta.cliente.SegundoApellido = "";
                

                if (Editar == false)
                {
                    if (cli.Insertarcli(venta.cliente))
                    {
                        LimpiarTextBox();
                        ObtenerClientes();
                    }
                }
                if (Editar == true)
                {
                    venta.cliente.ClienteId = new Guid(clienteId);
                    try
                    {
                        if (cli.ActualizarClientes(venta.cliente))
                        {
                            LimpiarTextBox();
                            ObtenerClientes();
                            Editar = false;
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
            
            //string cedula = Convert.ToString(textBoxcedula.Text);
            string primernombre = textBoxprimernombre.Text;
            //string primerApellido = textBoxprimerapellido.Text;
            //string direccion = textBoxdireccion.Text;
            //string telefono = textBoxtelefono.Text;
            
            if (primernombre != "" /*&& cedula != "" && primerApellido != "" && direccion != "" && telefono != ""*/)
            {
                success = true;
            }


            return success;
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                clienteId = dataGridView1.CurrentRow.Cells["ClienteId"].Value.ToString();
                if (cli.EliminarCli(new Guid(clienteId)))
                {
                    MessageBox.Show("El registro fue eliminado");
                    ObtenerClientes();
                }
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                textBoxcedula.Text = dataGridView1.CurrentRow.Cells["Cedula"].Value.ToString();
                textBoxprimernombre.Text = dataGridView1.CurrentRow.Cells["PrimerNombre"].Value.ToString();
                textBoxdireccion.Text = dataGridView1.CurrentRow.Cells["Direccion"].Value.ToString();
                textBoxtelefono.Text = dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();
                clienteId = dataGridView1.CurrentRow.Cells["ClienteId"].Value.ToString();

            }
            else
            {
                MessageBox.Show("Seleccione una fila porfavor!!");
            }
        }
    }
}
