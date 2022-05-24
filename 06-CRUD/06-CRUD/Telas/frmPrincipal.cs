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
    public partial class frmPrincipal : Form
    {
        Login usuarioLogado = new Login();
        string nivelUsu = "";



        public frmPrincipal(Login usu)
        {
            InitializeComponent();
            usuarioLogado = usu;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            if (usuarioLogado.Nivel == 0)
            {
                nivelUsu = "Administrador";
            }
            else
            {
                nivelUsu = "Usuário comum";
            }
            toolStripStatus.Text = "Olá " + usuarioLogado.Nome + ", Seu nível de acesso é" + nivelUsu;
            dgvPessoas.
        }
    }
}
