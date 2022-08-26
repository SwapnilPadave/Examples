using System;

namespace Ex19_BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 11;// Declare Value To the variable
            object b = a;// Boxing (Value type to Reference Type)
            b = (int)a;// Unboxing (Reference Type To Value Type) Here (int) is A typeof the variable 
            Console.WriteLine(b);
        }
    }
}
