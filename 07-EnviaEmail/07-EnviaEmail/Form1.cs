using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_EnviaEmail
{
    public partial class frmEnviaEmail : Form
    {
        public frmEnviaEmail()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (VerificaDados())
            {
                try
                {
                    btnEnviar.Text = "Enviando...";
                    btnEnviar.Enabled = false;
                    MailMessage mensagem = new MailMessage();
                    SmtpClient smtp = new SmtpClient();
                    mensagem.From = new MailAddress(txbEmail.Text, "07-EnviaEmail");
                    mensagem.To.Add(txbPara.Text);
                    mensagem.Subject = (txbAssunto.Text);
                    mensagem.Body = (txbMensagem.Text);
                    mensagem.Priority = MailPriority.Normal;

                    smtp.EnableSsl = true;
                    smtp.Port = 587; // Outlook e Hotmail
                    smtp.Host = "smtp.office365.com";
                    smtp.Credentials = new NetworkCredential("nathan.coliveira1@senacsp.edu.br", txbSenha.Text);
                    smtp.Send(mensagem);

                    MessageBox.Show("Mensagem enviada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txbPara.Clear();
                    txbAssunto.Clear();
                    txbMensagem.Clear();
                    txbSenha.Clear();
                    txbPara.Focus();
                    btnEnviar.Enabled = true;
                    btnEnviar.Text = "Enviar";

                }
                catch (Exception)
                {

                    MessageBox.Show("Erro ao enviar o E-mail", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private Boolean VerificaDados()
        {
            if (txbPara.Text == string.Empty)
            {
                MessageBox.Show("Campos obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbPara.Focus();
                return false;
            }

            if (txbAssunto.Text == string.Empty)
            {
                MessageBox.Show("Campos obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbAssunto.Focus();
                return false;
            }

            if (txbMensagem.Text == string.Empty)
            {
                MessageBox.Show("Campos obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbMensagem.Focus();
                return false;
            }

            if (txbSenha.Text == string.Empty)
            {
                MessageBox.Show("Campos obrigatório", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbSenha.Focus();
                return false;
            }
            return true;
        }
    }
}
