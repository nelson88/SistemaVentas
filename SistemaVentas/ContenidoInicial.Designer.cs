namespace SistemaVentas
{
    partial class ContenidoInicial
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
            this.btnabonos = new System.Windows.Forms.Button();
            this.btnproductos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(118, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(828, 355);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnabonos
            // 
            this.btnabonos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnabonos.Location = new System.Drawing.Point(118, 476);
            this.btnabonos.Name = "btnabonos";
            this.btnabonos.Size = new System.Drawing.Size(157, 34);
            this.btnabonos.TabIndex = 1;
            this.btnabonos.Text = "Ver Abonos";
            this.btnabonos.UseVisualStyleBackColor = true;
            this.btnabonos.Click += new System.EventHandler(this.btnabonos_Click);
            // 
            // btnproductos
            // 
            this.btnproductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproductos.Location = new System.Drawing.Point(324, 476);
            this.btnproductos.Name = "btnproductos";
            this.btnproductos.Size = new System.Drawing.Size(157, 34);
            this.btnproductos.TabIndex = 2;
            this.btnproductos.Text = "Ver Productos";
            this.btnproductos.UseVisualStyleBackColor = true;
            this.btnproductos.Click += new System.EventHandler(this.btnproductos_Click);
            // 
            // ContenidoInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 612);
            this.Controls.Add(this.btnproductos);
            this.Controls.Add(this.btnabonos);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ContenidoInicial";
            this.Text = "ContenidoInicial";
            this.Load += new System.EventHandler(this.ContenidoInicial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnabonos;
        private System.Windows.Forms.Button btnproductos;
    }
}