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

    public partial class frmPrincipal : Form
    {
        private string nomeUsu;
        private bool clicouLogout;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        public frmPrincipal(string n)
        {
            this.nomeUsu = n;
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            frmLogin flogin = new frmLogin();
            tsslNomeUsu.Text = "Usuário: " + nomeUsu;
            tsslNomeUsu.Visible=true;
        }

        private void tsbtnCadCrianca_Click(object sender, EventArgs e)
        {
            Form varCrianca = new frmCadCrianca();

            varCrianca.Show();
        }

        private void tsbtnCadResponsavel_Click(object sender, EventArgs e)
        {
            Form varResp = new frmCadResponsavel();

            varResp.Show();
        }

        private void tsbtnCadTurma_Click(object sender, EventArgs e)
        {
            Form varTurma = new frmCadTurma();

            varTurma.Show();
        }

        private void tsbtnCadProfissional_Click(object sender, EventArgs e)
        {
            Form varProf = new frmProfissional();

            varProf.Show();
        }

        private void temp_Tick(object sender, EventArgs e)
        {
            tsslTemp.Text = DateTime.Now.ToString();
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void tsMenuItenSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsMenuItemLogout_Click(object sender, EventArgs e)
        {
            frmLogin fl = new frmLogin();
            clicouLogout = true;

            for (int intIndex = Application.OpenForms.Count - 1; intIndex >= 0; intIndex--)
            {
                if (Application.OpenForms[intIndex].Name != fl.Name)
                    Application.OpenForms[intIndex].Close();
                else
                {
                    fl.Show();
                }
            }
        }

        private void TSMenuItemSobreSistema_Click(object sender, EventArgs e)
        {
            Form varAbout = new frmAbout();

            varAbout.Show();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!clicouLogout)
            {
                Application.Exit();
            }
        }


    }
}
