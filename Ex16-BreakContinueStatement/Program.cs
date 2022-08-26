using System;

namespace Ex16_BreakContinueStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Break Statement Is Below");
            for (i = 0; i <= 10; i++)
            {
                
                if (i == 5)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("continue Statement Is Below");
            int j;
            for (j = 0; j <= 10; j++)
            {

                if (j == 5)
                {
                    continue;
                }
                Console.WriteLine(j);
            }

        }
    }
}
