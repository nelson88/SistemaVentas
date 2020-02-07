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
    public partial class CrearAbono : Form
    {
        public CrearAbono()
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
            decimal saldoPendiente = 0;

            abonoModel.FacturacionId = facturacion.FacturacionId;
            abonoModel.Codigo = txtcodigo.Text;
            abonoModel.Fecha = (DateTime)dbfecha.Value;
            abonoModel.Abono = Convert.ToDecimal(txtabono.Text);
            abonoModel.Observacion = txtobservacion.Text;

            reciboc.InsertarAbono(abonoModel);

            saldoPendiente = Convert.ToDecimal(facturacion.SaldoPendiente) - abonoModel.Abono;

            facturacion.lbsaldopendiente.Text = Convert.ToString(saldoPendiente);

            reciboc.ListarAbonos(facturacion.FacturacionId);

            this.Close();
        }

        private void CrearAbono_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Facturacion facturacion = Owner as Facturacion;
            //ReciboController reciboc = new ReciboController();
            
            //reciboc.ListarAbonos(facturacion.FacturacionId);
        }

        private void CrearAbono_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Facturacion facturacion = Owner as Facturacion;
            //ReciboController reciboc = new ReciboController();
            //reciboc.ListarAbonos(facturacion.FacturacionId);
        }

        private void CrearAbono_Load(object sender, EventArgs e)
        {
            //Facturacion facturacion = Owner as Facturacion;
            //Application.Run(Facturacion);
        }
    }
}
