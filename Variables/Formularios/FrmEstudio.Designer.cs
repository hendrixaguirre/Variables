namespace Variables.Formularios
{
    partial class FrmEstudio
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
            this.gbEdades = new System.Windows.Forms.GroupBox();
            this.lbEdades = new System.Windows.Forms.ListBox();
            this.tbEdades = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblMenorDeEdad = new System.Windows.Forms.Label();
            this.lblMayorDeEdad = new System.Windows.Forms.Label();
            this.lblMenor = new System.Windows.Forms.Label();
            this.lblMayor = new System.Windows.Forms.Label();
            this.gbEdades.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEdades
            // 
            this.gbEdades.Controls.Add(this.lblMenorDeEdad);
            this.gbEdades.Controls.Add(this.lblMayorDeEdad);
            this.gbEdades.Controls.Add(this.lblMenor);
            this.gbEdades.Controls.Add(this.lblMayor);
            this.gbEdades.Controls.Add(this.lbEdades);
            this.gbEdades.Controls.Add(this.tbEdades);
            this.gbEdades.Controls.Add(this.label1);
            this.gbEdades.Controls.Add(this.lblPromedio);
            this.gbEdades.Location = new System.Drawing.Point(13, 22);
            this.gbEdades.Name = "gbEdades";
            this.gbEdades.Size = new System.Drawing.Size(167, 416);
            this.gbEdades.TabIndex = 0;
            this.gbEdades.TabStop = false;
            this.gbEdades.Text = "Edades: 0";
            // 
            // lbEdades
            // 
            this.lbEdades.FormattingEnabled = true;
            this.lbEdades.Location = new System.Drawing.Point(6, 78);
            this.lbEdades.Name = "lbEdades";
            this.lbEdades.Size = new System.Drawing.Size(142, 160);
            this.lbEdades.TabIndex = 2;
            this.lbEdades.SelectedIndexChanged += new System.EventHandler(this.lbEdades_SelectedIndexChanged);
            // 
            // tbEdades
            // 
            this.tbEdades.Location = new System.Drawing.Point(6, 41);
            this.tbEdades.Name = "tbEdades";
            this.tbEdades.Size = new System.Drawing.Size(125, 20);
            this.tbEdades.TabIndex = 1;
            this.tbEdades.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbEdades_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese edades:";
            // 
            // lblPromedio
            // 
            this.lblPromedio.Location = new System.Drawing.Point(6, 261);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(100, 23);
            this.lblPromedio.TabIndex = 1;
            this.lblPromedio.Text = "Promedio: 0";
            // 
            // lblMenorDeEdad
            // 
            this.lblMenorDeEdad.Location = new System.Drawing.Point(7, 363);
            this.lblMenorDeEdad.Name = "lblMenorDeEdad";
            this.lblMenorDeEdad.Size = new System.Drawing.Size(128, 23);
            this.lblMenorDeEdad.TabIndex = 2;
            this.lblMenorDeEdad.Text = "Menores de edad: 0";
            // 
            // lblMayorDeEdad
            // 
            this.lblMayorDeEdad.Location = new System.Drawing.Point(7, 340);
            this.lblMayorDeEdad.Name = "lblMayorDeEdad";
            this.lblMayorDeEdad.Size = new System.Drawing.Size(113, 23);
            this.lblMayorDeEdad.TabIndex = 3;
            this.lblMayorDeEdad.Text = "Mayores de edad: 0";
            // 
            // lblMenor
            // 
            this.lblMenor.Location = new System.Drawing.Point(7, 317);
            this.lblMenor.Name = "lblMenor";
            this.lblMenor.Size = new System.Drawing.Size(100, 23);
            this.lblMenor.TabIndex = 4;
            this.lblMenor.Text = "Menor: 0";
            // 
            // lblMayor
            // 
            this.lblMayor.Location = new System.Drawing.Point(6, 294);
            this.lblMayor.Name = "lblMayor";
            this.lblMayor.Size = new System.Drawing.Size(100, 23);
            this.lblMayor.TabIndex = 5;
            this.lblMayor.Text = "Mayor: 0";
            // 
            // FrmCamila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 450);
            this.Controls.Add(this.gbEdades);
            this.MaximizeBox = false;
            this.Name = "FrmCamila";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCamila";
            this.gbEdades.ResumeLayout(false);
            this.gbEdades.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEdades;
        private System.Windows.Forms.ListBox lbEdades;
        private System.Windows.Forms.TextBox tbEdades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblMenorDeEdad;
        private System.Windows.Forms.Label lblMayorDeEdad;
        private System.Windows.Forms.Label lblMenor;
        private System.Windows.Forms.Label lblMayor;
    }
}