using CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas
{
    public partial class CompraProducto : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        public CompraProducto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            Compras compras = Owner as Compras;
            ArticuloFactura artifac = new ArticuloFactura();
            string ProductoId = compras.dataGridView1.CurrentRow.Cells["ProductoId"].Value.ToString();
            string ProductoCategoriaId = compras.dataGridView1.CurrentRow.Cells["ProductoCategoriaId"].Value.ToString();
            string Codigo = compras.dataGridView1.CurrentRow.Cells["Codigo"].Value.ToString();
            string Categoria = compras.dataGridView1.CurrentRow.Cells["Categoria"].Value.ToString();
            string Articulo = compras.dataGridView1.CurrentRow.Cells["Articulo"].Value.ToString();
            string Descripcion = compras.dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
            decimal PrecioProducto = Convert.ToDecimal(compras.dataGridView1.CurrentRow.Cells["Precio"].Value.ToString());
            //
            decimal Precio = Convert.ToDecimal(txtprecio.Text);
            string Cantidad = txtcantidad.Text;
            decimal descuento = PrecioProducto - Precio;
            artifac.ProductoId = new Guid(ProductoId);
            artifac.Cantidad = Convert.ToInt32(Cantidad);
            artifac.Precio = Precio;
            artifac.Descuento = descuento;

            compras.totalcompra = compras.totalcompra + Precio;
            compras.totaldescuento = compras.totaldescuento + descuento;
            compras.af.Add(artifac);

            compras.lbtotalcompra.Text = Convert.ToString(compras.totalcompra);
            compras.lbdescuento.Text = Convert.ToString(compras.totaldescuento);

            int rowIndex = compras.dataGridView1.CurrentCell.RowIndex;
            compras.dataGridView1.Rows.RemoveAt(rowIndex);

            compras.dataGridView2.Columns.Add("productoId", "ProductoId");
            compras.dataGridView2.Columns.Add("productoCategoriaId", "ProductoCategoriaId");
            compras.dataGridView2.Columns.Add("codigo", "Codigo");
            //
            compras.dataGridView2.Columns.Add("precio", "Precio");
            compras.dataGridView2.Columns.Add("cantidad", "Cantidad");
            compras.dataGridView2.Columns.Add("descuento", "Descuento");
            //
            compras.dataGridView2.Columns.Add("categoria", "Categoria");
            compras.dataGridView2.Columns.Add("articulo", "Articulo");
            compras.dataGridView2.Columns.Add("descripcion", "Descripcion");


            compras.dataGridView2.Rows.Add(ProductoId, ProductoCategoriaId, Codigo, Precio, Cantidad, Convert.ToString(descuento), Categoria, Articulo, Descripcion);

            compras.dataGridView2.Columns["ProductoId"].Visible = false;
            compras.dataGridView2.Columns["ProductoCategoriaId"].Visible = false;

            this.Close();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CompraProducto_Load(object sender, EventArgs e)
        {
            Compras compras = Owner as Compras;

            txtprecio.Text = compras.dataGridView1.CurrentRow.Cells["Precio"].Value.ToString();
        }
    }
}
