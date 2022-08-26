using System;

namespace Ex18_AccessModifier
{
    //Public code is accessible for all classes
    //Privaten code is only accessible within the same class
    //protected code is accessible within the same class, or in a class that is inherited from that class.
    //internal code is only accessible within its own assembly, but not from another assembly.

    //You Can Try Using Access Modifiers By Your Own 
    class Animal
    {
        public void Run()
        {
            Console.WriteLine("Animal Is Running..");
        }
    }
    class Dog:Animal
    {
        public void Bark()
        {
            Console.WriteLine("The Dog Is Barking..");
        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            Dog obj = new Dog();
            obj.Run();
            obj.Bark();

        }
    }
}


