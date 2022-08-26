using System;

namespace Ex22_PyramidPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k, l;
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
                for (l = 2; l <= i; l++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            //---------------------------------------//
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
                for (l = i; l <= 4; l++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            //----------------------------//
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
                for (l = i; l <= 4; l++)
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
                for (l = 2; l <= i; l++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            //-----------------------------//

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
                for (l = 2; l <= i; l++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (i = 2; i <= 5; i++)
            {
                for (j = 2; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (k = i; k <= 5; k++)
                {
                    Console.Write("*");
                }
                for (l = i; l <= 4; l++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
