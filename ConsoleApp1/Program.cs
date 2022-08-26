using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
   
    class Program
    {
        static void Main(string[] args)
        {
            dynamic value1 = "GeeksforGeeks";
            dynamic value2 = 123234;
            dynamic value3 = 2132.55;
            dynamic value4 = false;
            
            Console.WriteLine("Get the actual type of value1: {0}",
                                      value1.GetType().ToString());

            Console.WriteLine("Get the actual type of value2: {0}",
                                      value2.GetType().ToString());

            Console.WriteLine("Get the actual type of value3: {0}",
                                      value3.GetType().ToString());

            Console.WriteLine("Get the actual type of value4: {0}",
                                      value4.GetType().ToString());
        }
    }
}
