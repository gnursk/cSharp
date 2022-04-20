using System;
using Hond;

namespace Getters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kat Paard = new Kat();
            Paard.Dieren();
        }
    }

}
namespace Hond
{
    public class Kat
    {
        public void Dieren()
        {
            string Cavia = "Dieren zijn interesant";
            Console.WriteLine(Cavia);
        }
    }
}