using System;

namespace Function
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;

            a = Som(a, b);
            Console.WriteLine(a);
        }
        private static int Som(int a, int b)
        {
            int c = a + b;
            return c;

        }
    }
}

