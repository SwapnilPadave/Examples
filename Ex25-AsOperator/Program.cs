using System;

namespace Ex25_AsOperator
{
    class Program
    {
        public class Car
        {
        }
        public class Bike
        {

        }
        class itisas
        {
            static void Main(string[] args)
            {
                object[] MyObjects = new object[5];
                MyObjects[0] = new Car();
                MyObjects[1] = new Bike();
                MyObjects[2] = "Car";
                MyObjects[3] = "Bike";
                MyObjects[4] = "Honda";
                for (int i = 0; i < 5; i++)
                {
                    string s = MyObjects[i] as string;
                    Console.Write($"Inspecting element: {MyObjects[i]}");
                    if (s == null)
                    { Console.Write(" ->> Incompatible type"); }
                    else
                    { Console.Write(" ->> Compatible type"); }
                    Console.WriteLine(", with string!");
                }
                Console.ReadKey(); ;
            }
        }
    }
}