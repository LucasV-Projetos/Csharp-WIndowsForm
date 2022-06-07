using _01_AulaCsharp.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_AulaCsharp
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Adicionando itens ao combobox
            cbbLinguagens.Items.Add("Java");
            cbbLinguagens.Items.Add("JQuery");
            cbbLinguagens.Items.Add("Pear");

            // Iniciando o combobox com alguma opção selecionada
            cbbLinguagens.SelectedIndex = 1;

            // Notificação do Windows
            notifyIcon1.BalloonTipTitle = "ATENÇÃO!!!";
            notifyIcon1.BalloonTipText = "Você tem uma nova mensagem";
            notifyIcon1.Icon = SystemIcons.Warning;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(5000);

            //Criando as colunas o DataGrig
            dgvTeste.Columns.Add("codigo", "Código");
            dgvTeste.Columns.Add("nome", "Nome");
            dgvTeste.Columns.Add("preco", "Preço");
            dgvTeste.Columns.Add("data", "Data");

            //Alinhamento o DataGrig
            dgvTeste.Columns["codigo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvTeste.Columns["preco"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            //Preenche as linhas do DataGrid
            for (int i = 1; i <= 10;i++)
            {
                //Cria uma linha
                DataGridViewRow item = new DataGridViewRow();
                item.CreateCells(dgvTeste);

                //Seta os valores
                item.Cells[0].Value = i;
                item.Cells[1].Value = "Produto" + i;
                item.Cells[2].Value = 10.50;
                item.Cells[3].Value = DateTime.Today;

                //Adiciona as linhas no DataGrig
                dgvTeste.Rows.Add(item);
            }

            //Formatando o preço e a data no DataGrid
            dgvTeste.Columns["preco"].DefaultCellStyle.Format = "c";
            dgvTeste.Columns["data"].DefaultCellStyle.Format = "dd/MM/yyyy";

        }

        private void cbbLinguagens_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblLinguagens.Text = cbbLinguagens.Text;
        }

        private void tabInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblLinguagens_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dgvTeste_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void picImagem_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCuidado_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cuidado!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnAtencao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Atenção!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnOla_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olá usuário, seja bem vindo!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult Sair = MessageBox.Show("Deseja sair do programa?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Sair == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void chkSQL_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSQL.Checked == true)
            {

                MessageBox.Show("Você selecionou o SQL Server", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Você desmarcou o SQL Server", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void chkCsharp_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCsharp.Checked == true)
            {

                MessageBox.Show("Você selecionou o C#", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Você desmarcou o C#", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void chkMySQL_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMySQL.Checked == true)
            {

                MessageBox.Show("Você selecionou o MySQL", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Você desmarcou o MySQL", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rdbSim_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSim.Checked == true)
            {

                MessageBox.Show("Boa Escolha", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rdbNao_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNao.Checked == true)
            {

                MessageBox.Show("PUTZ...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStripSalva_Click(object sender, EventArgs e)
        {
            toolStripSalva.Enabled = false;
            toolStripCancelar.Visible = true;
        }

        private void toolStripSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.ShowDialog();
            this.Show();
        }
    }
}
