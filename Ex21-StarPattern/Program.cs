using System;

namespace Ex21_StarPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int i, j,k,m;
            for (i = 1; i <= 5; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            for (i = 1; i <= 5; i++)
            {
                for (j = i; j <= 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            for (i = 1; i <= 5; i++)
            {
                for (j = i; j <= 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (i = 2; i <= 5; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            for (i = 1; i <= 5; i++)
            {
                for (j = i; j <= 4; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            for (i = 1; i <= 5; i++)
            {
                for (j = 2; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (k = i; k <= 5; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            for (i = 1; i <= 5; i++)
            {
                for (j = 2; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (k = i; k <= 5; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }           

            for (i = 2; i <= 5; i++)
            {
                for (j = i; j <= 4; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
