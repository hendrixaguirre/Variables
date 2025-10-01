using System;
using System.Windows.Forms;

namespace Variables
{
    public partial class FrmLogin : Form
    {
        private int intentos = 0;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void lblUser_Click(object sender, EventArgs e)
        {
            tbPassword.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Logear();
        }

        private void Logear()
        {
            if (Login(tbUser.Text, tbPassword.Text))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
                //new Form1().Show();
                //this.Hide();
            }
            else
            {
                intentos++;
                MessageBox.Show($"Usuario o contraseña incorrectos. Intento {intentos} de 3.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (intentos >= 3)
                {
                    MessageBox.Show("Ha superado el máximo de intentos. La ejecución se detendrá.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Application.Exit();
                }
                else
                {
                    tbPassword.Clear();
                    tbPassword.Focus();
                }
            }
        }
       
        private Boolean Login(string username, string password)
        {
            return username.Equals("admin") && password.Equals("admin");
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Logear();
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
//FrmLogin
