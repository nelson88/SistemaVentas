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
        public ContenidoInicial()
        {
            InitializeComponent();

        }

        private void ContenidoInicial_Load(object sender, EventArgs e)
        {
            MostrarClientesQueDebenPagarEstaSemana();
            dataGridView1.Columns["ClienteId"].Visible = false;
        }

        private void MostrarClientesQueDebenPagarEstaSemana()
        {
            ClienteController cli = new ClienteController();
            dataGridView1.DataSource = cli.ObtnerDeudores();
        }
    }
}
