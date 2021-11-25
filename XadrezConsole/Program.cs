using System;
using Table;
using Xadrez;

namespace XadrezConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ChessMatch match = new ChessMatch();
                while (!match.isFinished)
                {
                    Console.Clear();
                    Screen.printTable(match.tab);

                    Console.WriteLine();
                    Console.Write("Origem:");
                    Position originPosition = Screen.readXadrezPosition().toPositition();
                    Console.Write("Destiny:");
                    Position destinyOrigin = Screen.readXadrezPosition().toPositition();


                    match.performMoviment(originPosition, destinyOrigin);
                }
            }
            catch (ExceptionTable e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
