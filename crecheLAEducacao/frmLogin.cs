using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crecheLAEducacao
{
    public partial class frmLogin : Form
    {
        public String usuario = "";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            tbLogin.Text = "";
            tbSenha.Text = "";
            tbLogin.Focus();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            if (tbLogin.Text.Equals("coordenador") && tbSenha.Text.Equals("123"))
            {
                usuario = tbLogin.Text;
                this.Hide();
                Form frmPrinc = new frmPrincipal(usuario);
                frmPrinc.Show();

                tbLogin.Tag = usuario;
                
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválido!");
                this.tbSenha.Text = "";
                this.tbLogin.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbSenha_KeyDown(object sender, KeyEventArgs e)
        {
        }

    }
}
