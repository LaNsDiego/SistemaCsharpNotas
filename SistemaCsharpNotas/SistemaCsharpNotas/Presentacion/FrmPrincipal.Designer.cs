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
            this.BtnDocente = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PnlContenedor = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnNotas
            // 
            this.BtnNotas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNotas.Location = new System.Drawing.Point(0, 100);
            this.BtnNotas.Name = "BtnNotas";
            this.BtnNotas.Size = new System.Drawing.Size(200, 41);
            this.BtnNotas.TabIndex = 0;
            this.BtnNotas.Text = "Notas";
            this.BtnNotas.UseVisualStyleBackColor = true;
            this.BtnNotas.Click += new System.EventHandler(this.BtnNotas_Click);
            // 
            // BtnEstudiante
            // 
            this.BtnEstudiante.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEstudiante.Location = new System.Drawing.Point(0, 182);
            this.BtnEstudiante.Name = "BtnEstudiante";
            this.BtnEstudiante.Size = new System.Drawing.Size(200, 41);
            this.BtnEstudiante.TabIndex = 1;
            this.BtnEstudiante.Text = "Estudiantes";
            this.BtnEstudiante.UseVisualStyleBackColor = true;
            this.BtnEstudiante.Click += new System.EventHandler(this.BtnEstudiante_Click);
            // 
            // BtnDocente
            // 
            this.BtnDocente.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDocente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDocente.Location = new System.Drawing.Point(0, 141);
            this.BtnDocente.Name = "BtnDocente";
            this.BtnDocente.Size = new System.Drawing.Size(200, 41);
            this.BtnDocente.TabIndex = 2;
            this.BtnDocente.Text = "Docente";
            this.BtnDocente.UseVisualStyleBackColor = true;
            this.BtnDocente.Click += new System.EventHandler(this.BtnDocente_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnEstudiante);
            this.panel1.Controls.Add(this.BtnDocente);
            this.panel1.Controls.Add(this.BtnNotas);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 456);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 356);
            this.panel3.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(23, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PnlContenedor
            // 
            this.PnlContenedor.BackColor = System.Drawing.Color.DodgerBlue;
            this.PnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContenedor.Location = new System.Drawing.Point(200, 0);
            this.PnlContenedor.Name = "PnlContenedor";
            this.PnlContenedor.Size = new System.Drawing.Size(702, 456);
            this.PnlContenedor.TabIndex = 4;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 456);
            this.Controls.Add(this.PnlContenedor);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnNotas;
        private System.Windows.Forms.Button BtnEstudiante;
        private System.Windows.Forms.Button BtnDocente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PnlContenedor;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

