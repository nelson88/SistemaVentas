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
    public partial class BuscarProducto : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        public BuscarProducto()
        {
            InitializeComponent();
        }

        private void BuscarProducto_Load(object sender, EventArgs e)
        {
            ListProductos();
            dataGridView1.Columns["ProductoId"].Visible = false;
        }

        private void ListProductos()
        {
            ProductoController con = new ProductoController();
            DataTable dt = new DataTable();

            dt = con.ObtenerProductos();

            foreach(DataRow dr in dt.Rows)
            {
                if(Convert.ToInt32(dr[5].ToString()) == 0)
                {
                    dr.Delete();
                }
            }

            dataGridView1.DataSource = dt;
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AsignacionProductoCliente formRecibo = Owner as AsignacionProductoCliente;

            formRecibo.txtproducto.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
            formRecibo.txtmonto.Text = dataGridView1.CurrentRow.Cells["Monto"].Value.ToString();
            formRecibo.txtnuevosaldo.Text = dataGridView1.CurrentRow.Cells["Monto"].Value.ToString();
            formRecibo.productoId = dataGridView1.CurrentRow.Cells["ProductoId"].Value.ToString();
            this.Close();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            AsignacionProductoCliente formRecibo = Owner as AsignacionProductoCliente;

            formRecibo.txtproducto.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
            formRecibo.txtmonto.Text = dataGridView1.CurrentRow.Cells["Monto"].Value.ToString();
            formRecibo.txtnuevosaldo.Text = dataGridView1.CurrentRow.Cells["Monto"].Value.ToString();
            formRecibo.productoId = dataGridView1.CurrentRow.Cells["ProductoId"].Value.ToString();
            this.Close();
        }
    }
}
