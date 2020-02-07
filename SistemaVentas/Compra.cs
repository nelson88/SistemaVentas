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
    public partial class Compras : Form
    {
        public string vendedorId;
        public string clienteId;
        public decimal totalcompra = 0;
        public decimal totaldescuento = 0;
        public List<ArticuloFactura> af = new List<ArticuloFactura>();
        public Compras()
        {
            InitializeComponent();
        }

        private void Compra_Load(object sender, EventArgs e)
        {
            ObtenerProductos();
            ListFrecuencia();
            dataGridView1.Columns["ProductoId"].Visible = false;
            dataGridView1.Columns["ProductoCategoriaId"].Visible = false;
            dataGridView1.Columns["ProveedorId"].Visible = false;
        }

        private void ObtenerProductos()
        {
            ProductoController con = new ProductoController();
            dataGridView1.DataSource = con.ObtenerProductos();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            CompraProducto cp = new CompraProducto();
            AddOwnedForm(cp);
            cp.ShowDialog();
            //string ProductoId = dataGridView1.CurrentRow.Cells["ProductoId"].Value.ToString();
            //string ProductoCategoriaId = dataGridView1.CurrentRow.Cells["ProductoCategoriaId"].Value.ToString();
            //string Codigo = dataGridView1.CurrentRow.Cells["Codigo"].Value.ToString();
            //string Categoria = dataGridView1.CurrentRow.Cells["Categoria"].Value.ToString();
            //string Articulo = dataGridView1.CurrentRow.Cells["Articulo"].Value.ToString();
            //string Descripcion = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();


            //int rowIndex = dataGridView1.CurrentCell.RowIndex;
            //dataGridView1.Rows.RemoveAt(rowIndex);

            //dataGridView2.Columns.Add("productoId", "ProductoId");
            //dataGridView2.Columns.Add("productoCategoriaId", "ProductoCategoriaId");
            //dataGridView2.Columns.Add("codigo", "Codigo");
            //dataGridView2.Columns.Add("categoria", "Categoria");
            //dataGridView2.Columns.Add("articulo", "Articulo");
            //dataGridView2.Columns.Add("descripcion", "Descripcion");

            //dataGridView2.Rows.Add(ProductoId, ProductoCategoriaId, Codigo, Categoria, Articulo, Descripcion);

            //dataGridView2.Columns["ProductoId"].Visible = false;
            //dataGridView2.Columns["ProductoCategoriaId"].Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            BuscarClientes frm = new BuscarClientes();
            AddOwnedForm(frm);
            frm.ShowDialog();
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            BuscarClientes frm = new BuscarClientes();
            AddOwnedForm(frm);
            frm.ShowDialog();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            CompraController comprac = new CompraController();
            FacturacionModel facturacion = new FacturacionModel();
            DataRowView drfrecuenca = cbmodopago.SelectedItem as DataRowView;

            facturacion.Codigo = txtcodigo.Text;
            facturacion.TipoPago = rbcredito.Checked == true ? 1 : 2;
            facturacion.Fecha = (DateTime)dpfecha.Value;
            facturacion.ClienteId = new Guid(clienteId);
            facturacion.VendedorId = new Guid(vendedorId);
            facturacion.FrecuenciaId = (int)drfrecuenca.Row.ItemArray[0];
            if(txtabonoinicial.Text != "") { 
                facturacion.AbonoInicial = Convert.ToDecimal(txtabonoinicial.Text);
            }
            facturacion.Observaciones = txtobservaciones.Text;
            facturacion.TotalPago = totalcompra;
            facturacion.Descuento = totaldescuento;
            facturacion.FacturacionId = Guid.NewGuid();

            comprac.InsertarCompra(facturacion, af);
            LimpiarCampos();
            ObtenerProductos();
            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        

        private void ListFrecuencia()
        {
            CompraController con = new CompraController();
            cbmodopago.DataSource = con.ObtnerFrecuencia();
            cbmodopago.DisplayMember = "Nombre";
            cbmodopago.ValueMember = "FrecuenciaId";
        }

        private void txtcliente_Click(object sender, EventArgs e)
        {
            BuscarClientes frm = new BuscarClientes();
            AddOwnedForm(frm);
            frm.ShowDialog(); 
        }

        private void txtvendedor_Click(object sender, EventArgs e)
        {
            BuscarVendedor frm = new BuscarVendedor();
            AddOwnedForm(frm);
            frm.ShowDialog();
        }

        private void txtvendedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        public void LimpiarCampos()
        {
            totalcompra = 0;
            totaldescuento = 0;
            af = new List<ArticuloFactura>();

            dpfecha.Value = DateTime.Now;
            txtcodigo.Text = "";
            txtcliente.Text = "";
            rbcontado.Checked = false;
            rbcredito.Checked = false;
            txtvendedor.Text = "";
            txtabonoinicial.Text = "";
            txtobservaciones.Text = "";

            ListFrecuencia();

            lbdescuento.Text = "0.00";
            lbtotalcompra.Text = "0.00";
        }

        private void rbcontado_Click(object sender, EventArgs e)
        {
            if (rbcredito.Checked)
            {
                lbabonoinicial.Visible = true;
                txtabonoinicial.Visible = true;
            }
            else
            {
                lbabonoinicial.Visible = false;
                txtabonoinicial.Visible = false;
                txtabonoinicial.Text = "";
            }
        }

        private void rbcredito_Click(object sender, EventArgs e)
        {
            if (rbcredito.Checked)
            {
                lbabonoinicial.Visible = true;
                txtabonoinicial.Visible = true;
            }
            else
            {
                lbabonoinicial.Visible = false;
                txtabonoinicial.Visible = false;
                txtabonoinicial.Text = "";
            }
        }
    }
}
