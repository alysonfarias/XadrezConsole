﻿using System;
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
                tab.insertBoardPiece(new Tower(tab, Color.White), new Position(0, 3));
                Screen.printTable(tab);
            }
            catch (ExceptionTable e)
            {
                Console.WriteLine(e.Message);
            }
            //XadrezPosition P;
            //P = new XadrezPosition('a', 1);
            //table tab = new table(8, 8);
            //Console.WriteLine("Position : " + P.toPositition());
            //Screen.printTable(tab);
        }
    }
}
