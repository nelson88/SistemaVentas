using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CapaNegocio;
using CapaEntidad;

namespace SistemaVentas
{
    public partial class BuscarClientes : Form
    {
        public bool isRecibo = true;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        public BuscarClientes()
        {
            InitializeComponent();
        }

        private void BuscarClientes_Load(object sender, EventArgs e)
        {
            ListClientes();
            dataGridView1.Columns["ClienteId"].Visible = false;
        }

        public void ListClientes()
        {
            ClienteController con = new ClienteController();
            dataGridView1.DataSource = con.mostrarCliente();
        }

        private void BuscarClientes_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(isRecibo)
            {
                Recibo formRecibo = Owner as Recibo;

                formRecibo.txtcliente.Text = dataGridView1.CurrentRow.Cells["PrimerNombre"].Value.ToString();
                formRecibo.clienteId = dataGridView1.CurrentRow.Cells["ClienteId"].Value.ToString();
                this.Close();
            }
            else
            {
                AsignacionProductoCliente formcompra = Owner as AsignacionProductoCliente;

                formcompra.txtcliente.Text = dataGridView1.CurrentRow.Cells["PrimerNombre"].Value.ToString();
                formcompra.clienteId = dataGridView1.CurrentRow.Cells["ClienteId"].Value.ToString();
                this.Close();
            }

            isRecibo = true;
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (isRecibo)
            {
                Recibo formRecibo = Owner as Recibo;

                formRecibo.txtcliente.Text = dataGridView1.CurrentRow.Cells["PrimerNombre"].Value.ToString();
                formRecibo.clienteId = dataGridView1.CurrentRow.Cells["ClienteId"].Value.ToString();
                this.Close();
            }
            else
            {
                AsignacionProductoCliente formcompra = Owner as AsignacionProductoCliente;

                formcompra.txtcliente.Text = dataGridView1.CurrentRow.Cells["PrimerNombre"].Value.ToString();
                formcompra.clienteId = dataGridView1.CurrentRow.Cells["ClienteId"].Value.ToString();
                this.Close();
            }

            isRecibo = true;
        }

        private void btncrearcliente_Click(object sender, EventArgs e)
        {
            CrearCliente frm = new CrearCliente();
            
            frm.Show();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            CrearCliente cc = new CrearCliente();
            
            cc.clienteId = dataGridView1.CurrentRow.Cells["ClienteId"].Value.ToString();
            cc.nombre = dataGridView1.CurrentRow.Cells["PrimerNombre"].Value.ToString();
            cc.direccion = dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();
            cc.telefono = dataGridView1.CurrentRow.Cells["Direccion"].Value.ToString();
            cc.cedula = dataGridView1.CurrentRow.Cells["Cedula"].Value.ToString();
            cc.isedit = true;

            cc.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
