using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variables.Formularios
{
    public partial class FrmMatrizCuadrada : Form
    {
        public FrmMatrizCuadrada()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        public void tbTamaño_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(tbTamaño.Text); 
        }
    }
}
