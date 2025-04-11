using System;

namespace Ex36_Convert.ToStringAnd.ToString
{
    class Program
    {
        public class Customer
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
        static void Main(string[] args)
        {
            //Customer c1 = null;
            //c1.ToString();
            //Console.ReadLine();
            //Console.WriteLine(c1);

            //String Name = null;
            //Name.ToString();
            //Console.ReadLine();

            Customer c1 = null;
            Convert.ToString(c1);

            String Name = null;
            Convert.ToString(Name);

            Console.WriteLine("No Error..");
            Console.ReadLine();
        }
    }
}