using System;

namespace Ex8_Abstraction
{
    abstract class Animal
    {
        public abstract void animalSound();
        public void Sleep()
        {
            Console.WriteLine("The Animal Is Sleeping");
        }
    }
    class Cat : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("Cat Is sleeping On Tree..");
        }
        
    }
    class Dog : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("Dog is Sleeping..");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat c = new Cat();
            c.animalSound();
            c.Sleep();

            Dog d = new Dog();
            d.animalSound();
            d.Sleep();
        }
    }
}
