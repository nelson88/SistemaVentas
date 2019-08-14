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
    public partial class Producto : Form
    {
        ProductoController controller = new ProductoController();
        VentaModel venta = new VentaModel();
        private string productoId = null;
        private bool Editar = false;
        public Producto()
        {
            InitializeComponent();
        }

        private void Producto_Load(object sender, EventArgs e)
        {
            ObtenerProductos();
            dataGridView1.Columns["ProductoId"].Visible = false;
        }

        private void ObtenerProductos()
        {
            ProductoController con = new ProductoController();
            dataGridView1.DataSource = con.ObtenerProductos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
        }

        private void LimpiarTextBox()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtMonto.Text = "";
            txtCantidad.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
        }

        //Esta es la funcion que se esta utilizando
        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                txtCodigo.Text = dataGridView1.CurrentRow.Cells["Codigo"].Value.ToString();
                txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
                txtMonto.Text = dataGridView1.CurrentRow.Cells["Monto"].Value.ToString();
                txtCantidad.Text = dataGridView1.CurrentRow.Cells["Cantidad"].Value.ToString();
                productoId = dataGridView1.CurrentRow.Cells["ProductoId"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila porfavor!!");
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                productoId = dataGridView1.CurrentRow.Cells["ProductoId"].Value.ToString();
                if (controller.EliminarProducto(new Guid(productoId)))
                {
                    MessageBox.Show("El registro fue eliminado");
                    ObtenerProductos();
                }
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            bool sucess = false;
            sucess = ProductosValidacion();

            if(sucess)
            {
                Producto producto = new Producto();

                venta.producto.Codigo = Convert.ToString(txtCodigo.Text);
                venta.producto.Nombre = txtNombre.Text;
                venta.producto.Descripcion = txtDescripcion.Text;
                venta.producto.Monto = Convert.ToDecimal(txtMonto.Text);
                venta.producto.Cantidad = Convert.ToInt32(txtCantidad.Text);

                if (Editar == false)
                {
                    if (controller.InsertarProductos(venta.producto))
                    {
                        LimpiarTextBox();
                        ObtenerProductos();
                    }
                }
                if (Editar == true)
                {
                    venta.producto.ProductoId = new Guid(productoId);
                    try
                    {
                        if (controller.ActualizarProductos(venta.producto))
                        {
                            LimpiarTextBox();
                            ObtenerProductos();
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

        public bool ProductosValidacion()
        {
            bool success = false;
            int cantidad;

            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;
            string monto = txtMonto.Text;
            string cantidadstr = txtCantidad.Text;

            
            bool cantidadvalido = Int32.TryParse(cantidadstr, out cantidad);

            if(nombre != "" && descripcion != "" && monto != "" && cantidadvalido)
            {
                success = true;
            }


            return success;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
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
