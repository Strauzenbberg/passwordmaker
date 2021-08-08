using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Clipper
{
    public partial class frmMain : Form
    {
        int numx = 0;
        int chute = 0;
        int chance = 6;

        
        public frmMain()
        {
            InitializeComponent();
            

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //Pensando num  número
            Random dice = new Random();
            numx = dice.Next(1, 51);
            //lblDica.Text = numx.ToString();
            lblPergunta.Text = "Eu pensei em um número entre 1 e 50. Adivinhe qual.  Você tem " + chance + " chances.";

            chance--;
            /*
            if (String.IsNullOrEmpty(maskChute.Text))
            {
                lblTeste.Text = "Erro zero";
                btnGo.Enabled = false;
            }
            else if (!String.IsNullOrEmpty(maskChute.Text))
            {
                lblTeste.Text = "ok";
                btnGo.Enabled = true;
            }
            */

        }

        public void btnGo_Click(object sender, EventArgs e)
        {

            
            //chance = int.Parse(lblPergunta.Text, CultureInfo.InvariantCulture);
            lblPergunta.Text = "Eu pensei em um número entre 1 e 50. Adivinhe qual.  Você tem " + chance + " chances.";

            try
            {
                chute = int.Parse(maskChute.Text, CultureInfo.InvariantCulture);
                chance--;
                if (chance > -1)
                {

                    if (chute < numx)
                    {
                        lblDica.Text = "É Mais!";
                        //chance--;

                    }

                    else if (chute == numx)
                    {
                        lblDica.Text = "";
                        lblPergunta.Text = "Você acertou! O número que eu pensei foi " + numx + ".";
                        //maskChute.Visible = false;
                        //btnGo.Visible = false;
                        //maskChute.Enabled = false;
                        btnGo.Enabled = false;
                        maskChute.ReadOnly = true;

                    }

                    else if (chute > numx)
                    {
                        lblDica.Text = "É Menos!";
                        //chance--;

                    }

                    else
                    {
                        lblDica.Text = "Digite um palpite.";
                        //lblDica.Text = "Você perdeu! O número que pensei foi " + numx + ".";
                    }
                }



                else
                {
                    lblDica.Text = "";
                    lblPergunta.Text = "Você perdeu! O número que eu pensei foi " + numx + ".";
                    //maskChute.Visible = false;
                    //btnGo.Visible = false;
                    maskChute.Enabled = false;
                    btnGo.Enabled = false;
                }
                //maskChute.Text = "";

                maskChute.Focus();

                maskChute.SelectionStart = 0;
                maskChute.SelectionLength = maskChute.Text.Length;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            /*
            if (String.IsNullOrEmpty(maskChute.Text))
            {
                //return "is null or empty";
                btnGo.Enabled = false;
            }
            else
            {
                //return "ok";
                btnGo.Enabled = true;
            }
            */










        }

        private void maskChute_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnGo.PerformClick();
            }
        }
    }
}
