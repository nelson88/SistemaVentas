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
using CapaEntidad;

namespace SistemaVentas
{
    public partial class Recibo : Form
    {
        ReciboController controller = new ReciboController();
        public string ClientProducId = null;
        public string montoProducto = null;
        public string clienteId = null;
        private string reciboId = null;
        private bool Editar = false;
        public Recibo()
        {
            InitializeComponent();
        }

        private void Recibo_Load(object sender, EventArgs e)
        {
            ListRecibos();
            dataGridView1.Columns["ReciboId"].Visible = false;
            dataGridView1.Columns["ClienteId"].Visible = false;
            dataGridView1.Columns["ClientProducId"].Visible = false;
        }

        private void ListRecibos()
        {
            ReciboController con = new ReciboController();
            dataGridView1.DataSource = con.ObtenerRecibos();
        }

        private void LimpiarTextBox()
        {
            reciboId = null;
            ClientProducId = null;
            txtCodigo.Text = "";
            txtcliente.Text = "";
            txtcompra.Text = "";
            dpfechaabono.Value = DateTime.Now;
            clienteId = null;
            txtconcepto.Text = "";
            txtmontoabono.Text = "";
            txtnuevosaldo.Text = "";

        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            clienteId = null;
            
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                txtCodigo.Text = dataGridView1.CurrentRow.Cells["Codigo"].Value.ToString();
                clienteId = dataGridView1.CurrentRow.Cells["ClienteId"].Value.ToString();
                txtcliente.Text = dataGridView1.CurrentRow.Cells["PrimerNombre"].Value.ToString();
                ClientProducId = dataGridView1.CurrentRow.Cells["ClientProducId"].Value.ToString();
                txtcompra.Text = dataGridView1.CurrentRow.Cells["Compra"].Value.ToString();
                txtconcepto.Text = dataGridView1.CurrentRow.Cells["Concepto"].Value.ToString();
                dpfechaabono.Value = (DateTime)dataGridView1.CurrentRow.Cells["FechaAbono"].Value;
                txtmontoabono.Text = dataGridView1.CurrentRow.Cells["MontoAbono"].Value.ToString();
                txtnuevosaldo.Text = dataGridView1.CurrentRow.Cells["NuevoSaldo"].Value.ToString();
                reciboId = dataGridView1.CurrentRow.Cells["ReciboId"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila porfavor!!");
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                reciboId = dataGridView1.CurrentRow.Cells["ReciboId"].Value.ToString();
                if (controller.EliminarRecibo(new Guid(reciboId)))
                {
                    MessageBox.Show("El registro fue eliminado");
                    ListRecibos();
                }
            }
        }

        private void btncliente_Click(object sender, EventArgs e)
        {
            BuscarClientes frm = new BuscarClientes();
            AddOwnedForm(frm);
            frm.Show();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            bool sucess = false;
            sucess = ReciboValidacion();

            if (sucess)
            {
                Recibo recibo = new Recibo();
                VentaModel venta = new VentaModel();

                venta.recibo.Codigo = Convert.ToString(txtCodigo.Text);
                venta.recibo.ClienteId = new Guid(clienteId);
                venta.recibo.FechaAbono = (DateTime)dpfechaabono.Value;
                venta.recibo.Concepto = Convert.ToString(txtconcepto.Text);
                venta.recibo.MontoAbono = Convert.ToDecimal(txtmontoabono.Text);
                venta.recibo.NuevoSaldo = Convert.ToDecimal(txtnuevosaldo.Text);
                venta.recibo.ClientProducId = new Guid(ClientProducId);

                if (Editar == false)
                {
                    if (controller.InsertarRecibo(venta.recibo))
                    {
                        LimpiarTextBox();
                        ListRecibos();
                    }
                }
                if (Editar == true)
                {
                    venta.recibo.ReciboId = new Guid(reciboId);
                    try
                    {
                        if (controller.ActualizarRecibo(venta.recibo))
                        {
                            LimpiarTextBox();
                            ListRecibos();
                            Editar = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo insertar los datos por: " + ex);
                    }
                }
            }
        }

        public bool ReciboValidacion()
        {
            bool success = false;

            string codigo = txtCodigo.Text;
            string concepto = txtconcepto.Text;
            string montoAbono = txtmontoabono.Text;   

            if (clienteId != null && ClientProducId != null && codigo != "" && concepto != "" && montoAbono != "")
            {
                decimal nuevoSaldo = Convert.ToDecimal(txtnuevosaldo.Text);
                if (nuevoSaldo < 0)
                {
                    MessageBox.Show("El monto abonado es mayor al valor que se debe.");
                    return success;
                }
                success = true;
            }


            return success;
        }

        private void btcompra_Click(object sender, EventArgs e)
        {
            BuscarCompras frm = new BuscarCompras();
            AddOwnedForm(frm);
            frm.Show();
        }

        private void txtmontoabono_TextChanged(object sender, EventArgs e)
        {
            if (txtmontoabono.Text != "" && txtcompra.Text != "")
            {
                txtnuevosaldo.Text = (Convert.ToDecimal(montoProducto) - Convert.ToDecimal(txtmontoabono.Text)).ToString();
            }
        }

        private void txtmontoabono_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
