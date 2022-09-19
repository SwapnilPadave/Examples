using System;

namespace Ex34_ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 0;
            //for(int i = 0; i < 100; i--)
            //{
            //    x = i++;
            //    Console.WriteLine(x);
            //}

            int x = 0;
            for(int i = 0; i < 100; i++)
            {
                x += i++;
                Console.WriteLine(x);
            }
        }
    }
}
