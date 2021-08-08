using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dice6
{
    public partial class frmPrincipal : Form
    {
        

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void btnRolar_Click(object sender, EventArgs e)
        {
            //3d6
            Random dice = new Random();
            int roll1 = dice.Next(1, 7);
            int roll2 = dice.Next(1, 7);
            int roll3 = dice.Next(1, 7);
            int total = roll1 + roll2 + roll3;

            label1.Text = roll1.ToString();
            label2.Text = roll2.ToString();
            label3.Text = roll3.ToString();
            lblResultado.Text = total.ToString();
           
        }
    }
}
