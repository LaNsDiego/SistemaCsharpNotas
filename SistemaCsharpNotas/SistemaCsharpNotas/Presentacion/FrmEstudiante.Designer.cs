namespace SistemaCsharpNotas.Presentacion
{
    partial class FrmEstudiante
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
            this.DgvEstudiante = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEstudiante)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvEstudiante
            // 
            this.DgvEstudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEstudiante.Location = new System.Drawing.Point(12, 213);
            this.DgvEstudiante.Name = "DgvEstudiante";
            this.DgvEstudiante.Size = new System.Drawing.Size(807, 267);
            this.DgvEstudiante.TabIndex = 0;
            // 
            // FrmEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 492);
            this.Controls.Add(this.DgvEstudiante);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEstudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmEstudiante";
            this.Load += new System.EventHandler(this.FrmEstudiante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvEstudiante)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvEstudiante;
    }
}