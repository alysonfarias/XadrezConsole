using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Table;

namespace XadrezConsole
{
    class Screen
    {

        public static void printTable(table tab)
        {
            for (int i = 0; i < tab.lines; i++)
            {
                for (int j = 0; j < tab.columns; j++)
                {
                    if(tab.boardPiece(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tab.boardPiece(i,j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
