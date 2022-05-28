using _06_CRUD.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_CRUD.Telas
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
                toolStripUsuarios.Visible = false;
            }
            toolStripStatus.Text = "Olá " + usuarioLogado.Nome + ", seu nível de acesso é " + nivelUsu;
            dgvPessoas.DataSource = Pessoa.BuscaTodasPessoas();
            dgvPessoas.Columns[0].HeaderText = "Código";
            dgvPessoas.Columns[1].HeaderText = "Nome";
            dgvPessoas.Columns[2].HeaderText = "E-mail";
            dgvPessoas.Columns[3].HeaderText = "Fone";
            dgvPessoas.Columns[4].HeaderText = "Dt Nascimento";
            dgvPessoas.Columns[5].HeaderText = "Sexo";
            dgvPessoas.Columns[6].Visible = false;
            dgvPessoas.Columns[7].Visible = false;
        }

        private void toolStripSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaDados())
            {
                try
                {
                    //Copia a foto
                    string Destino = Directory.GetCurrentDirectory();
                    CopiarArquivo(txbFoto.Text, @Destino + "\\" + Path.GetFileName(txbFoto.Text));

                    //Grava os dados no banco de dados
                    string DataBanco = dtpNascimento.Value.ToString("yyyy-MM-dd");
                    Pessoa NovaPessoa = new Pessoa(txbNome.Text, txbEmail.Text, mskFone.Text, DataBanco, cbbSexo.SelectedItem.ToString(), Path.GetFileName(txbFoto.Text), 1);
                    int id = NovaPessoa.CadastraPessoa();
                    MessageBox.Show("Pessoa inserida com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    //Criando o log
                    string arquivoLog = @Destino + @"\log.txt";
                    if (!File.Exists(arquivoLog))
                        File.Create(arquivoLog).Close();
                    File.AppendAllText(arquivoLog, "Usuário " + usuarioLogado.Nome + " - inseriu o registro " + id + " em (" + DateTime.Now.ToString() + ")\r\n");

                    //Atualiza o datagrid
                    dgvPessoas.DataSource = Pessoa.BuscaTodasPessoas();

                    //Limpar os textbox
                    LimpaDados();
                }
                catch (Exception erro)
                {

                    MessageBox.Show("Ocorreu um erro: " + erro, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
        }

        private Boolean ValidaDados()
        {
            if (txbNome.Text == string.Empty)
            {
                MessageBox.Show("Campo obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbNome.Focus();
                return false;
            }

            if (txbEmail.Text == string.Empty)
            {
                MessageBox.Show("Campo obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbEmail.Focus();
                return false;
            }

            if (mskFone.Text == string.Empty)
            {
                MessageBox.Show("Campo obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mskFone.Focus();
                return false;
            }

            if (dtpNascimento.Value == DateTime.Now)
            {
                MessageBox.Show("Selecione a data de nascimento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dtpNascimento.Focus();
                return false;
            }

            if (cbbSexo.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione o sexo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbbSexo.Focus();
                return false;
            }

            return true;
        }

        private void LimpaDados()
        {
            txbId.Clear();
            txbNome.Clear();
            txbEmail.Clear();
            mskFone.Clear();
            dtpNascimento.Value = DateTime.Now;
            cbbSexo.SelectedIndex = -1;
            txbFoto.Clear();
            picFoto.Image = null;
            txbNome.Focus();
        }

        static bool CopiarArquivo(string nomeArquivoOrigem, string nomeArquivoDestino)
        {
            if (File.Exists(nomeArquivoOrigem) == false)
            {
                MessageBox.Show("Atenção! \nNão foi possível encontrar a foto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (File.Exists(nomeArquivoDestino) == true)
            {
                if (MessageBox.Show("Atenção! \nJá existe foto com esse nome, deseja substituir a foto?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return false;
            }
            try
            {
                Stream s1 = File.Open(@nomeArquivoOrigem, FileMode.Open, FileAccess.ReadWrite);
                Stream s2 = File.Open(@nomeArquivoDestino, FileMode.Create);

                BinaryReader f1 = new BinaryReader(s1);
                BinaryWriter f2 = new BinaryWriter(s2);

                while (true)
                {
                    byte[] buf = new byte[10240];
                    int sz = f1.Read(buf, 0, 10240);
                    if (sz <= 0)
                        break;
                    f2.Write(buf, 0, sz);
                    if (sz < 10240)
                        break;
                }
                f1.Close();
                f2.Close();
                MessageBox.Show("Foto salva!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao salvar a foto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog AbreFoto = new OpenFileDialog();
            AbreFoto.Title = "Selecione uma foto";
            AbreFoto.Filter = "All files (*.*)|*.*";
            DialogResult dr = AbreFoto.ShowDialog();
            if (dr == DialogResult.OK)
            {
                try
                {
                    txbFoto.Text = AbreFoto.FileName;
                    picFoto.ImageLocation = txbFoto.Text;
                }
                catch (Exception)
                {

                    MessageBox.Show("Erro ao carregar a foto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void dgvPessoas_Click(object sender, EventArgs e)
        {
            toolStripSalvar.Enabled = false;
            toolStripAlterar.Enabled = true;
            toolStripExcluir.Enabled = true;
            toolStripCancelar.Visible = true;
            btnFoto.Enabled = false;
            picFoto.Enabled = true;
            dgvPessoas.DefaultCellStyle.SelectionBackColor = Color.Tomato;
            try
            {
                MostraPessoa();
            }
            catch (Exception)
            {

                MessageBox.Show("Erro ao carregar a foto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void MostraPessoa()
        {
            try
            {
                if (dgvPessoas.SelectedRows.Count > 0)
                {
                    txbId.Text = dgvPessoas.SelectedRows[0].Cells[0].Value.ToString();
                    txbNome.Text = dgvPessoas.SelectedRows[0].Cells[1].Value.ToString();
                    txbEmail.Text = dgvPessoas.SelectedRows[0].Cells[2].Value.ToString();
                    mskFone.Text = dgvPessoas.SelectedRows[0].Cells[3].Value.ToString();
                    dtpNascimento.Text = dgvPessoas.SelectedRows[0].Cells[4].Value.ToString();
                    cbbSexo.Text = dgvPessoas.SelectedRows[0].Cells[5].Value.ToString();
                    txbFoto.Text = dgvPessoas.SelectedRows[0].Cells[6].Value.ToString();
                    picFoto.Image = null;
                    picFoto.Load(dgvPessoas.SelectedRows[0].Cells[6].Value.ToString());
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void toolStripCancelar_Click(object sender, EventArgs e)
        {
            LimpaDados();
            toolStripSalvar.Enabled = true;
            toolStripAlterar.Enabled = false;
            toolStripExcluir.Enabled = false;
            toolStripCancelar.Visible = false;
            picFoto.Enabled = false;
            txbNome.Focus();
            dgvPessoas.DefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
        }

        private void toolStripAlterar_Click(object sender, EventArgs e)
        {
            if (ValidaDados())
            {
                string DataBanco = dtpNascimento.Value.ToString("yyyy/MM/dd");
                Pessoa Atualiza = new Pessoa(int.Parse(txbId.Text), txbNome.Text, txbEmail.Text, mskFone.Text, DataBanco, cbbSexo.SelectedItem.ToString());
                Atualiza.AlteraPessoa();
                toolStripCancelar.PerformClick();
                dgvPessoas.DataSource = Pessoa.BuscaTodasPessoas();
                txbNome.Focus();
            }
        }

        private void toolStripExcluir_Click(object sender, EventArgs e)
        {
            DialogResult Pergunta = MessageBox.Show("Deseja excluir esta pessoa?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Pergunta == DialogResult.Yes)
            {
                Pessoa Desativa = new Pessoa(int.Parse(txbId.Text));
                Desativa.DesativaPessoa();
                toolStripCancelar.PerformClick();
                dgvPessoas.DataSource = Pessoa.BuscaTodasPessoas();
                txbNome.Focus();
            }
        }

        private void picFoto_DoubleClick(object sender, EventArgs e)
        {
            if (usuarioLogado.Nivel == 0)
            {
                btnFoto.Enabled = true;
                btnFoto.PerformClick();
                txbNome.Enabled = false;
                txbEmail.Enabled = false;
                mskFone.Enabled = false;
                dtpNascimento.Enabled = false;
                cbbSexo.Enabled = false;
                toolStripAlterar.Enabled = false;
                toolStripMudaFoto.Visible = true;
                toolStripSalvar.Enabled = false;
                toolStripCancelar.Visible = true;
                toolStripExcluir.Enabled = false;
            }
            else
            {
                MessageBox.Show("Você não tem permissão para alterar a foto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripMudaFoto_Click(object sender, EventArgs e)
        {
            //Copia a foto
            string Destino = Directory.GetCurrentDirectory();
            CopiarArquivo(txbFoto.Text, @Destino + "\\" + Path.GetFileName(txbFoto.Text));

            //Atualiza o banco de dados
            Pessoa MudaFoto = new Pessoa(int.Parse(txbId.Text), Path.GetFileName(txbFoto.Text));
            MudaFoto.AlteraFoto();
            toolStripCancelar.PerformClick();
            dgvPessoas.DataSource = Pessoa.BuscaTodasPessoas();
            txbNome.Enabled = true;
            txbEmail.Enabled = true;
            mskFone.Enabled = true;
            dtpNascimento.Enabled = true;
            cbbSexo.Enabled = true;
            txbNome.Focus();
            toolStripMudaFoto.Visible = false;
        }

        private void toolStripSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbBusca_DropDownClosed(object sender, EventArgs e)
        {
            if (cbbBusca.SelectedIndex == 0 || cbbBusca.SelectedIndex == 5)
            {
                txbBusca.Clear();
                txbBusca.Enabled = false;
            }
            else
            {
                txbBusca.Clear();
                txbBusca.Enabled = true;
                txbBusca.Focus();
            }
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbbBusca.SelectedIndex == 0)
                {
                    dgvPessoas.DataSource = Pessoa.BuscaTodasPessoas();
                }
                if (cbbBusca.SelectedIndex == 1)
                {
                    dgvPessoas.DataSource = Pessoa.BuscarPorId(int.Parse(txbBusca.Text));
                }
                if (cbbBusca.SelectedIndex == 2)
                {
                    dgvPessoas.DataSource = Pessoa.BuscarPorNome(txbBusca.Text);
                }
                if (cbbBusca.SelectedIndex == 3)
                {
                    dgvPessoas.DataSource = Pessoa.BuscarPorEmail(txbBusca.Text);
                }
                if (cbbBusca.SelectedIndex == 4)
                {
                    dgvPessoas.DataSource = Pessoa.BuscarPorFone(txbBusca.Text);
                }
                if (cbbBusca.SelectedIndex == 5)
                {
                    dgvPessoas.DataSource = Pessoa.BuscarPorAtivo(0);
                }
            }
            catch (Exception)
            {

               
            }
            
        }

        private void toolStripAlterarSenha_Click(object sender, EventArgs e)
        {
            frmSenha TS = new frmSenha(usuarioLogado);
            TS.ShowDialog();
        }

        private void toolStripUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuario TU = new frmUsuario(usuarioLogado);
            TU.ShowDialog();
        }
    }
}
