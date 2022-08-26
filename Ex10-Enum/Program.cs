using System;

namespace Ex10_Enum
{

    class Program
    {
        public enum Month
        {
            Jan=10,
            Feb,
            Marc,
            Apri,
            May,
            June,
            Jully,
            Aug,
            Sept,
            Oct,
            Nov,
            Dec
        };

        static void Main(string[] args)
        {
            //For Getting The Names From enum
            string[] values = Enum.GetNames(typeof(Month));
            foreach (string s in values)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            //For Getting The Values Of the enum
            int[] n = (int[])Enum.GetValues(typeof(Month));
            foreach (int x in n)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();
        }
    }
}

    

