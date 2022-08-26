using System;

namespace Ex9_Interface
{
    /// <summary>
    /// Here We Use Interface Of Each Class To Achive Multiple Inheriatance
    /// </summary>
    interface IA
    {
        void PrintA();
    }
    interface IB
    {
        void PrintB();
    }
    interface IC
    {
        void PrintC();
    }

    public class A : IA
    {    
        public void PrintA()
        {
            Console.WriteLine("A Is Print..");
        }
    }
    public class B : IB
    {
        public void PrintB()
        {
            Console.WriteLine("B Is Print..");
        }
    }
    public class C : IC
    {
        public void PrintC()
        {
            Console.WriteLine("C Is Print..");
        }
    }
    public class D : IA, IB, IC
    {
        public void PrintA()
        {
            Console.WriteLine("A Is Print..");
        }

        public void PrintB()
        {
            Console.WriteLine("B Is Print..");
        }

        public void PrintC()
        {
            Console.WriteLine("C Is Print..");
        }        
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            D obj = new D();
            obj.PrintA();
            obj.PrintB();
            obj.PrintC();
            Console.ReadLine();
        }
    }
}
