using System;

namespace Ex32_Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tuple with one value
            var T1 = Tuple.Create("Swapnil");
            Console.WriteLine("T1 Element :-> " +T1.Item1);
            Console.WriteLine();

            //Tuple with three value
            var T2 = Tuple.Create("Swapnil Padave", 28, "09/01/1994");
            Console.WriteLine("T2 Element :-> " +T2.Item1);
            Console.WriteLine("T2 Element :-> " +T2.Item2);
            Console.WriteLine("T2 Element :-> " +T2.Item3);
            Console.WriteLine();

            //Tuple with 6 values
            var T3 = Tuple.Create("Swapnil Suhas Padave",28,"09/01/1994",75.80,55.85,8.9);
            Console.WriteLine("T3 Element :-> " +T3.Item1);
            Console.WriteLine("T3 Element :-> " +T3.Item2);
            Console.WriteLine("T3 Element :-> " +T3.Item3);
            Console.WriteLine("T3 Element :-> " +T3.Item4);
            Console.WriteLine("T3 Element :-> " +T3.Item5);
            Console.WriteLine("T3 Element :-> " +T3.Item6);
            Console.WriteLine();

            //Nested Tuple
            var T4 = Tuple.Create("Swapnil",28,75.80,55.85,8.9, "09/01/1994","Lalbaug",Tuple.Create(11,12,13,14,15,16,17));
            Console.WriteLine("T4 Element :-> " +T4.Item1);
            Console.WriteLine("T4 Element :-> " +T4.Item2);
            Console.WriteLine("T4 Element :-> " +T4.Item3);
            Console.WriteLine("T4 Element :-> " +T4.Item4);
            Console.WriteLine("T4 Element :-> " +T4.Item5);
            Console.WriteLine("T4 Element :-> " +T4.Item6);
            Console.WriteLine("T4 Element :-> " +T4.Item7);
            Console.WriteLine("T4 Element :-> " +T4.Rest);
            Console.WriteLine("T4 Element :-> " +T4.Rest.Item1.Item1);
            Console.WriteLine("T4 Element :-> " +T4.Rest.Item1.Item2);
            Console.WriteLine("T4 Element :-> " +T4.Rest.Item1.Item3);
            Console.WriteLine("T4 Element :-> " +T4.Rest.Item1.Item4);
            Console.WriteLine("T4 Element :-> " +T4.Rest.Item1.Item5);
            Console.WriteLine("T4 Element :-> " +T4.Rest.Item1.Item6);
            Console.WriteLine("T4 Element :-> " +T4.Rest.Item1.Item7);            
            Console.ReadLine();

        }
    }
}
