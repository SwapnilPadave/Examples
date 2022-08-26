using System;

namespace Ex31_NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> n = null;
            Console.WriteLine(n.GetValueOrDefault());

            int? n1 = null;
            Console.WriteLine(n1.GetValueOrDefault());

            int? n2 = 69;
            Console.WriteLine(n2.GetValueOrDefault());

            Nullable<int> n3 = 619;
            Console.WriteLine(n3.GetValueOrDefault());

            int? a = null;
            Console.WriteLine(a);

            Nullable<int> a1 = 619;
            Console.WriteLine(a1);

            Nullable<int> b = null;
            Console.WriteLine(b.HasValue);

            Nullable<int> b1 = 9;
            Console.WriteLine(b1.HasValue);

            int? c = null;
            int d = c ?? 3;
            Console.WriteLine(d);
        }
    }
}
