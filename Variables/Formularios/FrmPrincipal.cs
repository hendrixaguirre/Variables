using System;
using System.Windows.Forms;
using Variables.Formularios;

namespace Variables
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void edadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmArreglos frm = new FrmArreglos();
            frm.ShowDialog();
        }
    }
}
