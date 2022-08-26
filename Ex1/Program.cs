using System;

namespace Ex1
{
    public static class c1
    {
        public static string Name = "Swapnil";
        public static int Age = 28;
        public static double salary = 10000.50;
        public static void Details()
        {
            Console.WriteLine("Details Of Student...");
        }
    }   
    public class Program 
    {    
        static void Main(string[] args)
        {
            c1.Details();
            Console.WriteLine("Name Of Student :{0}", c1.Name);
            Console.WriteLine("Age Is :{0}", c1.Age);
            Console.WriteLine("Salary Is :{0}", c1.salary);
        }
    }
}
