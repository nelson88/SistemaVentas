﻿namespace SistemaVentas
{
    partial class BuscarClientes
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
            this.txtprimerapellido = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.btnclienteseleccionado = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btncrearcliente = new System.Windows.Forms.Button();
            this.lbcampo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btneditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(380, 322);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // txtprimerapellido
            // 
            this.txtprimerapellido.Location = new System.Drawing.Point(220, 67);
            this.txtprimerapellido.Name = "txtprimerapellido";
            this.txtprimerapellido.Size = new System.Drawing.Size(167, 20);
            this.txtprimerapellido.TabIndex = 6;
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
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            // btnclienteseleccionado
            // 
            this.btnclienteseleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclienteseleccionado.Location = new System.Drawing.Point(12, 444);
            this.btnclienteseleccionado.Name = "btnclienteseleccionado";
            this.btnclienteseleccionado.Size = new System.Drawing.Size(224, 38);
            this.btnclienteseleccionado.TabIndex = 15;
            this.btnclienteseleccionado.Text = "Agregar Cliente Seleccionado";
            this.btnclienteseleccionado.UseVisualStyleBackColor = true;
            this.btnclienteseleccionado.Click += new System.EventHandler(this.btnclienteseleccionado_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(46, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // btncrearcliente
            // 
            this.btncrearcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncrearcliente.Location = new System.Drawing.Point(245, 444);
            this.btncrearcliente.Name = "btncrearcliente";
            this.btncrearcliente.Size = new System.Drawing.Size(104, 38);
            this.btncrearcliente.TabIndex = 17;
            this.btncrearcliente.Text = "Crear";
            this.btncrearcliente.UseVisualStyleBackColor = true;
            this.btncrearcliente.Click += new System.EventHandler(this.btncrearcliente_Click);
            // 
            // lbcampo
            // 
            this.lbcampo.AutoSize = true;
            this.lbcampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcampo.Location = new System.Drawing.Point(44, 44);
            this.lbcampo.Name = "lbcampo";
            this.lbcampo.Size = new System.Drawing.Size(57, 16);
            this.lbcampo.TabIndex = 18;
            this.lbcampo.Text = "Campo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(217, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Busqueda";
            // 
            // btneditar
            // 
            this.btneditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.Location = new System.Drawing.Point(356, 444);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(104, 38);
            this.btneditar.TabIndex = 20;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // BuscarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 494);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbcampo);
            this.Controls.Add(this.btncrearcliente);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnclienteseleccionado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtprimerapellido);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuscarClientes";
            this.Text = "BuscarClientes";
            this.Load += new System.EventHandler(this.BuscarClientes_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BuscarClientes_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
		
		private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtprimerapellido;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.Button btnclienteseleccionado;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btncrearcliente;
        private System.Windows.Forms.Label lbcampo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btneditar;
    }
}