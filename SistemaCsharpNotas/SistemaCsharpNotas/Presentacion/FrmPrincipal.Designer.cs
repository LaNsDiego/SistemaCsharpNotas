namespace SistemaCsharpNotas
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
            this.BtnNotas = new System.Windows.Forms.Button();
            this.BtnEstudiante = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnNotas
            // 
            this.BtnNotas.Location = new System.Drawing.Point(31, 23);
            this.BtnNotas.Name = "BtnNotas";
            this.BtnNotas.Size = new System.Drawing.Size(131, 117);
            this.BtnNotas.TabIndex = 0;
            this.BtnNotas.Text = "button1";
            this.BtnNotas.UseVisualStyleBackColor = true;
            // 
            // BtnEstudiante
            // 
            this.BtnEstudiante.Location = new System.Drawing.Point(191, 23);
            this.BtnEstudiante.Name = "BtnEstudiante";
            this.BtnEstudiante.Size = new System.Drawing.Size(131, 117);
            this.BtnEstudiante.TabIndex = 1;
            this.BtnEstudiante.Text = "button2";
            this.BtnEstudiante.UseVisualStyleBackColor = true;
            this.BtnEstudiante.Click += new System.EventHandler(this.BtnEstudiante_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(350, 23);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 117);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BtnEstudiante);
            this.Controls.Add(this.BtnNotas);
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnNotas;
        private System.Windows.Forms.Button BtnEstudiante;
        private System.Windows.Forms.Button button3;
    }
}

