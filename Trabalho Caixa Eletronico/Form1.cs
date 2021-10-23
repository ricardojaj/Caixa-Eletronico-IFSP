using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmJogoDaSorte
{
    public partial class frmJogoDaSorte : Form
    {
        int numero = 0;
        int chancesTentadas = 0;

        public frmJogoDaSorte()
        {
            InitializeComponent();
            numeroAleatorio();
            txtVerificarNumero.MaxLength = 2;
            txtNumeroDeJogadas.Text = "" + chancesTentadas;
            txtNumeroDeJogadas.Enabled = false;
            txtNumerosJogados.Enabled = false;
        }

        public string numeroAleatorio()
        {
            do
            {
                Random rdn = new Random();
                numero = rdn.Next(1, 100);
            }
            while (numero % 2 == 0);
            

            return numero.ToString();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(txtVerificarNumero.Text) > 99 || int.Parse(txtVerificarNumero.Text) < 0)
                {
                    MessageBox.Show("Digite um numero entre 0 e 99");
                    txtVerificarNumero.Text = string.Empty;
                    txtVerificarNumero.Focus();
                }
                else if (int.Parse(txtVerificarNumero.Text) %2 == 0)
                {
                    MessageBox.Show("Informe um numero impar");
                    txtVerificarNumero.Text = string.Empty;
                    txtVerificarNumero.Focus();
                }
                else if (int.Parse(txtVerificarNumero.Text) == numero)
                {
                    chancesTentadas++;
                    txtNumeroDeJogadas.Text = " " + chancesTentadas;
                    MessageBox.Show("Voce acertou, PARABENS !!!");
                    reiniciarJogo();
                }
                else if (int.Parse(txtVerificarNumero.Text) > numero)
                {
                    chancesTentadas++;
                    txtNumeroDeJogadas.Text = " " + chancesTentadas;
                    txtNumerosJogados.Text = "," + txtVerificarNumero.Text + txtNumerosJogados.Text;
                    MessageBox.Show("Número digitado é Maior", "Errooo!");

                    txtVerificarNumero.Text = string.Empty;
                    txtVerificarNumero.Focus();
                }
                else if (int.Parse(txtVerificarNumero.Text) < numero)
                {
                    chancesTentadas++;
                    txtNumeroDeJogadas.Text = " " + chancesTentadas;
                    txtNumerosJogados.Text = "," + txtVerificarNumero.Text + txtNumerosJogados.Text;
                    MessageBox.Show("Numero digitado é menor", "Erroooo!");

                    txtVerificarNumero.Text = string.Empty;
                    txtVerificarNumero.Focus();
                }

            }
            catch
            {
                MessageBox.Show("Somente numeros");
            }
        }

        public void reiniciarJogo()
        {
            txtVerificarNumero.Text = string.Empty;
            txtNumerosJogados.Text = string.Empty;
            txtNumeroDeJogadas.Text = string.Empty;
            txtVerificarNumero.Focus();
            numeroAleatorio();
            chancesTentadas = 0;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", " AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void somenteNumeros(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)(Keys.Back))
            {
                e.Handled = false;
            }
            else if(e.KeyChar == (char)(Keys.Enter))
            {
                btnVerificar_Click(null, null);
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnDesistencia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O numero da sorte eh: " + numero);
            reiniciarJogo();
        }
    }
}
