using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            int idadeJoao = 16;
            int quantidadePessoas = 2;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("João possui mais de 18 anos");
            }
            else
            {

                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("João ñão possui mais de 18 anos, mas está acompanhado");
                }


                else
                {
                    Console.WriteLine("João ñão possui mais de 18 anos");
                }
            }

            Console.ReadLine();
        }
    }
}
