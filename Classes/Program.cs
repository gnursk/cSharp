using System;

namespace Classes
{
    class Rekenmachine
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            a = Som(a, b);
            Console.WriteLine(a);

            int d = 10;
            int e = 6;

            d = Som2(d, e);
            Console.WriteLine(d);
        }
        private static int Som(int a, int b)
        {
            int c = a + b;
            return c;
        }
        private static int Som2(int d, int e)
        {
            int f = d * e;
            return f;
        }

    }
}
