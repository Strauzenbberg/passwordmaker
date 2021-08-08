using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Conversoes
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Exacutando projeto 4 - Converções");

            double salario = 1200.50;
            Console.WriteLine(salario);

            //tipo de variavel suporta ate 32 bits
            int salarioEmInteiro = (int)salario;
            Console.WriteLine(salarioEmInteiro);


            //variavel de 64 bits
            long idade = 26;
            Console.WriteLine(idade);

            //variavel de 16 bits
            short quantidadeProdutos = 14000;
            Console.WriteLine(quantidadeProdutos);

            float altura = 1.80f;
            Console.WriteLine(altura);


            Console.WriteLine("Tecle Enter para sair....");
            Console.ReadLine();
        }
    }
}
