namespace VistaForm
{
    partial class FrmGenerarFisico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGenerarFisico));
            this.rbtnCajas = new System.Windows.Forms.RadioButton();
            this.rbtnDistribucion = new System.Windows.Forms.RadioButton();
            this.rbtnEmpaquetar = new System.Windows.Forms.RadioButton();
            this.rbtnGrabar = new System.Windows.Forms.RadioButton();
            this.rbtnCaratulas = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.btnFabricar = new System.Windows.Forms.Button();
            this.lbListaFisicos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // rbtnCajas
            // 
            this.rbtnCajas.AutoSize = true;
            this.rbtnCajas.BackColor = System.Drawing.Color.Transparent;
            this.rbtnCajas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnCajas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCajas.ForeColor = System.Drawing.Color.White;
            this.rbtnCajas.Location = new System.Drawing.Point(98, 247);
            this.rbtnCajas.Name = "rbtnCajas";
            this.rbtnCajas.Size = new System.Drawing.Size(137, 25);
            this.rbtnCajas.TabIndex = 1;
            this.rbtnCajas.TabStop = true;
            this.rbtnCajas.Text = "Fabricar cajas";
            this.rbtnCajas.UseVisualStyleBackColor = false;
            // 
            // rbtnDistribucion
            // 
            this.rbtnDistribucion.AutoSize = true;
            this.rbtnDistribucion.BackColor = System.Drawing.Color.Transparent;
            this.rbtnDistribucion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnDistribucion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDistribucion.ForeColor = System.Drawing.Color.White;
            this.rbtnDistribucion.Location = new System.Drawing.Point(98, 371);
            this.rbtnDistribucion.Name = "rbtnDistribucion";
            this.rbtnDistribucion.Size = new System.Drawing.Size(188, 25);
            this.rbtnDistribucion.TabIndex = 3;
            this.rbtnDistribucion.TabStop = true;
            this.rbtnDistribucion.Text = "Preparar distribucion";
            this.rbtnDistribucion.UseVisualStyleBackColor = false;
            // 
            // rbtnEmpaquetar
            // 
            this.rbtnEmpaquetar.AutoSize = true;
            this.rbtnEmpaquetar.BackColor = System.Drawing.Color.Transparent;
            this.rbtnEmpaquetar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnEmpaquetar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnEmpaquetar.ForeColor = System.Drawing.Color.White;
            this.rbtnEmpaquetar.Location = new System.Drawing.Point(98, 340);
            this.rbtnEmpaquetar.Name = "rbtnEmpaquetar";
            this.rbtnEmpaquetar.Size = new System.Drawing.Size(226, 25);
            this.rbtnEmpaquetar.TabIndex = 4;
            this.rbtnEmpaquetar.TabStop = true;
            this.rbtnEmpaquetar.Text = "Empaquetar videojuegos";
            this.rbtnEmpaquetar.UseVisualStyleBackColor = false;
            // 
            // rbtnGrabar
            // 
            this.rbtnGrabar.AutoSize = true;
            this.rbtnGrabar.BackColor = System.Drawing.Color.Transparent;
            this.rbtnGrabar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnGrabar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnGrabar.ForeColor = System.Drawing.Color.White;
            this.rbtnGrabar.Location = new System.Drawing.Point(98, 309);
            this.rbtnGrabar.Name = "rbtnGrabar";
            this.rbtnGrabar.Size = new System.Drawing.Size(145, 25);
            this.rbtnGrabar.TabIndex = 5;
            this.rbtnGrabar.TabStop = true;
            this.rbtnGrabar.Text = "Grabar Blu-Ray";
            this.rbtnGrabar.UseVisualStyleBackColor = false;
            // 
            // rbtnCaratulas
            // 
            this.rbtnCaratulas.AutoSize = true;
            this.rbtnCaratulas.BackColor = System.Drawing.Color.Transparent;
            this.rbtnCaratulas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnCaratulas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCaratulas.ForeColor = System.Drawing.Color.White;
            this.rbtnCaratulas.Location = new System.Drawing.Point(98, 278);
            this.rbtnCaratulas.Name = "rbtnCaratulas";
            this.rbtnCaratulas.Size = new System.Drawing.Size(170, 25);
            this.rbtnCaratulas.TabIndex = 6;
            this.rbtnCaratulas.TabStop = true;
            this.rbtnCaratulas.Text = "Fabricar caratulas";
            this.rbtnCaratulas.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(402, 278);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 35);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.BackColor = System.Drawing.Color.Transparent;
            this.lblStock.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.ForeColor = System.Drawing.Color.White;
            this.lblStock.Location = new System.Drawing.Point(366, 249);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(221, 21);
            this.lblStock.TabIndex = 8;
            this.lblStock.Text = "Cantidad juegos a fabricar";
            // 
            // btnFabricar
            // 
            this.btnFabricar.BackColor = System.Drawing.Color.Transparent;
            this.btnFabricar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFabricar.Location = new System.Drawing.Point(379, 340);
            this.btnFabricar.Name = "btnFabricar";
            this.btnFabricar.Size = new System.Drawing.Size(186, 56);
            this.btnFabricar.TabIndex = 9;
            this.btnFabricar.Text = "Aceptar";
            this.btnFabricar.UseVisualStyleBackColor = false;
            this.btnFabricar.Click += new System.EventHandler(this.btnFabricar_Click);
            // 
            // lbListaFisicos
            // 
            this.lbListaFisicos.FormattingEnabled = true;
            this.lbListaFisicos.Location = new System.Drawing.Point(62, 12);
            this.lbListaFisicos.Name = "lbListaFisicos";
            this.lbListaFisicos.Size = new System.Drawing.Size(555, 225);
            this.lbListaFisicos.TabIndex = 10;
            // 
            // FrmGenerarFisico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(674, 418);
            this.Controls.Add(this.lbListaFisicos);
            this.Controls.Add(this.btnFabricar);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rbtnCaratulas);
            this.Controls.Add(this.rbtnGrabar);
            this.Controls.Add(this.rbtnEmpaquetar);
            this.Controls.Add(this.rbtnDistribucion);
            this.Controls.Add(this.rbtnCajas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGenerarFisico";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produccion de fisicos";
            this.Load += new System.EventHandler(this.FrmGenerarFisico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbtnCajas;
        private System.Windows.Forms.RadioButton rbtnDistribucion;
        private System.Windows.Forms.RadioButton rbtnEmpaquetar;
        private System.Windows.Forms.RadioButton rbtnGrabar;
        private System.Windows.Forms.RadioButton rbtnCaratulas;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Button btnFabricar;
        private System.Windows.Forms.ListBox lbListaFisicos;
    }
}