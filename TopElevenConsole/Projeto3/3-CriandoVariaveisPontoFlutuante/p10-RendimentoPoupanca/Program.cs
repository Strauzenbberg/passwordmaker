using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p10_RendimentoPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10 - Calcula poupança");

            double valorInvestido = 1000;
            double taxa = 0.0020;
            int contadorMes = 1;


            while (contadorMes <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * taxa;

                Console.WriteLine("Apos " + contadorMes + " meses, você terá R$ " + valorInvestido);

                // contadorMes = contadorMes + 1;
                // contadorMes += 1;
                contadorMes++;
            }

            //0.20% = 0.0020
            

            Console.ReadLine();
        }
    }
}
