using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3 - Criando Variaveis ponto flutuante");

            double salario;
            salario = 14 / 3;
            Console.WriteLine("Seu salário é " + salario + "!");

            
            salario = 14.0 / 3;
            Console.WriteLine("Seu salário é " + salario + "!");


            Console.WriteLine("Execução finalizada. Tecle Enter para sair....");
            Console.ReadLine();
        }
    }
}
