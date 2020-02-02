using CapaEntidad;
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
    public partial class CancelarFactura : Form
    {
        public CancelarFactura()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            AbonoModel abonoModel = new AbonoModel();
            Facturacion facturacion = Owner as Facturacion;
            ReciboController reciboc = new ReciboController();

            abonoModel.FacturacionId = facturacion.FacturacionId;
            abonoModel.Codigo = txtcodigo.Text;
            abonoModel.Fecha = (DateTime)dbfecha.Value;
            abonoModel.Observacion = txtobservacion.Text;

            reciboc.CancelarAbono(abonoModel);

            facturacion.lbsaldopendiente.Text = "0.00";

            reciboc.ListarAbonos(facturacion.FacturacionId);

            this.Close();
        }
    }
}
