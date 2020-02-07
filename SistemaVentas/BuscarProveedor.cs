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
    public partial class BuscarProveedor : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        public BuscarProveedor()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncrearcliente_Click(object sender, EventArgs e)
        {
            CrearProveedor frm = new CrearProveedor();

            frm.Show();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            CrearProveedor frm = new CrearProveedor();
           
            frm.txtproveedor.Text = dataGridView1.CurrentRow.Cells["Proveedor"].Value.ToString();
            frm.txtcontacto.Text = dataGridView1.CurrentRow.Cells["Contacto"].Value.ToString();
            frm.txtcorreo.Text = dataGridView1.CurrentRow.Cells["Correo"].Value.ToString();
            frm.txttelefono1.Text = dataGridView1.CurrentRow.Cells["Telefono1"].Value.ToString();
            frm.txttelefono2.Text = dataGridView1.CurrentRow.Cells["Telefono2"].Value.ToString();
            frm.ProveedorId = dataGridView1.CurrentRow.Cells["ProveedorId"].Value.ToString();

            frm.isedit = true;
            
            frm.Show();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BuscarProveedor_Load(object sender, EventArgs e)
        {
            ListProveedor();
            dataGridView1.Columns["ProveedorId"].Visible = false;
        }

        public void ListProveedor()
        {
            ProductoController productoc = new ProductoController();
            dataGridView1.DataSource = productoc.ObtenerProveedor();
        }

        private void btnproveedorseleccionado_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnproveedorseleccionado_Click(object sender, EventArgs e)
        {
            Producto formProducto = Owner as Producto;

            formProducto.txtproveedor.Text = dataGridView1.CurrentRow.Cells["Proveedor"].Value.ToString();
            formProducto.proveedorId = dataGridView1.CurrentRow.Cells["ProveedorId"].Value.ToString();

            
            this.Close();
        }

        private void BuscarProveedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Producto formProducto = Owner as Producto;
            formProducto.txtArticulo.Focus();
        }

        private void BuscarProveedor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Producto formProducto = Owner as Producto;
            formProducto.txtArticulo.Focus();
        }
    }
}
