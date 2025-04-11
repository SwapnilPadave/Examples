using System;

namespace AbstractionUsingInterface
{
    public interface IAnimal
    {
        void Sleeping();
        void Eating();
    }

    public class Cat : IAnimal
    {
        public void Eating()
        {
            Console.WriteLine("Cat is eating.");
        }

        public void Sleeping()
        {
            Console.WriteLine("Cat is sleeping.");
        }
        public void Running()
        {
            Console.WriteLine("Cat is running.");
        }
    }

    public class Dog : IAnimal
    {
        public void Eating()
        {
            Console.WriteLine("Dog is eating.");
        }

        public void Sleeping()
        {
            Console.WriteLine("Dog is sleeping.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var cat = new Cat();
            cat.Eating();
            cat.Sleeping();
            cat.Running();

            var dog = new Dog();
            dog.Eating();
            dog.Sleeping();
        }
    }
}
