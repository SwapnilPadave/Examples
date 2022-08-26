using System;

namespace Ex17_Constructor
{
    class A
    {
        public string model;
        //Default Constructor Without Any Parameter
        public A()
        {
            model = "KIA";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Object Of The Class
            A a = new A();           
            Console.WriteLine(a.model);           
        }
    }
}
