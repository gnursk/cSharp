using System;
namespace Scopes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NewScope();
        }

        public static void NewScope()
        {
            int a = 3;
        }

    }
}