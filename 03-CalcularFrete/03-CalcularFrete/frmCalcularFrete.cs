using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_CalcularFrete
{
    public partial class fmrCalcularFrete : Form
    {
        public fmrCalcularFrete()
        {
            InitializeComponent();
        }

        private void fmrCalcularFrete_Load(object sender, EventArgs e)
        {
            cbbEstado.SelectedIndex = 0;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }


        public void LimpaCampos()
        {
            txbValor.Clear();
            txbNome.Clear();
            cbbEstado.SelectedIndex = -1;
            lblValor.Text = String.Empty;
            lblFrete.Text = String.Empty;
            lblTotal.Text = String.Empty;
            txbNome.Focus();
        }

        public Boolean VerificaCampos()
        {
            if (txbNome.Text == String.Empty)
            {
                MessageBox.Show("Campo Obrigatorio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbNome.Focus();
                return false;
            }
            if (txbValor.Text == String.Empty)
            {
                MessageBox.Show("Campo Obrigatorio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbEstado.Focus();
                return false;
            }
            return true;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (VerificaCampos())
            {
                Calcular();
            }
        }

        private void txbValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }
        public void Calcular()
        {
            // Declarando as variáveis
            string nome = txbNome.Text;
            decimal valor = decimal.Parse(txbValor.Text);
            string estado = cbbEstado.SelectedItem.ToString();
            decimal frete = 0, total = 0;


            // Calculo do frete
            if (valor < 1000)
            {
                frete = 0;
            }
            else
            {
                switch (estado)
                {
                    case "SP":
                        frete = 5;
                        break;
                    case "RJ":
                        frete = 5;
                        break;
                    case "AM":
                        frete = 5;
                        break;
                    default:
                        frete = 15;
                        break;
                }

                // A variável total recebe o valor digitado mais o frete
                total = valor + frete;

                //Mostrar os valores nos labels
                lblValor.Text = valor.ToString("c");
                lblFrete.Text = frete.ToString("c");
                lblTotal.Text = total.ToString("c");
            }
        }

        
    }
}
