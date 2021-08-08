using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Globalization;

namespace TopElevenForWindows
{
    public partial class frmPrincipal : Form
    {
        int energiaMinima = 0;
        int horaAtual = 0;
        int tempo = 0;
        int ganho = 0;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                //Armazenamento e conversão da hora atual em formato Int para possibilitar
                //calculos posteriores
                var horaAtual = DateTime.Now.Hour;
                Convert.ToInt32(horaAtual);

                //Título
                //Console.WriteLine("TOP ELEVEN TIMER \r");
                //Console.WriteLine("----------------\n");


                //Um prompt para perguntar ao usuário a hora do jogo 
                //mskTextHoraDoJogo.Text = horaDoJogo();
                //horaDoJogo = 
                //int horaDoJogo = 0;

                int horaDoJogo = int.Parse(mskTextHoraDoJogo.Text, CultureInfo.InvariantCulture);
                Convert.ToInt32(horaDoJogo);
                //Console.WriteLine("Digite a hora do jogo, sem os minutos, no formato 24 e pressione Enter:\n");
                //int horaDoJogo = Convert.ToInt32(mskTextHoraDoJogo.Text);

                //Declaração de uma variável
                int tempoAtejogo;

                //Calculo de horas até o jogo


                if (horaAtual >= horaDoJogo)
                {
                    int fator = horaAtual - horaDoJogo;
                    tempoAtejogo = 24 - fator;

                }
                else
                {
                    tempoAtejogo = horaDoJogo - horaAtual;
                }
                if (tempoAtejogo < 3)
                {
                    tempoAtejogo = 0;

                }



                //Ponto central do programa. Cálculo da energia final.
                int energiaMinima = 100 - ((((tempoAtejogo - 1) / 3) * 6));
                //Console.WriteLine("");


                // Console.WriteLine($"Energia Mínima: {energiaMinima}%\n");

                //Console.WriteLine($"Hora atual: {horaAtual}\n");

                //Console.WriteLine($"Tempo até o jogo: {tempoAtejogo} horas\n");

                int ganho = ((((tempoAtejogo - 1) / 3) * 6));
                //Console.WriteLine($"Ganho de energia até o jogo: {ganho}%\n");

                lblEnergiaShow.Text = energiaMinima.ToString("##");
                lblAtualShow.Text = horaAtual.ToString("##");
                lblTempoShow.Text = tempoAtejogo.ToString("##");
                lblGanhoShow.Text = ganho.ToString("##");
                btnLimpar.Focus();

                //Console.ReadLine();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void mskTextHoraDoJogo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskTextHoraDoJogo_Click(object sender, EventArgs e)
        {
            mskTextHoraDoJogo.Text = "";
            lblEnergiaShow.Text = " ";
            lblAtualShow.Text = " ";
            lblTempoShow.Text = " ";
            lblGanhoShow.Text = " ";
            mskTextHoraDoJogo.Focus();
        }

        private void mskTextHoraDoJogo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)

            {
                btnCalcular.PerformClick();
            }
            
            //if (int.Parse(mskTextHoraDoJogo.Text) <= 0)




        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            mskTextHoraDoJogo.Text = "";
            lblEnergiaShow.Text = "";
            lblAtualShow.Text = "";
            lblTempoShow.Text = "";
            lblGanhoShow.Text = "";
            mskTextHoraDoJogo.Focus();
        }

        private void btnCalcular_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnLimpar_KeyDown(object sender, KeyEventArgs e)
        {


        }

        private void frmPrincipal_KeyUp(object sender, KeyEventArgs e)
        {


        }

        private void frmPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                mskTextHoraDoJogo.Text = "";
                lblEnergiaShow.Text = "";
                lblAtualShow.Text = "";
                lblTempoShow.Text = "";
                lblGanhoShow.Text = "";
                mskTextHoraDoJogo.Focus();
            }



        }

        private void mskTextHoraDoJogo_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
    

