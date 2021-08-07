using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorDeSenhas
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        //Generate 16-digit random password and copy to clipboard
        
        private void button1_Click(object sender, EventArgs e)
        {
            int TamanhoDaSenha = 16;
            string validar = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789@#$%&*!";
            try
            {
                StringBuilder str = new StringBuilder(100);
                Random random = new Random();
                while (0 < TamanhoDaSenha--)
                {
                    str.Append(validar[random.Next(validar.Length)]);
                }

                txtVisor.Text = str.ToString();
                Clipboard.SetText(txtVisor.Text);
                lblCopiado.Text = "Senha copiada!";
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        //Show or hide password
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (txtVisor.UseSystemPasswordChar == true)
            {
                txtVisor.UseSystemPasswordChar = false;
            }
            else
            {
                txtVisor.UseSystemPasswordChar = true;
            }
        }
    }
}
