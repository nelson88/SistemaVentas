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
        public Compras()
        {
            InitializeComponent();
        }

        private void Compra_Load(object sender, EventArgs e)
        {
            ObtenerProductos();
            dataGridView1.Columns["ProductoId"].Visible = false;
            dataGridView1.Columns["ProductoCategoriaId"].Visible = false;
        }

        private void ObtenerProductos()
        {
            ProductoController con = new ProductoController();
            dataGridView1.DataSource = con.ObtenerProductos();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            string ProductoId = dataGridView1.CurrentRow.Cells["ProductoId"].Value.ToString();
            string ProductoCategoriaId = dataGridView1.CurrentRow.Cells["ProductoCategoriaId"].Value.ToString();
            string Codigo = dataGridView1.CurrentRow.Cells["Codigo"].Value.ToString();
            string Categoria = dataGridView1.CurrentRow.Cells["Categoria"].Value.ToString();
            string Articulo = dataGridView1.CurrentRow.Cells["Articulo"].Value.ToString();
            string Descripcion = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();


            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);

            dataGridView2.Columns.Add("productoId", "ProductoId");
            dataGridView2.Columns.Add("productoCategoriaId", "ProductoCategoriaId");
            dataGridView2.Columns.Add("codigo", "Codigo");
            dataGridView2.Columns.Add("categoria", "Categoria");
            dataGridView2.Columns.Add("articulo", "Articulo");
            dataGridView2.Columns.Add("descripcion", "Descripcion");

            dataGridView2.Rows.Add(ProductoId, ProductoCategoriaId, Codigo, Categoria, Articulo, Descripcion);

            dataGridView2.Columns["ProductoId"].Visible = false;
            dataGridView2.Columns["ProductoCategoriaId"].Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            BuscarClientes frm = new BuscarClientes();
            AddOwnedForm(frm);
            frm.Show();
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            BuscarClientes frm = new BuscarClientes();
            AddOwnedForm(frm);
            frm.Show();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
