using SistemaCsharpNotas.Entidad;
using SistemaCsharpNotas.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCsharpNotas.Presentacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            FrmPrincipal frm = new FrmPrincipal();
            this.Hide();
            frm.Visible = true;
            frm.Show();
        }
    }
}
