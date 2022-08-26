using System;

namespace Ex4_SealedClass
{
    public sealed class Calc
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public string Add1(string a, string b)
        {
            return a + b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calc c = new Calc();
            int total = c.Add(5, 4);
            string total1 = c.Add1("swapnil", "padave");
            Console.WriteLine("Total = " + total.ToString());
            Console.WriteLine("Total = " + total1.ToString());
        }
    }

    //class Printer
    //{
    //    public virtual void Show()
    //    {
    //        Console.WriteLine("Display Dimension : 6*6");
    //    }
    //    public virtual void Print()
    //    {
    //        Console.WriteLine("Printer Is Printing...");
    //    }
    //}
    //class LaserJet : Printer
    //{
    //    public sealed override void Show()
    //    {
    //        Console.WriteLine("Display Dimension : 12*12");
    //    }
    //    public override void Print()
    //    {
    //        Console.WriteLine("LaserJet Printer is Printing....");
    //    }
    //}
    //class OfficePrinter : LaserJet
    //{
    //    public override void Print()
    //    {
    //        Console.WriteLine("Office Printer is Printing....");
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Printer p = new Printer();
    //        p.Show();
    //        p.Print();

    //        Printer ls = new LaserJet();
    //        ls.Show();
    //        ls.Print();

    //        Printer op = new OfficePrinter();
    //        op.Show();
    //        op.Print();
    //    }
    //}
}
