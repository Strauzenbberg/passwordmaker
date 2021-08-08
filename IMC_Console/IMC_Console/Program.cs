using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC_Console
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Console IMC Calculator in C#\r");
            Console.WriteLine("------------------------\n");

            Console.WriteLine("Digite seu peso, e pressione Enter");
            double peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");

            // Ask the user to type the second number.
            Console.WriteLine("Digite sua altura, e pressione Enter\n");
            double altura = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("");

            double imc = peso / (altura * altura);
            Console.WriteLine("");

            //Console.WriteLine("IMC ");
            Console.WriteLine($"IMC: {imc:N}");
            Console.WriteLine("");
            //Console.WriteLine($"Measurement: {measurement:N4} units");


            if (imc < 18.5)
            {
                Console.WriteLine("Abaixo do peso");
                
            }
            //else
            //{
            //   Console.WriteLine("");
            //}
            if (imc >= 18.5 && imc < 24.9)
            {
                Console.WriteLine("Peso ideal. PARABÉNS!");
            }
            //else
            //{
            //    Console.WriteLine("");
            //}
            if (imc >= 25 && imc < 29.9)
            {
                Console.WriteLine("Levemente acima do peso");
            }

            if (imc >= 30 && imc < 34.9)
            {
                Console.WriteLine("Obesidade Grau 1");
            }
            if (imc >= 35 && imc < 39.9)
            {
                Console.WriteLine("Obesidade Grau 2 (Severa)");
            }
            if (imc > 40)
            {
                //imc > 40
                Console.WriteLine("Obesidade Grau 3 (Mórbida)");
            }

         

            Console.ReadLine();
        }
    }
}
