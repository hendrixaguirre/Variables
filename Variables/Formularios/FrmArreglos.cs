using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Variables.Modelos;

namespace Variables.Formularios
{
    public partial class FrmArreglos : Form
    {
        public FrmArreglos()
        {
            InitializeComponent();
        }

        private void tbEdad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int edad = int.Parse(tbEdad.Text);
                if (Arreglo.pos < 10) Arreglo.edades[Arreglo.pos++] = edad;
                else MessageBox.Show("No se puede agregar mas elementos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LlenarListado();
                    MostrarCalculos();
            }
        }
        public void LlenarListado()
        {
            lbEdades.DataSource = null;
            lbEdades.DataSource = Arreglo.edades;
            lbEdades.Refresh();
            gbEdades.Text = "Edades: " + Arreglo.pos;
            tbEdad.Text = "";
            tbEdad.Focus();
        }

        public void MostrarCalculos()
        {
            lblPromedio.Text = "Promedio: " + Arreglo.GetPromedio();
            lblMayor.Text = "Mayor: " + Arreglo.GetEdadMaxima();
            lblMenor.Text = "Menor: " + Arreglo.GetEdadMinima();
            lblMayorDeEdad.Text = "Mayores de Edad: " + Arreglo.GetMayorEdad();
            lblMenorDeEdad.Text = "Menores de Edad: " + Arreglo.GetMenorEdad();
        }

        private void tbEdad_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbEdades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
