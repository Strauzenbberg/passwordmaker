using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Globalization;

namespace TopElevenConsole
{
    class Program
    {
        static void Main(string[] args)


        {
            //Armazenamento e conversão da hora atual em formato Int para possibilitar
            //calculos posteriores
            var horaAtual = DateTime.Now.Hour;
            Convert.ToInt32(horaAtual);
           
            //Título
            Console.WriteLine("TOP ELEVEN TIMER \r");
            Console.WriteLine("----------------\n");


            //Um prompt para perguntar ao usuário a hora do jogo 
            Console.WriteLine("Digite a hora do jogo, sem os minutos, no formato 24 e pressione Enter:\n");
            int horaDoJogo = Convert.ToInt32(Console.ReadLine()); 
            
            //Declaração de uma variável
            int tempoAtejogo;
            
            //Calculo de horas até o jogo
            if (horaAtual >= horaDoJogo)
            {
                int fator = horaAtual - horaDoJogo;
                tempoAtejogo = 24 - fator;

            }
            else
            {
                tempoAtejogo = horaDoJogo - horaAtual;
            }
            if (tempoAtejogo < 3)
            {
                tempoAtejogo = 0;

            }

            //Ponto central do programa. Cálculo da energia final.
            int energiaMinima = 100 - ((((tempoAtejogo - 1) / 3) * 6));
            Console.WriteLine("");

            
            Console.WriteLine($"Energia Mínima: {energiaMinima}%\n");
            
            Console.WriteLine($"Hora atual: {horaAtual}\n");
            
            Console.WriteLine($"Tempo até o jogo: {tempoAtejogo} horas\n");
            
            int ganho = ((((tempoAtejogo - 1) / 3) * 6)) ;
            Console.WriteLine($"Ganho de energia até o jogo: {ganho}%\n");
           

            Console.ReadLine();
        }

    }
}
