using System;
using Table;


namespace XadrezConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Position P;

            P = new Position(3,5);
            Console.WriteLine("Position : " + P);

            tableOne table = new tableOne(8, 8);

        }
    }
}
