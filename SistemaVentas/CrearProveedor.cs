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
    public partial class CrearProveedor : Form
    {
        public bool isedit = false;
        public string ProveedorId;
        public CrearProveedor()
        {
            InitializeComponent();
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            ProductoController cc = new ProductoController();
            ProveedorModel pm = new ProveedorModel();
            bool sucess = false;
            sucess = ProveedorValidacion();

            if (sucess)
            {
                pm.Proveedor = txtproveedor.Text;
                pm.Contacto = txtcontacto.Text;
                pm.Correo = txtcorreo.Text;
                pm.Telefono1 = txttelefono1.Text;
                pm.Telefono2 = txttelefono2.Text;

                if (isedit == false)
                {
                    if (cc.InsertarProveedor(pm))
                    {
                        this.Close();
                    }
                }
                else
                {
                    pm.ProveedorId = new Guid(ProveedorId);
                    try
                    {
                        if (cc.ActualizarProveedor(pm))
                        {
                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo insertar los datos por: " + ex);
                    }
                }
            }
        }

        public bool ProveedorValidacion()
        {
            bool success = false;
            string proveedor = txtproveedor.Text;

            if (proveedor != "")
            {
                success = true;
            }else
            {
                MessageBox.Show("Ingrese el Proveedor. ");
            }


            return success;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
