using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Caracteres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 5 - Caracteres");

            //character 16 bits
            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            string título = "Alura " + 2020;
            Console.WriteLine(título);




            Console.WriteLine("Execução finalizada. Tecle Enter para sair....");
            Console.ReadLine();
        }
    }
}
