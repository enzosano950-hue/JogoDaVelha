using System;
using System.Linq;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private char jogadorAtual = 'X';
        private Button[] botoes;

        public Form1()
        {
            InitializeComponent();
            botoes = new Button[] { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
            AtualizarLabel();
        }

        private void btn1_Click(object sender, EventArgs e)

        {
            Button btn = (Button)sender;

            // Verifica se o botão já foi clicado
            if (btn.Text != "")
                return;

            btn.Text = jogadorAtual.ToString();
            btn.Enabled = false;

            // Verifica se há vencedor
            if (VerificarVencedor())
            {
                MessageBox.Show($" Jogador {jogadorAtual} venceu!", "Fim de jogo");
                DesabilitarBotoes();
                return;
            }

            // Verifica se deu empate
            if (botoes.All(b => b.Text != ""))
            {
                MessageBox.Show(" Empate!", "Fim de jogo");
                return;
            }

            // Alterna jogador
            jogadorAtual = (jogadorAtual == 'X') ? 'O' : 'X';
            AtualizarLabel();
        }

        private bool VerificarVencedor()
        {
            int[,] combinacoes = new int[,]
            {
                {0,1,2},
                {3,4,5},
                {6,7,8},
                {0,3,6},
                {1,4,7},
                {2,5,8},
                {0,4,8},
                {2,4,6}
            };

            for (int i = 0; i < combinacoes.GetLength(0); i++)
            {
                if (botoes[combinacoes[i, 0]].Text == jogadorAtual.ToString() &&
                    botoes[combinacoes[i, 1]].Text == jogadorAtual.ToString() &&
                    botoes[combinacoes[i, 2]].Text == jogadorAtual.ToString())
                {
                    return true;
                }
            }
            return false;
        }

        private void DesabilitarBotoes()
        {
            foreach (Button b in botoes)
                b.Enabled = false;
        }

        private void AtualizarLabel()
        {
            lblstatus.Text = $"Vez do jogador: {jogadorAtual}";
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            foreach (Button b in botoes)
            {
                b.Text = "";
                b.Enabled = true;
            }
            jogadorAtual = 'X';
            AtualizarLabel();
        }
    }
}



 

