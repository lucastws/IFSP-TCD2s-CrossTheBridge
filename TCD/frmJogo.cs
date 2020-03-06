using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace TCD
{
    public partial class frmJogo : Form
    {
        frmDados instanciaDoForm1;

        public frmJogo(frmDados frm1)
        {
            InitializeComponent();

            instanciaDoForm1 = frm1;

            carregarRecursos();
        }

        // # Variáveis globais e privadas.
        private int pictureSelecionada = -1;

        private bool pictureVoltou = true;

        // - Declaração da array de PictureBox dos Beatles.
        private PictureBox[] picturesIda = new PictureBox[4];
        private PictureBox[] picturesVolta = new PictureBox[4];

        // - Declaração da array de PictureBox das lanternas.
        private PictureBox[] picturesLanterna = new PictureBox[8];

        // - Declaração das músicas para tocarem ao fim do jogo.
        private SoundPlayer audio1 = new SoundPlayer(TCD.Properties.Resources.yesterday);
        private SoundPlayer audio2 = new SoundPlayer(TCD.Properties.Resources.in_the_end);


        // @ Método para carregar e atribuir os recursos.
        private void carregarRecursos()
        {
            this.BackColor = Color.Black;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.FormClosing += frmJogo_FormClosing;

            picturesLanterna[0] = pctLanternaTI1;
            picturesLanterna[1] = pctLanternaTI2;
            picturesLanterna[2] = pctLanternaTI3;
            picturesLanterna[3] = pctLanternaTI4;
            picturesLanterna[4] = pctLanternaTV1;
            picturesLanterna[5] = pctLanternaTV2;
            picturesLanterna[6] = pctLanternaTV3;
            picturesLanterna[7] = pctLanternaTV4;

            picturesIda[0] = pctTI1;
            picturesIda[1] = pctTI2;
            picturesIda[2] = pctTI3;
            picturesIda[3] = pctTI4;

            picturesVolta[0] = pctTV1;
            picturesVolta[1] = pctTV2;
            picturesVolta[2] = pctTV3;
            picturesVolta[3] = pctTV4;

            // - Loop para esconder as imagens do lado da volta (inicio do jogo).
            for (int x = 0; x < 4; x++)
            {
                picturesLanterna[x].Enabled = false;
                picturesLanterna[x].Visible = false;

                picturesLanterna[x+4].Enabled = false;
                picturesLanterna[x+4].Visible = false;

                picturesVolta[x].Enabled = false;
                picturesVolta[x].Visible = false;

                picturesVolta[x].BackColor = Color.Gray;
                picturesIda[x].BackColor = Color.Gray;
            }

            lblTempoLimite.Text = "" + instanciaDoForm1.tempo_maximo;
            lblTempoAtual.Text = "" + instanciaDoForm1.tempo_gasto;

            lblTempoAtual.ForeColor = Color.White;
            lblTempoLimite.ForeColor = Color.White;
            lblTempoMax.ForeColor = Color.White;
            lblTempoGasto.ForeColor = Color.White;
            lblVolta.ForeColor = Color.White;
            lblIda.ForeColor = Color.White;
        }

        // @ Função para tocar uma das músicas declaradas anteriormente.
        private void tocarMusica(SoundPlayer audio) 
        {
            audio.Play();
        }

        // @ Função para parar a música.
        private void pararMusica()
        {
            audio1.Stop();
            audio2.Stop();
        }

        // @ Função para checar e retornar se o jogo foi finalizado.
        private bool checarFimDeJogo()
        {
            for (int x = 0; x < 4; x++) if (picturesVolta[x].Enabled == false && picturesVolta[x].Visible == false) return false;

            return true;
        }

        // @ Função para trocar a lanterna de lado após a passagem do Beatle.
        private void trocarLanterna(int indice)
        {
            if (picturesLanterna[indice].Enabled == true && picturesLanterna[indice].Visible == true) 
            {
                for (int x = 0; x < 4; x++)
                {
                    picturesLanterna[x].Visible = false;

                    picturesLanterna[x].Enabled = false;
                }

                picturesLanterna[indice].Enabled = false;
                picturesLanterna[indice].Visible = false;

                picturesLanterna[indice + 4].Enabled = true;
                picturesLanterna[indice + 4].Visible = true;
            }
            else
            {
                for (int x = 4; x < 8; x++)
                {
                    picturesLanterna[x].Visible = false;
                    picturesLanterna[x].Enabled = false;
                }

                picturesLanterna[indice].Enabled = true;
                picturesLanterna[indice].Visible = true;

                picturesLanterna[indice + 4].Enabled = false;
                picturesLanterna[indice + 4].Visible = false;
            }
        }

        // @ Função para trocar o Beatle de lado da ponte.
        private void trocarPicture(int indice)
        {
            if (picturesIda[indice].Enabled == true && picturesIda[indice].Visible == true)
            {
                picturesIda[indice].Enabled = false;
                picturesIda[indice].Visible = false;

                picturesVolta[indice].Enabled = true;
                picturesVolta[indice].Visible = true;
            }
            else if (picturesVolta[indice].Enabled == true && picturesVolta[indice].Visible == true)
            {
                picturesVolta[indice].Enabled = false;
                picturesVolta[indice].Visible = false;

                picturesIda[indice].Enabled = true;
                picturesIda[indice].Visible = true;
            }
        }

        // @ Evento chamado ao clicar em um dos 4 Beatles do lado esquerdo (ida).
        private void pctIda_Click(object sender, EventArgs e)
        {
            if (pictureVoltou == true)
            {
                for (int x = 0; x < 4; x++)
                {
                    if (pictureSelecionada == -1)
                    {
                        if (sender as PictureBox == picturesIda[x])
                        {
                            for (int y = 0; y < 4; y++)
                            {
                                picturesLanterna[y].Visible = false;
                                picturesLanterna[y].Enabled = false;
                            }

                            picturesLanterna[x].Visible = true;
                            picturesLanterna[x].Enabled = true;

                            pictureSelecionada = x;

                            picturesIda[x].BackColor = Color.Red;
                        }
                    }
                    else
                    {
                        if (sender as PictureBox == picturesIda[x] && pictureSelecionada == x)
                        {
                            pictureVoltou = false;

                            trocarPicture(x);

                            trocarLanterna(x);

                            picturesIda[pictureSelecionada].BackColor = Color.Gray;

                            instanciaDoForm1.tempo_gasto += instanciaDoForm1.tempos[x];

                            lblTempoAtual.Text = "" + instanciaDoForm1.tempo_gasto;

                            pictureSelecionada = -1;

                        }

                        else if (sender as PictureBox == picturesIda[x] && pictureSelecionada != x)
                        {
                            pictureVoltou = false;

                            trocarPicture(x);
                            trocarPicture(pictureSelecionada);

                            trocarLanterna(pictureSelecionada);

                            picturesIda[pictureSelecionada].BackColor = Color.Gray;

                            if (instanciaDoForm1.tempos[x] >= instanciaDoForm1.tempos[pictureSelecionada]) instanciaDoForm1.tempo_gasto += instanciaDoForm1.tempos[x];
                            else instanciaDoForm1.tempo_gasto += instanciaDoForm1.tempos[pictureSelecionada];

                            lblTempoAtual.Text = "" + instanciaDoForm1.tempo_gasto;

                            pictureSelecionada = -1;

                        }
                    }
                }
            }

            // - Checagem de fim de jogo e exibição de vitória/derrota após passar o ultimo Beatle.
            if (checarFimDeJogo() == true && instanciaDoForm1.tempo_gasto <= instanciaDoForm1.tempo_maximo)
            {
                pctBackground.Image = Properties.Resources.beatles_gif;

                tocarMusica(audio1);

                if((instanciaDoForm1.tempo_maximo - instanciaDoForm1.tempo_gasto) == 0) MessageBox.Show("VOCÊ CHEGOU A TEMPO! Em cima da hora!\n\nGraças à você os Beatles conseguiram realizar a abertura do show!", "Parabéns!");
                else if ((instanciaDoForm1.tempo_maximo - instanciaDoForm1.tempo_gasto) > 0) MessageBox.Show("VOCÊ CHEGOU A TEMPO! Com " + (instanciaDoForm1.tempo_maximo - instanciaDoForm1.tempo_gasto) + " minuto(s) de antecedência!\n\nGraças à você os Beatles conseguiram realizar a abertura do show!", "Parabéns!");

                pararMusica();

                instanciaDoForm1.switchFormDados();

                this.Hide();
            }
            else if (checarFimDeJogo() == true && instanciaDoForm1.tempo_gasto > instanciaDoForm1.tempo_maximo)
            {
                pctBackground.Image = Properties.Resources.lp_gif;

                tocarMusica(audio2);

                MessageBox.Show("Você PERDEU o show! Atrasou " + (instanciaDoForm1.tempo_gasto - instanciaDoForm1.tempo_maximo) + " minuto(s)!\n\nPortanto, o Linkin Park substituiu os Beatles na abertura do show!", "Que pena!");

                pararMusica();

                instanciaDoForm1.switchFormDados();

                this.Hide();
            }
        }


        // @ Evento chamado ao clicar em um dos 4 Beatles do lado direito (volta).
        private void pctVolta_Click(object sender, EventArgs e)
        {
            if(pictureVoltou == false)
            {
                for (int x = 0; x < 4; x++)
                {
                    if (sender as PictureBox == picturesVolta[x])
                    {
                        pictureVoltou = true;

                        trocarPicture(x);

                        trocarLanterna(x);

                        instanciaDoForm1.tempo_gasto += instanciaDoForm1.tempos[x];

                        lblTempoAtual.Text = "" + instanciaDoForm1.tempo_gasto;
                    }
                }
            }
        }

        // @ Liberar o reinicio do jogo caso o mesmo seja fechado através do "X".
        private void frmJogo_FormClosing(object sender, FormClosingEventArgs e)
        {
            instanciaDoForm1.switchFormDados();
        }

    }
}
