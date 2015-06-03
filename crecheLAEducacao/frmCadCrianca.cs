using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleCreche;
using ModeloNegocioCreche;

namespace crecheLAEducacao
{
    public partial class frmCadCrianca : Form
    {
        public frmCadCrianca()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                CriacaCtrl controle = new CriacaCtrl();

                Crianca c = PegaCriancaDoForm();

                controle.SalvarCrianca(c);
                MessageBox.Show("Dados gravados com sucesso!");
                //Limpa campos;
                tbxNome.Text = "";
                mtbDataNasc.Text = "";
                rbMasc.Checked = true;

                tbxNome.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void frmCadCrianca_Load(object sender, EventArgs e)
        {

        }

        private Crianca PegaCriancaDoForm()
        {
            Crianca c = new Crianca();

            c.Nome = tbxNome.Text;
            c.DataNasc = mtbDataNasc.Text;
            if (rbMasc.Checked)
            {
                c.Sexo = "masculino";
            }
            else
            {
                c.Sexo = "feminino";
            }
            
            return c;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tbxNome.Text = "";
            mtbDataNasc.Text = "";
            rbMasc.Checked = true;
            tbxNome.Focus();
        }

    }
}
