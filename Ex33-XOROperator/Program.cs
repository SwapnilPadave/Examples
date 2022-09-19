using System;

namespace Ex33_XOROperator
{
    class Program
    {      
        static void Main(string[] args)
        {
            bool fno = true;
            bool sno = false;
            bool tno = true;
            bool fono = false;

            bool result=fno^sno^tno^fono;

            Console.WriteLine("{0}^{1}^{2}^{3} ={4}", fno, sno, tno, fono, result);

        }
    }
}
