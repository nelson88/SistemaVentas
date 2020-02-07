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
    public partial class VerAbonos : Form
    {
        public VerAbonos()
        {
            InitializeComponent();
        }

        private void VerAbonos_Load(object sender, EventArgs e)
        {
            ContenidoInicial ci = Owner as ContenidoInicial;
            ReciboController reciboc = new ReciboController();
            dataGridView1.DataSource = reciboc.ListarAbonos(ci.FacturacionId);
            dataGridView1.Columns["AbonoId"].Visible = false;
            dataGridView1.Columns["FacturacionId"].Visible = false;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
