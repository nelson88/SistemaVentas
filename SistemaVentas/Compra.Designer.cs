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
            this.lbmodepago = new System.Windows.Forms.Label();
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
            this.btnquitar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 319);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(617, 418);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(833, 319);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(617, 418);
            this.dataGridView2.TabIndex = 1;
            // 
            // btnagregar
            // 
            this.btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.Location = new System.Drawing.Point(641, 452);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(175, 49);
            this.btnagregar.TabIndex = 2;
            this.btnagregar.Text = "Agregar >>";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // dpfecha
            // 
            this.dpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpfecha.Location = new System.Drawing.Point(265, 146);
            this.dpfecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dpfecha.Name = "dpfecha";
            this.dpfecha.Size = new System.Drawing.Size(179, 22);
            this.dpfecha.TabIndex = 3;
            // 
            // txtabonoinicial
            // 
            this.txtabonoinicial.Location = new System.Drawing.Point(889, 123);
            this.txtabonoinicial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtabonoinicial.Name = "txtabonoinicial";
            this.txtabonoinicial.Size = new System.Drawing.Size(160, 22);
            this.txtabonoinicial.TabIndex = 7;
            // 
            // btnguardar
            // 
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Location = new System.Drawing.Point(861, 245);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(175, 49);
            this.btnguardar.TabIndex = 10;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Location = new System.Drawing.Point(1036, 246);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(175, 49);
            this.btncancelar.TabIndex = 11;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1211, 245);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 49);
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
            this.label1.Location = new System.Drawing.Point(189, 151);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1105, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Observaciones";
            // 
            // lbabonoinicial
            // 
            this.lbabonoinicial.AutoSize = true;
            this.lbabonoinicial.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbabonoinicial.Location = new System.Drawing.Point(745, 128);
            this.lbabonoinicial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbabonoinicial.Name = "lbabonoinicial";
            this.lbabonoinicial.Size = new System.Drawing.Size(105, 19);
            this.lbabonoinicial.TabIndex = 15;
            this.lbabonoinicial.Text = "Abono inical";
            // 
            // lbmodepago
            // 
            this.lbmodepago.AutoSize = true;
            this.lbmodepago.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmodepago.Location = new System.Drawing.Point(1105, 129);
            this.lbmodepago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbmodepago.Name = "lbmodepago";
            this.lbmodepago.Size = new System.Drawing.Size(120, 19);
            this.lbmodepago.TabIndex = 16;
            this.lbmodepago.Text = "Modo de pago";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(745, 40);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Vendedor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(181, 204);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "Cliente:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(144, 57);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(323, 32);
            this.label8.TabIndex = 20;
            this.label8.Text = "REALIZAR LA COMPRA";
            // 
            // cbmodopago
            // 
            this.cbmodopago.FormattingEnabled = true;
            this.cbmodopago.Location = new System.Drawing.Point(1263, 123);
            this.cbmodopago.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbmodopago.Name = "cbmodopago";
            this.cbmodopago.Size = new System.Drawing.Size(160, 24);
            this.cbmodopago.TabIndex = 21;
            // 
            // rbcredito
            // 
            this.rbcredito.AutoSize = true;
            this.rbcredito.Checked = true;
            this.rbcredito.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbcredito.Location = new System.Drawing.Point(149, 258);
            this.rbcredito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbcredito.Name = "rbcredito";
            this.rbcredito.Size = new System.Drawing.Size(88, 23);
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
            this.rbcontado.Location = new System.Drawing.Point(297, 257);
            this.rbcontado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbcontado.Name = "rbcontado";
            this.rbcontado.Size = new System.Drawing.Size(97, 23);
            this.rbcontado.TabIndex = 23;
            this.rbcontado.Text = "Contado";
            this.rbcontado.UseVisualStyleBackColor = true;
            this.rbcontado.Click += new System.EventHandler(this.rbcontado_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1097, 193);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 24);
            this.label6.TabIndex = 24;
            this.label6.Text = "Total compra:";
            // 
            // lbtotalcompra
            // 
            this.lbtotalcompra.AutoSize = true;
            this.lbtotalcompra.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtotalcompra.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbtotalcompra.Location = new System.Drawing.Point(1257, 187);
            this.lbtotalcompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbtotalcompra.Name = "lbtotalcompra";
            this.lbtotalcompra.Size = new System.Drawing.Size(68, 32);
            this.lbtotalcompra.TabIndex = 25;
            this.lbtotalcompra.Text = "0.00";
            // 
            // lbdescuento
            // 
            this.lbdescuento.AutoSize = true;
            this.lbdescuento.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdescuento.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbdescuento.Location = new System.Drawing.Point(967, 186);
            this.lbdescuento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbdescuento.Name = "lbdescuento";
            this.lbdescuento.Size = new System.Drawing.Size(68, 32);
            this.lbdescuento.TabIndex = 27;
            this.lbdescuento.Text = "0.00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(828, 192);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 24);
            this.label10.TabIndex = 26;
            this.label10.Text = "Descuento:";
            // 
            // txtcliente
            // 
            this.txtcliente.Location = new System.Drawing.Point(265, 199);
            this.txtcliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(179, 22);
            this.txtcliente.TabIndex = 28;
            this.txtcliente.Click += new System.EventHandler(this.txtcliente_Click);
            // 
            // txtvendedor
            // 
            this.txtvendedor.Location = new System.Drawing.Point(889, 34);
            this.txtvendedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtvendedor.Name = "txtvendedor";
            this.txtvendedor.Size = new System.Drawing.Size(160, 22);
            this.txtvendedor.TabIndex = 29;
            this.txtvendedor.Click += new System.EventHandler(this.txtvendedor_Click);
            this.txtvendedor.TextChanged += new System.EventHandler(this.txtvendedor_TextChanged);
            // 
            // txtobservaciones
            // 
            this.txtobservaciones.Location = new System.Drawing.Point(1263, 20);
            this.txtobservaciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtobservaciones.Multiline = true;
            this.txtobservaciones.Name = "txtobservaciones";
            this.txtobservaciones.Size = new System.Drawing.Size(160, 69);
            this.txtobservaciones.TabIndex = 30;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(265, 96);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(179, 22);
            this.txtcodigo.TabIndex = 31;
            // 
            // lbcodigo
            // 
            this.lbcodigo.AutoSize = true;
            this.lbcodigo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcodigo.Location = new System.Drawing.Point(76, 101);
            this.lbcodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbcodigo.Name = "lbcodigo";
            this.lbcodigo.Size = new System.Drawing.Size(169, 19);
            this.lbcodigo.TabIndex = 32;
            this.lbcodigo.Text = "Codigo Facturacion:";
            // 
            // btnquitar
            // 
            this.btnquitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnquitar.Location = new System.Drawing.Point(641, 530);
            this.btnquitar.Margin = new System.Windows.Forms.Padding(4);
            this.btnquitar.Name = "btnquitar";
            this.btnquitar.Size = new System.Drawing.Size(175, 49);
            this.btnquitar.TabIndex = 33;
            this.btnquitar.Text = "<< Quitar";
            this.btnquitar.UseVisualStyleBackColor = true;
            this.btnquitar.Click += new System.EventHandler(this.btnquitar_Click);
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 753);
            this.Controls.Add(this.btnquitar);
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
            this.Controls.Add(this.lbmodepago);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label lbmodepago;
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
        private System.Windows.Forms.Button btnquitar;
    }
}