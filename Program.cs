using System;
using System.Threading;

namespace F1M3cs
{
    class Program
    {

        static void Main(String[] args)
        {
            Console.ForegroundColor
                = ConsoleColor.Green;

            string text = "Hello World";
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(600);
            }
        }
    }
}
