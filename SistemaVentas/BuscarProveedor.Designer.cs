namespace SistemaVentas
{
    partial class BuscarProveedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.btneditar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbcampo = new System.Windows.Forms.Label();
            this.btncrearcliente = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnproveedorseleccionado = new System.Windows.Forms.Button();
            this.txtprimerapellido = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.btncerrar);
            this.panel1.Controls.Add(this.btnminimizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 32);
            this.panel1.TabIndex = 9;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btncerrar
            // 
            this.btncerrar.Image = global::SistemaVentas.Properties.Resources.icon_cerrar2;
            this.btncerrar.Location = new System.Drawing.Point(435, 7);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(20, 20);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncerrar.TabIndex = 9;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btnminimizar
            // 
            this.btnminimizar.Image = global::SistemaVentas.Properties.Resources.icon_minimizar;
            this.btnminimizar.Location = new System.Drawing.Point(405, 7);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(20, 20);
            this.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnminimizar.TabIndex = 8;
            this.btnminimizar.TabStop = false;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // btneditar
            // 
            this.btneditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.Location = new System.Drawing.Point(353, 443);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(104, 38);
            this.btneditar.TabIndex = 36;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(214, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Busqueda";
            // 
            // lbcampo
            // 
            this.lbcampo.AutoSize = true;
            this.lbcampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcampo.Location = new System.Drawing.Point(41, 43);
            this.lbcampo.Name = "lbcampo";
            this.lbcampo.Size = new System.Drawing.Size(57, 16);
            this.lbcampo.TabIndex = 34;
            this.lbcampo.Text = "Campo";
            // 
            // btncrearcliente
            // 
            this.btncrearcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncrearcliente.Location = new System.Drawing.Point(245, 443);
            this.btncrearcliente.Name = "btncrearcliente";
            this.btncrearcliente.Size = new System.Drawing.Size(104, 38);
            this.btncrearcliente.TabIndex = 33;
            this.btncrearcliente.Text = "Crear";
            this.btncrearcliente.UseVisualStyleBackColor = true;
            this.btncrearcliente.Click += new System.EventHandler(this.btncrearcliente_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(43, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 32;
            // 
            // btnproveedorseleccionado
            // 
            this.btnproveedorseleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproveedorseleccionado.Location = new System.Drawing.Point(9, 443);
            this.btnproveedorseleccionado.Name = "btnproveedorseleccionado";
            this.btnproveedorseleccionado.Size = new System.Drawing.Size(230, 38);
            this.btnproveedorseleccionado.TabIndex = 31;
            this.btnproveedorseleccionado.Text = "Agregar Proveedor Seleccionado";
            this.btnproveedorseleccionado.UseVisualStyleBackColor = true;
            this.btnproveedorseleccionado.Click += new System.EventHandler(this.btnproveedorseleccionado_Click);
            this.btnproveedorseleccionado.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnproveedorseleccionado_MouseDown);
            // 
            // txtprimerapellido
            // 
            this.txtprimerapellido.Location = new System.Drawing.Point(217, 66);
            this.txtprimerapellido.Name = "txtprimerapellido";
            this.txtprimerapellido.Size = new System.Drawing.Size(167, 20);
            this.txtprimerapellido.TabIndex = 30;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(380, 322);
            this.dataGridView1.TabIndex = 29;
            // 
            // BuscarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 494);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbcampo);
            this.Controls.Add(this.btncrearcliente);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnproveedorseleccionado);
            this.Controls.Add(this.txtprimerapellido);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuscarProveedor";
            this.Text = "BuscarProveedor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BuscarProveedor_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BuscarProveedor_FormClosed);
            this.Load += new System.EventHandler(this.BuscarProveedor_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbcampo;
        private System.Windows.Forms.Button btncrearcliente;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnproveedorseleccionado;
        private System.Windows.Forms.TextBox txtprimerapellido;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}