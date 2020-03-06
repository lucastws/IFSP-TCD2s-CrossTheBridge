using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCD
{
    public partial class frmDados : Form
    {
        public frmDados()
        {
            InitializeComponent();

            carregarRecursos();
        }

        // # Variáveis globais e públicas.
        public int tempo_maximo = 0;
        public int tempo_gasto = 0;

        // - Tempos de cada Beatle.
        public int[] tempos = new int[4];


        // @ Função para carregar e definir recursos.
        private void carregarRecursos()
        {
            this.BackColor = Color.LightGray;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            txtTTotal.MaxLength = 2;
            txtTTotal.Text = "17";
            txtT1.MaxLength = 2;
            txtT1.Text = "1";
            txtT2.MaxLength = 2;
            txtT2.Text = "2";
            txtT3.MaxLength = 2;
            txtT3.Text = "4";
            txtT4.MaxLength = 2;
            txtT4.Text = "10";

            lblRegras.BackColor = Color.Gray;
            lblRegras.Text = " \nDADOS:" 
            + "\n  - Tempos distintos para cada integrante;"
            + "\n  - Tempo máximo maior ou igual ao mínimo possível calculado.\n\n"
            + "COMO JOGAR/REGRAS:"
            + "\n  - O máximo de Beatles por atravessia é 2;"
            + "\n  - Ao atravessar, um Beatle precisa voltar com a lanterna para\noutro poder cruzar a ponte também;"
            + "\n  - Ao atravessar, somente o maior tempo é considerado.\n ";

            lblInfo.Text = " \nINFO:"
            + "\n  Os Beatles possuem um show marcado às 21 horas e estão atrasados por conta de uma ponte!"
            + "\n  Eles irão fazer a abertura do concerto, portanto, é fundamental que apareçam."
            + "\n  Seu trabalho é, através do tempo máximo estipulado, fazê-los atravessar a ponte da maneira correta"
            + "\npara que cheguem dentro do tempo limite!";

            txtT1.Select();
        }

        // @ Função para alternar entre ativar/desativar os TextBox e o botão do form.
        public void switchFormDados()
        {
            if (btnIniciar.Enabled == true)
            {
                btnIniciar.Enabled = false;

                txtTTotal.Enabled = false;
                txtT1.Enabled = false;
                txtT2.Enabled = false;
                txtT3.Enabled = false;
                txtT4.Enabled = false;
            }
            else
            {
                btnIniciar.Enabled = true;

                txtTTotal.Enabled = true;
                txtT1.Enabled = true;
                txtT2.Enabled = true;
                txtT3.Enabled = true;
                txtT4.Enabled = true;
            }
        }

        // @ Função para retornar o tempo minimo permitido na inserção de dados.
        public int retornarTempoMin(int t1, int t2, int t3, int t4)
        {
            int[] tempos = { t1, t2, t3, t4 };
            int calculo1 = 0, calculo2 = 0, menor = 0, soma = 0;

            for (int i = 0; i < 4; i++)
            {
                soma += tempos[i];

                if (i == 0) menor = tempos[i];
                else if (menor > tempos[i]) menor = tempos[i];
            }

            calculo1 = (3 * t2) + t1 + t4;
            calculo2 = soma + menor;

            if (calculo2 <= calculo1) return calculo2;

            return calculo1;
        }

        // @ Função para checar se o tempo especificado está até o minimo possível calculado.
        public bool checarTempo(int tempo_maximo, int t1, int t2, int t3, int t4)
        {
            int[] tempos = { t1, t2, t3, t4 };

            int menor = 0, soma = 0;

            for (int i = 0; i < 4; i++)
            {
                soma += tempos[i];

                if (i == 0) menor = tempos[i];
                else if (menor > tempos[i]) menor = tempos[i];
            }

            if ((3 * t2) + t1 + t4 <= tempo_maximo || soma + menor <= tempo_maximo) return true;

            return false;
        }

        // @ Evento de formatação para os campos dos tempos.
        private void formatarTempos(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)(Keys.Back)) e.Handled = false;
            else e.Handled = true;
        }

        // @ Botão de iniciar jogo, tratado com try e catch.
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                tempo_maximo = int.Parse(txtTTotal.Text);
                tempos[0] = int.Parse(txtT1.Text);
                tempos[1] = int.Parse(txtT2.Text);
                tempos[2] = int.Parse(txtT3.Text);
                tempos[3] = int.Parse(txtT4.Text);

                bool tempos_iguais = false;

                for (int x = 0; x < 4; x++) for (int y = 0; y != x && y < 4; y++) if (tempos[x] == tempos[y]) tempos_iguais = true;

                if (tempos_iguais == false)
                {
                    if (checarTempo(tempo_maximo, tempos[0], tempos[1], tempos[2], tempos[3]) == true)
                    {
                        tempo_gasto = 0;

                        switchFormDados();

                        frmJogo frm2 = new frmJogo(this);

                        frm2.Show();
                    }
                    else
                    {
                        MessageBox.Show("Impossível iniciar o jogo com os tempos inseridos!\n\nTempo mínimo calculado para os tempos escolhidos: " + retornarTempoMin(tempos[0], tempos[1], tempos[2], tempos[3]), "ERRO!");

                        txtTTotal.Text = "" + retornarTempoMin(tempos[0], tempos[1], tempos[2], tempos[3]);
                    }
                }
                else MessageBox.Show("Os tempos não podem repetir!", "ERRO!");

            }
            catch
            {
                MessageBox.Show("Digite números de 0 à 99!", "ERRO!");
            }
            
        }
    }
}
