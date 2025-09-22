namespace Variables
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lblVariableLocal = new System.Windows.Forms.Label();
            this.lblVariableGlobal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(101, 46);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(236, 20);
            this.tbNombre.TabIndex = 2;
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(101, 82);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(100, 20);
            this.tbCodigo.TabIndex = 3;
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVerificar.Location = new System.Drawing.Point(101, 124);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(221, 72);
            this.btnVerificar.TabIndex = 4;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // lblVariableLocal
            // 
            this.lblVariableLocal.AutoSize = true;
            this.lblVariableLocal.Location = new System.Drawing.Point(98, 217);
            this.lblVariableLocal.Name = "lblVariableLocal";
            this.lblVariableLocal.Size = new System.Drawing.Size(70, 13);
            this.lblVariableLocal.TabIndex = 5;
            this.lblVariableLocal.Text = "Variable local";
            // 
            // lblVariableGlobal
            // 
            this.lblVariableGlobal.AutoSize = true;
            this.lblVariableGlobal.Location = new System.Drawing.Point(98, 252);
            this.lblVariableGlobal.Name = "lblVariableGlobal";
            this.lblVariableGlobal.Size = new System.Drawing.Size(78, 13);
            this.lblVariableGlobal.TabIndex = 6;
            this.lblVariableGlobal.Text = "Variable Global";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 410);
            this.Controls.Add(this.lblVariableGlobal);
            this.Controls.Add(this.lblVariableLocal);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label lblVariableLocal;
        private System.Windows.Forms.Label lblVariableGlobal;
    }
}

