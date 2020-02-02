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
    public partial class Facturacion : Form
    {
        ProductoController controller = new ProductoController();
        VentaModel venta = new VentaModel();
        public Guid FacturacionId;
        public string SaldoPendiente = "";
        public Facturacion()
        {
            InitializeComponent();
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            //ListCategoria();
            //FiltroListCategoria();
            //ObtenerProductos();
            //dataGridView1.Columns["ProductoId"].Visible = false;
            //dataGridView1.Columns["ProductoCategoriaId"].Visible = false;
        }

        //private void ObtenerProductos()
        //{
        //    ProductoController con = new ProductoController();
        //    dataGridView1.DataSource = con.ObtenerProductos();
        //}

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
        }

        private void LimpiarTextBox()
        {
            ListCategoria();
            //txtNombre.Text = "";
            //txtDescripcion.Text = "";
            //txtMonto.Text = "";
            //txtCantidad.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
        }

        //Esta es la funcion que se esta utilizando
        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            //if (dataGridView1.SelectedRows.Count > 0)
            //{
            //    Editar = true;
            //    int categoriaid = 0;

            //    //txtCodigo.Text = dataGridView1.CurrentRow.Cells["Codigo"].Value.ToString();
            //    categoriaid = (int)dataGridView1.CurrentRow.Cells["ProductoCategoriaId"].Value;

            //    txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
            //    txtDescripcion.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
            //    txtMonto.Text = dataGridView1.CurrentRow.Cells["Monto"].Value.ToString();
            //    txtCantidad.Text = dataGridView1.CurrentRow.Cells["Cantidad"].Value.ToString();
            //    productoId = dataGridView1.CurrentRow.Cells["ProductoId"].Value.ToString();

            //    foreach (DataRowView Row in cmbCategoria .Items)
            //    {
            //        if (Convert.ToInt32(Row.Row.ItemArray[0]) == categoriaid)
            //            cmbCategoria.SelectedItem = Row;
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Seleccione una fila porfavor!!");
            //}
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            //if (dataGridView1.SelectedRows.Count > 0)
            //{
            //    productoId = dataGridView1.CurrentRow.Cells["ProductoId"].Value.ToString();
            //    if (controller.EliminarProducto(new Guid(productoId)))
            //    {
            //        MessageBox.Show("El registro fue eliminado");
            //        ObtenerProductos();
            //    }
            //}
        }

        private void ListCategoria()
        {
        //    ProductoController con = new ProductoController();
        //    cmbCategoria.DataSource = con.ObtnerCategoria();
        //    cmbCategoria.DisplayMember = "Categoria";
        //    cmbCategoria.ValueMember = "ProductoCategoriaId";
        //}


        //private void btnGuardar_Click_1(object sender, EventArgs e)
        //{
        //    bool sucess = false;
        //    sucess = ProductosValidacion();

        //    if(sucess)
        //    {
        //        Producto producto = new Producto();

        //        DataRowView drcategoria = cmbCategoria.SelectedItem as DataRowView;
        //        int categoriaid = (int)drcategoria.Row.ItemArray[0];
                
        //        //venta.producto.Codigo = Convert.ToString(txtCodigo.Text);
        //        venta.producto.ProductoCategoriaId = categoriaid;
        //        venta.producto.Nombre = txtNombre.Text;
        //        venta.producto.Descripcion = txtDescripcion.Text;
        //        venta.producto.Monto = Convert.ToDecimal(txtMonto.Text);
        //        venta.producto.Cantidad = Convert.ToInt32(txtCantidad.Text);

        //        if (Editar == false)
        //        {
        //            if (controller.InsertarProductos(venta.producto))
        //            {
        //                LimpiarTextBox();
        //                ObtenerProductos();
        //            }
        //        }
        //        if (Editar == true)
        //        {
        //            venta.producto.ProductoId = new Guid(productoId);
        //            try
        //            {
        //                if (controller.ActualizarProductos(venta.producto))
        //                {
        //                    LimpiarTextBox();
        //                    ObtenerProductos();
        //                    Editar = false;
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show("No se pudo insertar los datos por: " + ex);
        //            }
        //        }
        //    }
        }

        private void Facturacion_Load_1(object sender, EventArgs e)
        {
            ObtenerCompras();
        }

        private void ObtenerCompras()
        {
            CompraController con = new CompraController();
            dataGridView1.DataSource = con.ObtenerCompra();
            dataGridView1.Columns["FacturacionId"].Visible = false;
            dataGridView1.Columns["ClienteId"].Visible = false;
            dataGridView1.Columns["SaldoPendiente"].Visible = false;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btinfofactura_Click(object sender, EventArgs e)
        {
            ReciboController reciboc = new ReciboController();

            FacturacionId = new Guid(dataGridView1.CurrentRow.Cells["FacturacionId"].Value.ToString());
            DateTime datefecha = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["Fecha"].Value.ToString());
            lbfechafactura.Text = datefecha.ToString("MM/dd/yyyy");
            lbfechapago.Text = "";
            lbsaldopendiente.Text = dataGridView1.CurrentRow.Cells["SaldoPendiente"].Value.ToString();
            SaldoPendiente = dataGridView1.CurrentRow.Cells["SaldoPendiente"].Value.ToString();

            dataGridView2.DataSource = reciboc.ListarAbonos(FacturacionId);
            dataGridView2.Columns["AbonoId"].Visible = false;
            dataGridView2.Columns["FacturacionId"].Visible = false;
            dataGridView3.DataSource = reciboc.ListarProductoFacturados(FacturacionId);
            dataGridView3.Columns["ArticulosFacturaId"].Visible = false;
            dataGridView3.Columns["FacturacionId"].Visible = false;
            dataGridView3.Columns["ProductoId"].Visible = false;
        }

        private void btnrealizarabono_Click(object sender, EventArgs e)
        {
            CrearAbono cp = new CrearAbono();
            AddOwnedForm(cp);
            cp.Show();
        }

        private void btncancelarfactura_Click(object sender, EventArgs e)
        {
            CancelarFactura cp = new CancelarFactura();
            AddOwnedForm(cp);
            cp.Show();
        }
        //public bool ProductosValidacion()
        //{
        //    bool success = false;
        //    int cantidad;

        //    string nombre = txtNombre.Text;
        //    //string descripcion = txtDescripcion.Text;
        //    string monto = txtMonto.Text;
        //    string cantidadstr = txtCantidad.Text;


        //    bool cantidadvalido = Int32.TryParse(cantidadstr, out cantidad);

        //    if(nombre != "" /*&& descripcion != ""*/ && monto != "" && cantidadvalido)
        //    {
        //        success = true;
        //    }


        //    return success;
        //}

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}

        //private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    // Verify that the pressed key isn't CTRL or any non-numeric digit
        //    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
        //    {
        //        e.Handled = true;
        //    }

        //    // If you want, you can allow decimal (float) numbers
        //    if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
        //    {
        //        e.Handled = true;
        //    }
        //}

        //private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    // Verify that the pressed key isn't CTRL or any non-numeric digit
        //    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
        //    {
        //        e.Handled = true;
        //    }

        //    // If you want, you can allow decimal (float) numbers
        //    if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
        //    {
        //        e.Handled = true;
        //    }
        //}

        //private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    //ComboBox comboBox = (ComboBox)sender;
        //    //DataRowView dr = comboBox.SelectedItem as DataRowView;

        //    //int i = (int)dr.Row.ItemArray[0];
        //    //if (drdiasemana != null)
        //    //{
        //    //    diaid = (int)drdiasemana.Row.ItemArray[0];
        //    //}

        //    //foreach (DataRowView Row in cbdiasemana.Items)
        //    //{
        //    //    if (Convert.ToInt32(Row.Row.ItemArray[0]) == diaid)
        //    //        cbdiasemana.SelectedItem = Row;
        //    //}
        //}

        //private void cbfilterCategoria_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    ComboBox comboBox = (ComboBox)sender;
        //    DataRowView dr = comboBox.SelectedItem as DataRowView;

        //    int i = (int)dr.Row.ItemArray[0];

        //    if (i == 2)
        //    {
        //        ObtnerProductosByCategoria(i, "");
        //        txtFiltroNombre.Enabled = true;
        //    }
        //    else if (i == 3)
        //    {
        //        ObtnerProductosByCategoria(i, "");
        //        txtFiltroNombre.Enabled = true;
        //    }
        //    else if (i == 4)
        //    {
        //        ObtnerProductosByCategoria(i, "");
        //        txtFiltroNombre.Enabled = true;
        //    }
        //    else {
        //        ObtnerProductosByCategoria(i, "");
        //        txtFiltroNombre.Enabled = false;
        //    }

        //}

        //private void ObtnerProductosByCategoria(int ProductoCategoriaId, string nombre)
        //{
        //    ProductoController con = new ProductoController();
        //    dataGridView1.DataSource = con.ObtnerProductosByCategoria(ProductoCategoriaId, nombre);
        //}

        //private void FiltroListCategoria()
        //{
        //    ProductoController con = new ProductoController();
        //    cbfilterCategoria.DataSource = con.ObtnerCategoria();
        //    cbfilterCategoria.DisplayMember = "Categoria";
        //    cbfilterCategoria.ValueMember = "ProductoCategoriaId";
        //}
    }
}
