namespace SistemaVentas
{
    partial class Compras
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnagregar = new System.Windows.Forms.Button();
            this.dpfecha = new System.Windows.Forms.DateTimePicker();
            this.txtabonoinicial = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbabonoinicial = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbmodopago = new System.Windows.Forms.ComboBox();
            this.rbcredito = new System.Windows.Forms.RadioButton();
            this.rbcontado = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.lbtotalcompra = new System.Windows.Forms.Label();
            this.lbdescuento = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.txtvendedor = new System.Windows.Forms.TextBox();
            this.txtobservaciones = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.lbcodigo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 259);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(463, 340);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(625, 259);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(463, 340);
            this.dataGridView2.TabIndex = 1;
            // 
            // btnagregar
            // 
            this.btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.Location = new System.Drawing.Point(481, 415);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(131, 40);
            this.btnagregar.TabIndex = 2;
            this.btnagregar.Text = "Agregar >>";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // dpfecha
            // 
            this.dpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpfecha.Location = new System.Drawing.Point(199, 119);
            this.dpfecha.Name = "dpfecha";
            this.dpfecha.Size = new System.Drawing.Size(135, 20);
            this.dpfecha.TabIndex = 3;
            // 
            // txtabonoinicial
            // 
            this.txtabonoinicial.Location = new System.Drawing.Point(667, 81);
            this.txtabonoinicial.Name = "txtabonoinicial";
            this.txtabonoinicial.Size = new System.Drawing.Size(121, 20);
            this.txtabonoinicial.TabIndex = 7;
            // 
            // btnguardar
            // 
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Location = new System.Drawing.Point(646, 199);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(131, 40);
            this.btnguardar.TabIndex = 10;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Location = new System.Drawing.Point(777, 200);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(131, 40);
            this.btncancelar.TabIndex = 11;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(908, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 40);
            this.button1.TabIndex = 12;
            this.button1.Text = "Ver compras";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(829, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Observaciones";
            // 
            // lbabonoinicial
            // 
            this.lbabonoinicial.AutoSize = true;
            this.lbabonoinicial.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbabonoinicial.Location = new System.Drawing.Point(559, 85);
            this.lbabonoinicial.Name = "lbabonoinicial";
            this.lbabonoinicial.Size = new System.Drawing.Size(88, 16);
            this.lbabonoinicial.TabIndex = 15;
            this.lbabonoinicial.Text = "Abono inical";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(829, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Modo de pago";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(559, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Vendedor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(136, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Cliente:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(108, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(245, 24);
            this.label8.TabIndex = 20;
            this.label8.Text = "REALIZAR LA COMPRA";
            // 
            // cbmodopago
            // 
            this.cbmodopago.FormattingEnabled = true;
            this.cbmodopago.Location = new System.Drawing.Point(947, 26);
            this.cbmodopago.Name = "cbmodopago";
            this.cbmodopago.Size = new System.Drawing.Size(121, 21);
            this.cbmodopago.TabIndex = 21;
            // 
            // rbcredito
            // 
            this.rbcredito.AutoSize = true;
            this.rbcredito.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbcredito.Location = new System.Drawing.Point(112, 210);
            this.rbcredito.Name = "rbcredito";
            this.rbcredito.Size = new System.Drawing.Size(72, 20);
            this.rbcredito.TabIndex = 22;
            this.rbcredito.TabStop = true;
            this.rbcredito.Text = "Credito";
            this.rbcredito.UseVisualStyleBackColor = true;
            this.rbcredito.Click += new System.EventHandler(this.rbcredito_Click);
            // 
            // rbcontado
            // 
            this.rbcontado.AutoSize = true;
            this.rbcontado.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbcontado.Location = new System.Drawing.Point(223, 209);
            this.rbcontado.Name = "rbcontado";
            this.rbcontado.Size = new System.Drawing.Size(79, 20);
            this.rbcontado.TabIndex = 23;
            this.rbcontado.TabStop = true;
            this.rbcontado.Text = "Contado";
            this.rbcontado.UseVisualStyleBackColor = true;
            this.rbcontado.Click += new System.EventHandler(this.rbcontado_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(823, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 19);
            this.label6.TabIndex = 24;
            this.label6.Text = "Total compra:";
            // 
            // lbtotalcompra
            // 
            this.lbtotalcompra.AutoSize = true;
            this.lbtotalcompra.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtotalcompra.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbtotalcompra.Location = new System.Drawing.Point(943, 152);
            this.lbtotalcompra.Name = "lbtotalcompra";
            this.lbtotalcompra.Size = new System.Drawing.Size(52, 24);
            this.lbtotalcompra.TabIndex = 25;
            this.lbtotalcompra.Text = "0.00";
            // 
            // lbdescuento
            // 
            this.lbdescuento.AutoSize = true;
            this.lbdescuento.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdescuento.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbdescuento.Location = new System.Drawing.Point(725, 151);
            this.lbdescuento.Name = "lbdescuento";
            this.lbdescuento.Size = new System.Drawing.Size(52, 24);
            this.lbdescuento.TabIndex = 27;
            this.lbdescuento.Text = "0.00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(621, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 19);
            this.label10.TabIndex = 26;
            this.label10.Text = "Descuento:";
            // 
            // txtcliente
            // 
            this.txtcliente.Location = new System.Drawing.Point(199, 162);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(135, 20);
            this.txtcliente.TabIndex = 28;
            this.txtcliente.Click += new System.EventHandler(this.txtcliente_Click);
            // 
            // txtvendedor
            // 
            this.txtvendedor.Location = new System.Drawing.Point(667, 26);
            this.txtvendedor.Name = "txtvendedor";
            this.txtvendedor.Size = new System.Drawing.Size(121, 20);
            this.txtvendedor.TabIndex = 29;
            this.txtvendedor.Click += new System.EventHandler(this.txtvendedor_Click);
            this.txtvendedor.TextChanged += new System.EventHandler(this.txtvendedor_TextChanged);
            // 
            // txtobservaciones
            // 
            this.txtobservaciones.Location = new System.Drawing.Point(947, 81);
            this.txtobservaciones.Multiline = true;
            this.txtobservaciones.Name = "txtobservaciones";
            this.txtobservaciones.Size = new System.Drawing.Size(121, 57);
            this.txtobservaciones.TabIndex = 30;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(199, 78);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(135, 20);
            this.txtcodigo.TabIndex = 31;
            // 
            // lbcodigo
            // 
            this.lbcodigo.AutoSize = true;
            this.lbcodigo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcodigo.Location = new System.Drawing.Point(57, 82);
            this.lbcodigo.Name = "lbcodigo";
            this.lbcodigo.Size = new System.Drawing.Size(136, 16);
            this.lbcodigo.TabIndex = 32;
            this.lbcodigo.Text = "Codigo Facturacion:";
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 612);
            this.Controls.Add(this.lbcodigo);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.txtobservaciones);
            this.Controls.Add(this.txtvendedor);
            this.Controls.Add(this.txtcliente);
            this.Controls.Add(this.lbdescuento);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbtotalcompra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rbcontado);
            this.Controls.Add(this.rbcredito);
            this.Controls.Add(this.cbmodopago);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbabonoinicial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtabonoinicial);
            this.Controls.Add(this.dpfecha);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Compras";
            this.Text = "Compra";
            this.Load += new System.EventHandler(this.Compra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.DateTimePicker dpfecha;
        private System.Windows.Forms.TextBox txtabonoinicial;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbabonoinicial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbmodopago;
        private System.Windows.Forms.RadioButton rbcredito;
        private System.Windows.Forms.RadioButton rbcontado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtvendedor;
        public System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.TextBox txtobservaciones;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.Label lbtotalcompra;
        public System.Windows.Forms.Label lbdescuento;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label lbcodigo;
    }
}