using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercicio001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetCursorPosition(50, 10); //Posiciona as palavras na tela do programa

            //Primeira Palavra

            Thread.Sleep(1000);
            Console.BackgroundColor = ConsoleColor.Blue; //Fundo azul
            Console.ForegroundColor = ConsoleColor.White; //Letra branca
            Console.Write("  Meu  ");
            Console.ResetColor(); //Reseta só para a primeira palavra
            Thread.Sleep(1000);

            //Segunda parte
            Thread.Sleep(1000);
            Console.BackgroundColor = ConsoleColor.Yellow; //Fundo amarelo
            Console.ForegroundColor = ConsoleColor.Green; //Letra verde
            Console.Write("  Brasil  ");
            Console.ResetColor();
            Thread.Sleep(1000);

            //terceira parte
            Thread.Sleep(1000);
            Console.BackgroundColor = ConsoleColor.Green; //Fundo 
            Console.ForegroundColor = ConsoleColor.Yellow; //Letra 
            Console.WriteLine("  Brasileiro  ");
            Console.ResetColor();
            Thread.Sleep(1000);

            Console.ReadKey();
        }
    }
}
