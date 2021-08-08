using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IMCforWindows


public static class SoulIMC
{
	public SoulIMC()
	{
        if (e.KeyChar == 13)
        {
            pes = double.Parse(Mask1_Peso.Text, CultureInfo.InvariantCulture);
            alt = double.Parse(Mask2_Altura.Text, CultureInfo.InvariantCulture);
            sum = (pes / (alt * alt));

            //Valor do IMC mostrado na tela
            Lbl_Diag.Text = sum.ToString("##.#");


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
            else
            //(sum > 40)
            {
                Lbl_Resultado.Text = "Obesidade Grau 3 (Mórbida)";
            }
        }
}
