using System;

namespace Ex6_Inheriatance
{
    public class Animal
    {
        
        public void Eat()
        {
            Console.WriteLine("The Animal Is Eating...");
        }
        
    }
    public class Bird :Animal
    {
        public void Flying()
        {
            Console.WriteLine("The Bird Is Flying...");
        }
      
    }
    public class Dog : Animal
    {
       
        public void Barking()
        {
            Console.WriteLine("The Dog Is Barking");
        }
       
      
    }
    public  class BabyDog : Dog
    { 
        public  void Sleeping()
        {
            Console.WriteLine("The Baby Dog Is Sleeping...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Object Of Last Child Class

            BabyDog babyDog = new BabyDog();
            babyDog.Eat();
            babyDog.Barking();
            babyDog.Sleeping();          

            Bird bird = new Bird();
            bird.Eat();
            bird.Flying();
        }
    }
}
