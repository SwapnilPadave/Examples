using System;

namespace EncapsulationWithGetSet
{
    public class MyString
    {
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Name cannot be null.");
                }
            }
        }
        public int Age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var data = new MyString();

            data.Name = "Swapnil";
            data.Age = 31;

            Console.WriteLine($"Name : {data.Name}");
            Console.WriteLine($"Age : {data.Age}");
        }
    }
}
