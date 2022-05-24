using _06_CRUD.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_CRUD
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private Boolean VerificaCampos()
        {
            if (txbLogin.Text == String.Empty)
            {
                MessageBox.Show("Campo orbigatorio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbLogin.Focus();
                return false;
            }

            if (txbSenha.Text == String.Empty)
            {
                MessageBox.Show("Campo orbigatorio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbSenha.Focus();
                return false;
            }
            return true;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (VerificaCampos())
            {
                try
                {
                    this.Visible = false;
                    string senhaCrypto = Crypto.sha256encrypt(txbSenha.Text);
                    senhaCrypto = senhaCrypto.ToLower();
                    Login.RealizarLogin(txbLogin.Text, senhaCrypto);
                    this.Visible = true;
                    txbLogin.Clear();
                    txbSenha.Clear();
                    txbLogin.Focus();
                }
                catch (Exception erro)
                {

                    MessageBox.Show(erro.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult Sair = MessageBox.Show("Deseja sair do programa?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Sair == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void frmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {

            }
        }

        private void txbSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (VerificaCampos())
                {
                    btnEntrar.PerformClick();
                }
            }
        }
    }
}
