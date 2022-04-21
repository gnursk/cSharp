using System;
using Name1;
namespace Name
{
    class henk
    {
        static void Main(string[] args)
        {
            Car car;

            car = new Car("Red");
            Console.WriteLine(car.Describe());

            car = new Car("Green");
            Console.WriteLine(car.Describe());

            Console.ReadLine();

        }
    }
}