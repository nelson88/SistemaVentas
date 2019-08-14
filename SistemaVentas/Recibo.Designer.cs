namespace SistemaVentas
{
    partial class Recibo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recibo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btcompra = new System.Windows.Forms.Button();
            this.lbcompra = new System.Windows.Forms.Label();
            this.txtcompra = new System.Windows.Forms.TextBox();
            this.lblinsrtedit = new System.Windows.Forms.Label();
            this.dpfechaabono = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btncliente = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnuevosaldo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmontoabono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtconcepto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btcompra);
            this.panel1.Controls.Add(this.lbcompra);
            this.panel1.Controls.Add(this.txtcompra);
            this.panel1.Controls.Add(this.lblinsrtedit);
            this.panel1.Controls.Add(this.dpfechaabono);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btncliente);
            this.panel1.Controls.Add(this.btnguardar);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtnuevosaldo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtmontoabono);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtconcepto);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtcliente);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(742, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 455);
            this.panel1.TabIndex = 0;
            // 
            // btcompra
            // 
            this.btcompra.Image = ((System.Drawing.Image)(resources.GetObject("btcompra.Image")));
            this.btcompra.Location = new System.Drawing.Point(251, 128);
            this.btcompra.Name = "btcompra";
            this.btcompra.Size = new System.Drawing.Size(39, 30);
            this.btcompra.TabIndex = 31;
            this.btcompra.UseVisualStyleBackColor = true;
            this.btcompra.Click += new System.EventHandler(this.btcompra_Click);
            // 
            // lbcompra
            // 
            this.lbcompra.AutoSize = true;
            this.lbcompra.Location = new System.Drawing.Point(30, 138);
            this.lbcompra.Name = "lbcompra";
            this.lbcompra.Size = new System.Drawing.Size(46, 13);
            this.lbcompra.TabIndex = 30;
            this.lbcompra.Text = "Compra:";
            // 
            // txtcompra
            // 
            this.txtcompra.Location = new System.Drawing.Point(86, 133);
            this.txtcompra.Name = "txtcompra";
            this.txtcompra.Size = new System.Drawing.Size(156, 20);
            this.txtcompra.TabIndex = 29;
            // 
            // lblinsrtedit
            // 
            this.lblinsrtedit.AutoSize = true;
            this.lblinsrtedit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinsrtedit.Location = new System.Drawing.Point(10, 10);
            this.lblinsrtedit.Name = "lblinsrtedit";
            this.lblinsrtedit.Size = new System.Drawing.Size(217, 18);
            this.lblinsrtedit.TabIndex = 28;
            this.lblinsrtedit.Text = "Ingreso y Edicion de recibos";
            // 
            // dpfechaabono
            // 
            this.dpfechaabono.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpfechaabono.Location = new System.Drawing.Point(87, 173);
            this.dpfechaabono.Name = "dpfechaabono";
            this.dpfechaabono.Size = new System.Drawing.Size(155, 20);
            this.dpfechaabono.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Fecha Abano:";
            // 
            // btncliente
            // 
            this.btncliente.Image = ((System.Drawing.Image)(resources.GetObject("btncliente.Image")));
            this.btncliente.Location = new System.Drawing.Point(251, 89);
            this.btncliente.Name = "btncliente";
            this.btncliente.Size = new System.Drawing.Size(39, 30);
            this.btncliente.TabIndex = 11;
            this.btncliente.UseVisualStyleBackColor = true;
            this.btncliente.Click += new System.EventHandler(this.btncliente_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(67, 339);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(175, 34);
            this.btnguardar.TabIndex = 10;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nuevo saldo:";
            // 
            // txtnuevosaldo
            // 
            this.txtnuevosaldo.Enabled = false;
            this.txtnuevosaldo.Location = new System.Drawing.Point(86, 283);
            this.txtnuevosaldo.Name = "txtnuevosaldo";
            this.txtnuevosaldo.Size = new System.Drawing.Size(156, 20);
            this.txtnuevosaldo.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Monto Abono:";
            // 
            // txtmontoabono
            // 
            this.txtmontoabono.Enabled = false;
            this.txtmontoabono.Location = new System.Drawing.Point(86, 246);
            this.txtmontoabono.Name = "txtmontoabono";
            this.txtmontoabono.Size = new System.Drawing.Size(156, 20);
            this.txtmontoabono.TabIndex = 6;
            this.txtmontoabono.TextChanged += new System.EventHandler(this.txtmontoabono_TextChanged);
            this.txtmontoabono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmontoabono_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Concepto:";
            // 
            // txtconcepto
            // 
            this.txtconcepto.Location = new System.Drawing.Point(86, 209);
            this.txtconcepto.Name = "txtconcepto";
            this.txtconcepto.Size = new System.Drawing.Size(156, 20);
            this.txtconcepto.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cliente:";
            // 
            // txtcliente
            // 
            this.txtcliente.Location = new System.Drawing.Point(86, 93);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(156, 20);
            this.txtcliente.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(86, 58);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(156, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbltitulo);
            this.panel2.Controls.Add(this.btneliminar);
            this.panel2.Controls.Add(this.btneditar);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(742, 455);
            this.panel2.TabIndex = 1;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(32, 10);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(122, 18);
            this.lbltitulo.TabIndex = 27;
            this.lbltitulo.Text = "Lista de recibos";
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(177, 406);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(116, 34);
            this.btneliminar.TabIndex = 2;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(35, 406);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(117, 34);
            this.btneditar.TabIndex = 1;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(709, 351);
            this.dataGridView1.TabIndex = 0;
            // 
            // Recibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 455);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Recibo";
            this.Text = "Recibo";
            this.Load += new System.EventHandler(this.Recibo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
		
		private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnuevosaldo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtconcepto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btncliente;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.DateTimePicker dpfechaabono;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblinsrtedit;
        private System.Windows.Forms.Label lbcompra;
        private System.Windows.Forms.Button btcompra;
        public System.Windows.Forms.TextBox txtcompra;
        public System.Windows.Forms.TextBox txtmontoabono;
    }
}