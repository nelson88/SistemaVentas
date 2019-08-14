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
    public partial class BuscarCompras : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        public BuscarCompras()
        {
            InitializeComponent();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BuscarCompras_Load(object sender, EventArgs e)
        {
            ListCompras();
            dataGridView1.Columns["ClientProducId"].Visible = false;
            dataGridView1.Columns["ClienteId"].Visible = false;
            dataGridView1.Columns["ProductoId"].Visible = false;
            dataGridView1.Columns["FrecuenciaId"].Visible = false;
            dataGridView1.Columns["DiaSemana"].Visible = false;
        }

        private void ListCompras()
        {
            CompraController con = new CompraController();
            dataGridView1.DataSource = con.ObtenerCompra();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Recibo formRecibo = Owner as Recibo;

            formRecibo.txtcompra.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
            formRecibo.ClientProducId = dataGridView1.CurrentRow.Cells["ClientProducId"].Value.ToString();
            formRecibo.txtmontoabono.Enabled = true;
            formRecibo.montoProducto = dataGridView1.CurrentRow.Cells["Nuevo_Saldo"].Value.ToString();

            this.Close();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            Recibo formRecibo = Owner as Recibo;

            formRecibo.txtcompra.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
            formRecibo.ClientProducId = dataGridView1.CurrentRow.Cells["ClientProducId"].Value.ToString();
            formRecibo.txtmontoabono.Enabled = true;
            formRecibo.montoProducto = dataGridView1.CurrentRow.Cells["Nuevo_Saldo"].Value.ToString();

            this.Close();
        }
    }
}
