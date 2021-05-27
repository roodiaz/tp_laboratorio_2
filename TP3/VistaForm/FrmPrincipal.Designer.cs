namespace VistaForm
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombreDistribuidora = new System.Windows.Forms.Label();
            this.btnJuegoFisico = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCargarDatosJuegos = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 0;
            // 
            // lblNombreDistribuidora
            // 
            this.lblNombreDistribuidora.AutoSize = true;
            this.lblNombreDistribuidora.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreDistribuidora.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDistribuidora.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNombreDistribuidora.Location = new System.Drawing.Point(83, 18);
            this.lblNombreDistribuidora.Name = "lblNombreDistribuidora";
            this.lblNombreDistribuidora.Size = new System.Drawing.Size(333, 29);
            this.lblNombreDistribuidora.TabIndex = 1;
            this.lblNombreDistribuidora.Text = "Sony Computer Entertainment";
            // 
            // btnJuegoFisico
            // 
            this.btnJuegoFisico.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnJuegoFisico.Location = new System.Drawing.Point(41, 179);
            this.btnJuegoFisico.Name = "btnJuegoFisico";
            this.btnJuegoFisico.Size = new System.Drawing.Size(155, 46);
            this.btnJuegoFisico.TabIndex = 2;
            this.btnJuegoFisico.Text = "Fabricar juegos fisicos";
            this.btnJuegoFisico.UseVisualStyleBackColor = false;
            this.btnJuegoFisico.Click += new System.EventHandler(this.btnJuegoFisico_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(192, 338);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(155, 46);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Exit";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCargarDatosJuegos
            // 
            this.btnCargarDatosJuegos.Location = new System.Drawing.Point(41, 253);
            this.btnCargarDatosJuegos.Name = "btnCargarDatosJuegos";
            this.btnCargarDatosJuegos.Size = new System.Drawing.Size(155, 45);
            this.btnCargarDatosJuegos.TabIndex = 4;
            this.btnCargarDatosJuegos.Text = "Cargar datos juegos";
            this.btnCargarDatosJuegos.UseVisualStyleBackColor = true;
            this.btnCargarDatosJuegos.Click += new System.EventHandler(this.btnCargarDatosJuegos_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(261, 180);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 45);
            this.button4.TabIndex = 5;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(730, 396);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnCargarDatosJuegos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnJuegoFisico);
            this.Controls.Add(this.lblNombreDistribuidora);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlayStation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombreDistribuidora;
        private System.Windows.Forms.Button btnJuegoFisico;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCargarDatosJuegos;
        private System.Windows.Forms.Button button4;
    }
}

