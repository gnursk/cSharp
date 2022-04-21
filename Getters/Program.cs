using System;

namespace Getters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.SetAge(5);
            Console.WriteLine("Dog age is " + dog.Age);
        }


    }

    internal class Dog
    {
        internal int Age;

        internal void SetAge(int age)
        {
            Age = age;
        }


    }
}