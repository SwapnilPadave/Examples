using System;

namespace Ex11_TryCatchException
{
    class Program
    {   

        static void Main(string[] args)
        {
            try
            {
                int a = 10;
                int b = 0;
                int result = a / b;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Can Not Devide By 0", ex.Message);
            }
            finally
            {
                Console.WriteLine("Rest Of The Code..");
            }

        }
    }
}
