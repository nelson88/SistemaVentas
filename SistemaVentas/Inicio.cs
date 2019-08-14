using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SistemaVentas
{
    public partial class Inicio : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            pictureBox2_Click_1(null, e);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CERRAR_Click(object sender, EventArgs e)
        {
            Login formLogin = new Login();
            
            this.Hide();
            formLogin.Show();
        }

        private void PRODUCTO_Click(object sender, EventArgs e)
        {
            //Producto formProducto = new Producto();

            //this.Hide();
            //formProducto.Show();

            AbrirFormHija(new Producto());
        }

        private void AbrirFormHija(object formhija)
        {
            if(this.panelContenedor.Controls.Count>0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
            
        }

        private void MINIMIZAR_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MAXIMIZAR_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            MAXIMIZAR.Visible = false;
            btnrestaurar.Visible = true;      
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            MAXIMIZAR.Visible = true;
            btnrestaurar.Visible = false;
        }

        private void barraTitulo_Paint(object sender, PaintEventArgs e)
        {
			
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            AbrirFormHija(new ContenidoInicial());
        }

        private void btninicio_Click(object sender, EventArgs e)
        {

        }

        private void menuVertical_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Inicio_Load_1(object sender, EventArgs e)
        {
            pictureBox2_Click_1(null, e);
        }

        private void btncliente_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Cliente());
        }
        private void btnrecibo_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Recibo());
        }

        private void btncompra_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new AsignacionProductoCliente());
        }

        private void btnrecibo_Click_1(object sender, EventArgs e)
        {
            AbrirFormHija(new Recibo());
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
