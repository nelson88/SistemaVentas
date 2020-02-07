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
    public partial class VerProductos : Form
    {
        public VerProductos()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VerProductos_Load(object sender, EventArgs e)
        {
            ContenidoInicial ci = Owner as ContenidoInicial;
            ReciboController reciboc = new ReciboController();
            dataGridView1.DataSource = reciboc.ListarProductoFacturados(ci.FacturacionId);
            dataGridView1.Columns["ArticulosFacturaId"].Visible = false;
            dataGridView1.Columns["FacturacionId"].Visible = false;
            dataGridView1.Columns["ProductoId"].Visible = false;
        }
    }
}
