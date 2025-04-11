using System;
using System.Text;

namespace Ex35_StringAndStringBuilder
{
    class Program
    {
        public static void concat1(String s1)
        {
            String st = "Swapnil";

            s1 = String.Concat(s1, st);
        }
        public static void concat2(StringBuilder s2)
        {
            s2.Append("Swapnil");
        }
        static void Main(string[] args)
        {
            String s1 = "Padave";
            concat1(s1);
            Console.WriteLine("Using String Class " + s1);

            StringBuilder s2 = new StringBuilder("Padave");
            concat2(s2);
            Console.WriteLine("Using String Builder Class " + s2);

            String str = "Swapnil";

            StringBuilder sbl = new StringBuilder(str);
            sbl.Append("Padave");
            Console.WriteLine(sbl);

            StringBuilder stbr = new StringBuilder("Swapnil");
            String s3 = stbr.ToString();
            Console.Write("String Builder Object To String :");
            Console.WriteLine(s3);

        }
    }
}
