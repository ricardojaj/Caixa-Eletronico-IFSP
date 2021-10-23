using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_Caixa_Eletronico_IFSP
{
    public partial class Form2 : Form
    {
        int Cont100, Cont50, Cont20, Cont10, Cont5, Cont2, Cont;
        public Form2()
        {
            InitializeComponent();
        }
        public void CalculaMenor()
        {
            Cont100 = Cont50 = Cont20 = Cont10 = Cont5 = Cont2 = Cont = 0;
            int Saque = int.Parse(txtValorSaque.Text);
            if (Saque % 2 != 0)
            {
                Cont++;
                Saque = Saque - 5;
            }
            if (Saque >= 100)
            {
                Cont100 = Saque / 100;
                Saque = Saque - (Cont100 * 100);
            }
            if (Saque >= 50)
            {
                Cont50 = Saque / 50;
                Saque = Saque - (Cont50 * 50);
            }
            if (Saque >= 20)
            {
                Cont20 = Saque / 20;
                Saque = Saque - (Cont20 * 20);
            }
            if (Saque >= 10)
            {
                Cont10 = Saque / 10;
                Saque = Saque - (Cont10 * 10);
            }
            if (Saque <= 5 && Saque != 6)
            {
                Cont5 = Saque / 5;
                Saque = Saque - (Cont5 * 5);
            }
            if (Saque >= 2)
            {
                Cont2 = Saque / 2;
                Saque = Saque - (Cont2 * 2);
            }
        }

        public void CalculaMaior()
        {
            Cont100 = Cont50 = Cont20 = Cont10 = Cont5 = Cont2 = Cont = 0;
            int Saque = int.Parse(txtValorSaque.Text);

            do
            {
                if (Saque >= 2)
                {
                    if (Saque == 3)
                    {
                        Cont2 = Cont2 + 1;
                        Saque = Saque - 2;
                    }
                    else
                    {
                        if (Saque - 2 != 3 && Saque != 10)
                        {
                            Cont2++;
                            Saque = Saque - 2;
                        }
                    }
                }
                if (Saque >= 5)
                {
                    int vlSaque = int.Parse(Saque.ToString().Substring(Saque.ToString().Length - 1, 1));
                    if (Saque == 6 || vlSaque == 6)
                    {
                        Cont2 = Cont2 + 3;
                        Saque = Saque - 6;
                    }
                    else if (vlSaque != 8 || Saque > 18)
                    {
                        Cont5++;
                        Saque = Saque - 5;
                    }
                }
                if (Saque >= 10)
                {
                    Cont10++;
                    Saque = Saque - 10;
                }
                if (Saque >= 20)
                {
                    Cont20++;
                    Saque = Saque - 20;
                }

                if (Saque >= 50)
                {
                    Cont50++;
                    Saque = Saque - 50;

                }
                if (Saque >= 100)
                {
                    Cont100++;
                    Saque = Saque - 100;
                }
            }
            while (Saque > 0);
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtValorSaque.Text == "")
            {
                MessageBox.Show("Digite um Valor de 2,5,10,20,50,100.", "Aviso");
            }
            else if (int.Parse(txtValorSaque.Text) == 3 || int.Parse(txtValorSaque.Text) == 1 || int.Parse(txtValorSaque.Text) == 0)
            {
                MessageBox.Show("Não são aceitos valores de R$3,00, R$1,00 ou R$0,00", "Aviso");
            }
            else if (rbtnMenor.Checked == true)
            {
                CalculaMenor();
                MessageBox.Show("\n R$ 100,00: " + Cont100
                                + "\n R$ 50,00: " + Cont50
                                + "\n R$ 20,00: " + Cont20
                                + "\n R$ 10,00: " + Cont10
                                + "\n R$ 5,00: " + (Cont5 + Cont)
                                + "\n R$ 2,00: " + Cont2, "\n Menor variedade de Notas \n");
            }
            else if (rbtnMaior.Checked == true)
            {
                CalculaMaior();
                MessageBox.Show("\n R$ 100,00: " + Cont100
                                + "\n R$ 50,00: " + Cont50
                                + "\n R$ 20,00: " + Cont20
                                + "\n R$ 10,00: " + Cont10
                                + "\n R$ 5,00: " + (Cont5 + Cont)
                                + "\n R$ 2,00: " + Cont2, "\n Maior variedade de Notas \n");

            }
            else
            {
                MessageBox.Show("Erro não selecionou nenhuma Opição!", "Aviso");
            }

        }
        private void somenteNumero(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)(Keys.Back))
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
            }

        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            DialogResult Sair = MessageBox.Show("Você deseja sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Sair.ToString() == "Yes")
            {
                Application.Exit();
            }
        }
        private void Limpar()
        {
            txtValorSaque.Clear();
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            if

             (MessageBox.Show(("Deseja limpar o Campo?"), "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
             == DialogResult.OK)
            {
                Limpar();
                txtValorSaque.Focus();
            }
        }
    }
}
