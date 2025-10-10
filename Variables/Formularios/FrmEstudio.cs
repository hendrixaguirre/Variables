using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Variables.Modelos;

namespace Variables.Formularios
{
    public partial class FrmEstudio : Form
    {
        public FrmEstudio()
        {
            InitializeComponent();
        }

        private void tbEdades_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    int edad = int.Parse(tbEdades.Text);
                    if (Estudio.pos < 10)
                    {
                        Estudio.edades[Estudio.pos++] = edad;
                        LlenarListado();
                        MostrarCalculos();
                    }
                    else
                    {
                        MessageBox.Show("No se pueden agregar más elementos al arreglo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbEdades.Enabled = false;
                        LlenarListado();
                        MostrarCalculos();
                    }
                }catch (FormatException)
                {
                    MessageBox.Show("No se puede agregar otro tipo de valor que no sea número entero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void LlenarListado()
        {
            lbEdades.DataSource = null;
            lbEdades.DataSource = Estudio.edades;
            lbEdades.Refresh();
            gbEdades.Text = $"Edades: {Estudio.pos}";
            tbEdades.Text = "";
            tbEdades.Focus();
        }

        public void MostrarCalculos()
        {
            lblPromedio.Text = $"Promedio: {Estudio.GetPromedio()}";
            lblMayor.Text = $"Mayor: {Estudio.GetMayor()}";
            lblMenor.Text = $"Menor: {Estudio.GetMenor()}";
            lblMayorDeEdad.Text = $"Mayores de edad: {Estudio.GetMayorEdad()}";
            lblMenorDeEdad.Text = $"Menores de edad: {Estudio.GetMenorEdad()}";
        }

        private void lbEdades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
