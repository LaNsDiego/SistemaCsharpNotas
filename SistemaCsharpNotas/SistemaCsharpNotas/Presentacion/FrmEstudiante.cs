using SistemaCsharpNotas.Negocio;
using SistemaCsharpNotas.Entidad;
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
    public partial class FrmEstudiante : Form
    {
        public FrmEstudiante()
        {
            InitializeComponent();
        }

        private void FrmEstudiante_Load(object sender, EventArgs e)
        {
            ClsNEstudiante controlador = new ClsNEstudiante();
            DgvEstudiante.DataSource = controlador.Listar().Tables[0];
        }
    }
}
