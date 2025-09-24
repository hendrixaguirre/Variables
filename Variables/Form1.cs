using System;
using System.Windows.Forms;
using Variables.Modelos;

namespace Variables
{
    public partial class Form1 : Form
    {
        Facultad Fac = new Facultad();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            Facultad Fia = new Facultad();
            Fia.Codigo = tbCodigo.Text;
            Fia.Nombre = tbNombre.Text;
            Fac = Fia;
            lblVariableLocal.Text = Fia.MostrarDatos();
        }

        private void btnVerificarG_Click(object sender, EventArgs e)
        {
            lblVariableGlobal.Text = Fac.MostrarDatos();
        }
    }
}
