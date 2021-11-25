using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Table;
using Xadrez;

namespace XadrezConsole
{
    class Screen
    {

        public static void printTable(table tab)
        {
            for (int i = 0; i < tab.lines; i++)
            {
                Console.Write(8 - i + " ");

                for (int j = 0; j < tab.columns; j++)
                {
                    if(tab.boardPiece(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        printBoardPiece(tab.boardPiece(i,j));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }
        public static void printBoardPiece(BoardPiece boardPiece)
        {
            if(boardPiece.color == Color.White)
            {
                Console.Write(boardPiece);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(boardPiece);
                Console.ForegroundColor = aux;
            }
        }
        public static XadrezPosition readXadrezPosition()
        {
            string s = Console.ReadLine();
            char column = s[0];
            int line = int.Parse(s[1] + "");
            return new XadrezPosition(column, line);

        }
    }
}
