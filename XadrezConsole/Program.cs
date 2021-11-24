using System;
using Table;
using xadrez;

namespace XadrezConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Position P;

            P = new Position(3,5);
            Console.WriteLine("Position : " + P);

            table tab = new table(8, 8);
            tab.insertBoardPiece(new Tower(tab, Color.Black), new Position(0, 0));
            tab.insertBoardPiece(new Tower(tab, Color.Black), new Position(1, 3));
            tab.insertBoardPiece(new King(tab, Color.Black), new Position(4, 3));
            Screen.printTable(tab);

        }
    }
}
