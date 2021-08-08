using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using SoulIMC;

namespace IMCforWindows
//namespace SoulIMC 

{

    public partial class Frm_Principal : Form
    {
        double pes = 0;
        double alt = 0;
        double sum = 0;



        public Frm_Principal()
        {
            InitializeComponent();
        }





        public void But_Calculator_Click(object sender, EventArgs e)

        {

            try
            {
                //double a = Double.IsNullOrEmpty(pes);
                //lblTeste.Text = a;

                pes = double.Parse(Mask1_Peso.Text, CultureInfo.InvariantCulture);
                alt = double.Parse(Mask2_Altura.Text, CultureInfo.InvariantCulture);
                sum = (pes / (alt * alt));

                //Valor do IMC mostrado na tela
                //Lbl_Diag.Text = Convert.ToString(sum);
                Lbl_Diag.Text = sum.ToString("##.#");

                if (pes + alt > 2)
                {
                    if (sum < 18.5)
                    {
                        Lbl_Resultado.Text = "Abaixo do peso";

                    }

                    else if (sum >= 18.5 && sum < 24.9)
                    {
                        Lbl_Resultado.Text = "Peso ideal. PARABÉNS!";
                        //Lbl_ResultIMC.Text = Convert.ToString(sum);
                        //Console.WriteLine("Peso ideal. PARABÉNS!");
                    }

                    else if (sum >= 25 && sum < 29.9)
                    {
                        Lbl_Resultado.Text = "Levemente acima do peso";
                    }

                    else if (sum >= 30 && sum < 34.9)
                    {
                        Lbl_Resultado.Text = "Obesidade Grau 1";
                    }
                    else if (sum >= 35 && sum < 39.9)
                    {
                        Lbl_Resultado.Text = "Obesidade Grau 2 (Severa)";
                    }
                    else if (sum >= 40)
                    //(sum > 40)
                    {
                        Lbl_Resultado.Text = "Obesidade Grau 3 (Mórbida)";
                    }
                    else
                    {
                        Lbl_Resultado.Text = "Preencha os campos";
                    }


                }
                else
                {
                    Lbl_Resultado.Text = "Preencha os campos";
                }
                But_Limpar.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Mask1_Peso.Focus();
            }
        }


            private void Frm_Principal_Load(object sender, EventArgs e)
            {

            }

            private void But_Limpar_Click(object sender, EventArgs e)
            {
                Mask1_Peso.Text = "";

                Mask2_Altura.Text = "";
                Lbl_Resultado.Text = "";

                Lbl_Diag.Text = "";

                Mask1_Peso.Focus();


            }

            private void But_Calculator_KeyDown(object sender, KeyEventArgs e)
            {


            }
                private void Mask2_Altura_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
                {



                }

                private void Mask2_Altura_KeyPress(object sender, KeyPressEventArgs e)
                {

                    //SoulIMC cx = new SoulIMC();

                    if (e.KeyChar == 13)
                    {
                        But_Calculator.PerformClick();
                    }

                    //Versão 3.0 corrigido crash do calculo com capos vazios
                }




                private void Mask1_Peso_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
                {

                }
                
            
        
    }
}
        
    
