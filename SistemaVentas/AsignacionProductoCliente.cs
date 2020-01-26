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
    public partial class AsignacionProductoCliente : Form
    {
        CompraController controller = new CompraController();
        public string productoId = null;
        public string clienteId = null;
        public string compraId = null;
        private bool Editar = false;

        public AsignacionProductoCliente()
        {
            InitializeComponent();
        }

        private void AsignacionProductoCliente_Load(object sender, EventArgs e)
        {
            ListCompras();
            ListFrecuencia();
            ListDiasSemana();
            dataGridView1.Columns["ClientProducId"].Visible = false;
            dataGridView1.Columns["ClienteId"].Visible = false;
            dataGridView1.Columns["ProductoId"].Visible = false;
            dataGridView1.Columns["FrecuenciaId"].Visible = false;
            dataGridView1.Columns["DiaSemana"].Visible = false;
        }

        private void bteditar_Click(object sender, EventArgs e)
        {
            clienteId = null;
            productoId = null;
            int frecuenciaid = 0;
            int diaid = 0;

            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                
                compraId = dataGridView1.CurrentRow.Cells["ClientProducId"].Value.ToString();
                clienteId = dataGridView1.CurrentRow.Cells["ClienteId"].Value.ToString();
                txtcliente.Text = dataGridView1.CurrentRow.Cells["PrimerNombre"].Value.ToString();
                productoId = dataGridView1.CurrentRow.Cells["ProductoId"].Value.ToString();
                txtproducto.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtmonto.Text = dataGridView1.CurrentRow.Cells["Monto"].Value.ToString();
                txtnuevosaldo.Text = dataGridView1.CurrentRow.Cells["Nuevo_Saldo"].Value.ToString();
                txtprima.Text = dataGridView1.CurrentRow.Cells["Nuevo_Saldo"].Value.ToString();
                dpfecha_adquisicion.Value = (DateTime)dataGridView1.CurrentRow.Cells["FechaAdquisicion"].Value;
                txtmesespagar.Text = dataGridView1.CurrentRow.Cells["MesesPagar"].Value.ToString();
                frecuenciaid = (int)dataGridView1.CurrentRow.Cells["FrecuenciaId"].Value;
                if (Convert.ToString(dataGridView1.CurrentRow.Cells["DiaSemana"].Value) != "")
                    diaid = (int)dataGridView1.CurrentRow.Cells["DiaSemana"].Value;
                txtprimeraquincena.Text = dataGridView1.CurrentRow.Cells["DiaPrimeraQuincena"].Value.ToString();
                txtsegundaquincena.Text = dataGridView1.CurrentRow.Cells["DiaSegundaQuincena"].Value.ToString();
                txtfechames.Text = dataGridView1.CurrentRow.Cells["DiaMes"].Value.ToString();

                foreach (DataRowView Row in cbfrecuenciapago.Items)
                {
                    if (Convert.ToInt32(Row.Row.ItemArray[0]) == frecuenciaid)
                        cbfrecuenciapago.SelectedItem = Row;
                }
                if(diaid == 0)
                {
                    foreach (DataRowView Row in cbdiasemana.Items)
                    {
                        if (Convert.ToInt32(Row.Row.ItemArray[0]) == diaid)
                            cbdiasemana.SelectedItem = Row;
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila porfavor!!");
            }
        }

        private void bteliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                compraId = dataGridView1.CurrentRow.Cells["ClientProducId"].Value.ToString();
                if (controller.EliminarCompra(new Guid(compraId)))
                {
                    MessageBox.Show("El registro fue eliminado");
                    ListCompras();
                }
            }
        }

        private void btguardar_Click(object sender, EventArgs e)
        {
            bool sucess = false;
            sucess = CompraValidacion();

            if (sucess)
            {
                AsignacionProductoCliente recibo = new AsignacionProductoCliente();
                VentaModel venta = new VentaModel();
                DataRowView drfrecuenca = cbfrecuenciapago.SelectedItem as DataRowView;
                DataRowView drdiasemana = cbdiasemana.SelectedItem as DataRowView;
                int frecuenciaid = (int)drfrecuenca.Row.ItemArray[0];
                int diaid = (int)drdiasemana.Row.ItemArray[0];

                venta.clientProduc.ClienteId = new Guid(clienteId);
                venta.clientProduc.ProductoId = new Guid(productoId);
                venta.clientProduc.Monto = Convert.ToDecimal(txtmonto.Text);
                venta.clientProduc.Nuevo_Saldo = Convert.ToDecimal(txtnuevosaldo.Text);
                venta.clientProduc.FechaAdquisicion = (DateTime)dpfecha_adquisicion.Value;
                venta.clientProduc.MesesPagar = Convert.ToInt32(txtmesespagar.Text);
                venta.clientProduc.MontoPrima = Convert.ToDecimal(txtprima.Text);
                venta.clientProduc.FrecuenciaId = frecuenciaid;
                if (frecuenciaid == 1)
                {
                    venta.clientProduc.DiaSemana = diaid;
                }
                else
                {
                    venta.clientProduc.DiaSemana = 0;
                }

                if (txtprimeraquincena.Text != "")
                {
                    venta.clientProduc.DiaPrimeraQuincena = Convert.ToInt32(txtprimeraquincena.Text);
                }
                else
                {
                    venta.clientProduc.DiaPrimeraQuincena = 0;
                }

                if (txtsegundaquincena.Text != "")
                {
                    venta.clientProduc.DiaSegundaQuincena = Convert.ToInt32(txtsegundaquincena.Text);
                }
                else
                {
                    venta.clientProduc.DiaSegundaQuincena = 0;
                }

                if (txtfechames.Text != "")
                {
                    venta.clientProduc.DiaMes = Convert.ToInt32(txtfechames.Text);
                }
                else
                {
                    venta.clientProduc.DiaMes = 0;
                }

                if (Editar == false)
                {
                    if (controller.InsertarCompra(venta.clientProduc))
                    {
                        LimpiarTextBox();
                        ListCompras();
                    }
                }
                if (Editar == true)
                {
                    venta.clientProduc.ClientProducId = new Guid(compraId);
                    try
                    {
                        if (controller.ActualizarCompra(venta.clientProduc))
                        {
                            LimpiarTextBox();
                            ListCompras();
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

        public bool CompraValidacion()
        {
            bool success = false;
            DataRowView drfrecuenca = cbfrecuenciapago.SelectedItem as DataRowView;
            int frecuenciaid = (int)drfrecuenca.Row.ItemArray[0];
            string mesespagar = txtmesespagar.Text;
            string montoprima = txtprima.Text;

            if (clienteId != null && productoId != null && montoprima != "" && mesespagar != "")
            {
                decimal nuevoSaldo = Convert.ToDecimal(txtnuevosaldo.Text);

                if (nuevoSaldo < 0)
                {
                    MessageBox.Show("No puede dar una prima mayor al monto del producto.");
                    return success;
                }

                if(frecuenciaid == 0){
                    MessageBox.Show("Seleccione una frecuencia de pago.");
                    return success;
                }
                else if (frecuenciaid == 2){
                    string primeraquincenastr = txtprimeraquincena.Text;
                    string segundaquincenastr = txtsegundaquincena.Text;
                    int primeraquincena = 0;
                    int segundaquincena = 0;
                    bool primeraquincenavalido = Int32.TryParse(primeraquincenastr, out primeraquincena);
                    bool segundaquincenavalido = Int32.TryParse(segundaquincenastr, out segundaquincena);

                    if (primeraquincenavalido == false && segundaquincenavalido == false)
                    {
                        txtprimeraquincena.Focus();
                        MessageBox.Show("Ingrese un valor a los campor primera quicena o segunda quincena.");
                        return success;
                    }else
                    {
                        if(!((primeraquincena >= 1 && primeraquincena <= 15) && (segundaquincena >= 16 && segundaquincena <= 30)))
                        {
                            txtprimeraquincena.Focus();
                            MessageBox.Show("Ingrese un valor primera quincena entre 1 al 15 y segunda quincena entre 16 al 30.");
                            return success;
                        }
                    }

                    

                }else if (frecuenciaid == 3){
                    string fechamesstr = txtfechames.Text;
                    int fechames = 0;
                    bool fechamesvalido = Int32.TryParse(fechamesstr, out fechames);
                    if (fechamesvalido == false)
                    {
                        txtfechames.Focus();
                        MessageBox.Show("Ingrese un valor entero entre el 1 al 30.");
                        return success;
                    }else{
                        if (!(fechames >= 1 && fechames <= 30))
                        {
                            txtfechames.Focus();
                            MessageBox.Show("Ingrese un valor entre 1 al 30 en la fecha del mes.");
                            return success;
                        }
                    }
                }

                success = true;
            }


            return success;
        }

        private void ListCompras()
        {
            CompraController con = new CompraController();
            dataGridView1.DataSource = con.ObtenerCompra();
        }

        private void ListFrecuencia()
        {
            CompraController con = new CompraController();
            cbfrecuenciapago.DataSource = con.ObtnerFrecuencia();
            cbfrecuenciapago.DisplayMember = "Nombre";
            cbfrecuenciapago.ValueMember = "FrecuenciaId";
        }

        private void ListDiasSemana()
        {
            CompraController con = new CompraController();
            cbdiasemana.DataSource = con.ObtnerDiasSemana();
            cbdiasemana.DisplayMember = "Nombre";
            cbdiasemana.ValueMember = "DiaId";
        }

        private void LimpiarTextBox()
        {
            compraId = null;
            clienteId = null;
            productoId = null;            
            txtcliente.Text = "";
            txtproducto.Text = "";
            txtmonto.Text = "";
            txtnuevosaldo.Text = "";
            dpfecha_adquisicion.Value = DateTime.Now;
            txtmesespagar.Text = "";
            txtprima.Text = "";
            txtprimeraquincena.Text = "";
            txtsegundaquincena.Text = "";
            txtfechames.Text = "";
            //
            ListFrecuencia();
            ListDiasSemana();
            //
            lbdias.Visible = false;
            cbdiasemana.Visible = false;
            lbprimeraquincena.Visible = false;
            txtprimeraquincena.Visible = false;
            lbsegundaquincena.Visible = false;
            txtsegundaquincena.Visible = false;
            lbfechames.Visible = false;
            txtfechames.Visible = false;

        }

        private void btnagregarcliente_Click(object sender, EventArgs e)
        {
            BuscarClientes frm = new BuscarClientes();
            frm.isRecibo = false;
            AddOwnedForm(frm);
            frm.Show();
        }

        private void btnagregarproducto_Click(object sender, EventArgs e)
        {
            BuscarProducto frm = new BuscarProducto();
            AddOwnedForm(frm);
            frm.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbfrecuenciapago_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            DataRowView dr = comboBox.SelectedItem as DataRowView;
            DataRowView drdiasemana = cbdiasemana.SelectedItem as DataRowView;
            int diaid = 0;

            int i = (int)dr.Row.ItemArray[0];
            if(drdiasemana != null)
            {
               diaid  = (int)drdiasemana.Row.ItemArray[0];
            }

            foreach (DataRowView Row in cbdiasemana.Items)
            {
                if (Convert.ToInt32(Row.Row.ItemArray[0]) == diaid)
                    cbdiasemana.SelectedItem = Row;
            }
            txtprimeraquincena.Text = "";
            txtsegundaquincena.Text = "";
            txtfechames.Text = "";

            if ( i == 1)
            {
                lbdias.Visible = true;
                cbdiasemana.Visible = true;
                lbprimeraquincena.Visible = false;
                txtprimeraquincena.Visible = false;
                lbsegundaquincena.Visible = false;
                txtsegundaquincena.Visible = false;
                lbfechames.Visible = false;
                txtfechames.Visible = false;
            }
            else if (i == 2)
            {
                lbdias.Visible = false;
                cbdiasemana.Visible = false;
                lbprimeraquincena.Visible = true;
                txtprimeraquincena.Visible = true;
                lbsegundaquincena.Visible = true;
                txtsegundaquincena.Visible = true;
                lbfechames.Visible = false;
                txtfechames.Visible = false;
            }
            else if(i == 3)
            {
                lbdias.Visible = false;
                cbdiasemana.Visible = false;
                lbprimeraquincena.Visible = false;
                txtprimeraquincena.Visible = false;
                lbsegundaquincena.Visible = false;
                txtsegundaquincena.Visible = false;
                lbfechames.Visible = true;
                txtfechames.Visible = true;
            }
            else
            {
                lbdias.Visible = false;
                lbprimeraquincena.Visible = false;
                lbsegundaquincena.Visible = false;
                lbfechames.Visible = false;

                cbdiasemana.Visible = false;
                txtprimeraquincena.Visible = false;
                txtsegundaquincena.Visible = false;
                txtfechames.Visible = false;
            }
        }

        private void txtprima_TextChanged(object sender, EventArgs e)
        {
            if(txtmonto.Text != "" && txtprima.Text != "")
            {
                txtnuevosaldo.Text = (Convert.ToDecimal(txtmonto.Text) - Convert.ToDecimal(txtprima.Text)).ToString();
            }
        }

        private void txtprima_KeyPress(object sender, KeyPressEventArgs e)
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
         
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                compraId = dataGridView1.CurrentRow.Cells["ClientProducId"].Value.ToString();
                if (controller.GenerarPlandePago(new Guid(compraId)))
                {
                    MessageBox.Show("El registro fue eliminado");
                    ListCompras();
                }
            }
        }
    }
}
