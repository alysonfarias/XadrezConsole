using System;
using Table;
using xadrez;

namespace XadrezConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Position P;

                P = new Position(3, 5);
                Console.WriteLine("Position : " + P);

                table tab = new table(8, 8);
                tab.insertBoardPiece(new Tower(tab, Color.Black), new Position(0, 0));
                tab.insertBoardPiece(new Tower(tab, Color.Black), new Position(1, 3));
                tab.insertBoardPiece(new King(tab, Color.Black), new Position(4, 9));
                Screen.printTable(tab);
            }
            catch (ExceptionTable e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}
