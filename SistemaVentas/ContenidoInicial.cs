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

namespace SistemaVentas
{
    public partial class ContenidoInicial : Form
    {
        public Guid FacturacionId;
        public ContenidoInicial()
        {
            InitializeComponent();

        }

        private void ContenidoInicial_Load(object sender, EventArgs e)
        {
            ObtnerComprasCanceladas();
        }

        private void ObtnerComprasCanceladas()
        {
            CompraController con = new CompraController();
            dataGridView1.DataSource = con.ObtnerComprasCanceladas();
            dataGridView1.Columns["FacturacionId"].Visible = false;
            dataGridView1.Columns["ClienteId"].Visible = false;

        }

        private void MostrarClientesQueDebenPagarEstaSemana()
        {
            ClienteController cli = new ClienteController();
            dataGridView1.DataSource = cli.ObtnerDeudores();
        }

        private void btnabonos_Click(object sender, EventArgs e)
        {
            VerAbonos vabonos = new VerAbonos();
            FacturacionId = new Guid(dataGridView1.CurrentRow.Cells["FacturacionId"].Value.ToString());

            AddOwnedForm(vabonos);
            vabonos.ShowDialog();
        }

        private void btnproductos_Click(object sender, EventArgs e)
        {
            VerProductos vProductos = new VerProductos();
            FacturacionId = new Guid(dataGridView1.CurrentRow.Cells["FacturacionId"].Value.ToString());

            AddOwnedForm(vProductos);
            vProductos.ShowDialog();
        }
    }
}
