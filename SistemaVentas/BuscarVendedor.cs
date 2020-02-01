using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas
{
    public partial class BuscarVendedor : Form
    {
        CompraController comprac = new CompraController();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        public BuscarVendedor()
        {
            InitializeComponent();
        }

        private void BuscarVendedor_Load(object sender, EventArgs e)
        {
            ListVendedores();
            dataGridView1.Columns["VendedorId"].Visible = false;
        }

        public void ListVendedores()
        {
            dataGridView1.DataSource = comprac.MostrarVendedores();
        }

        private void btncrearcliente_Click(object sender, EventArgs e)
        {
            CrearVendedor frm = new CrearVendedor();

            frm.Show();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            CrearVendedor cv = new CrearVendedor();

            cv.vendedorId = dataGridView1.CurrentRow.Cells["VendedorId"].Value.ToString();
            cv.vendedor = dataGridView1.CurrentRow.Cells["Vendedor"].Value.ToString();
            cv.direccion = dataGridView1.CurrentRow.Cells["Direccion"].Value.ToString();
            cv.telefono = dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();
            cv.cedula = dataGridView1.CurrentRow.Cells["Cedula"].Value.ToString();
            cv.isedit = true;

            cv.Show();
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

        private void btnvendedorseleccionado_Click(object sender, EventArgs e)
        {
            Compras formCompras = Owner as Compras;

            formCompras.txtvendedor.Text = dataGridView1.CurrentRow.Cells["Vendedor"].Value.ToString();
            formCompras.vendedorId = dataGridView1.CurrentRow.Cells["VendedorId"].Value.ToString();
            this.Close();
        }
    }
}
