using System;

namespace Ex7_PolyMorphism
{
    //This Is Method Overloading And Overriding 
    public class Calc
    {
        //For Method OverLoading
        public void Add(int a, int b)
        {
            Console.WriteLine( a + b);
        }
        //For Method Overriding
        public virtual void Subtract(int a,int b)
        {
            Console.WriteLine(a - b);
        }
    }
    public class B : Calc
    {
        //For Method OverLoading
        public void Add(float a, float b)
        {
            Console.WriteLine(a + b);
        }
        //For Method OverLoading
        public void Add(string a,string b)
        {
            Console.WriteLine(a + b);
        }
        //For Method Overriding
        public override void Subtract(int a, int b)
        {
            Console.WriteLine(a - b);
        }
    }
    public class C: Calc
    {
        //For Method OverLoading
        public void Add(string a,string b)
        {
            Console.WriteLine(a + b);
        }
        //For Method Overriding
        public override void Subtract(int a, int b)
        {
            Console.WriteLine(a-b);
        }
    }
    public class D
    {
        public void add1(int a,int b)
        {
            Console.WriteLine(a+b);
        }
        public void add1(string a,string b)
        {
            Console.WriteLine(a+b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Object Of B 
            B b = new B();
            b.Add(5, 6);
            b.Add(5.5f, 5.5f);
            b.Add("Swapi", "Padave");
            b.Subtract(11, 6);

            //Object Of C
            C c = new C();
            c.Add(5, 6);            
            c.Add("Swapnil", "Padave");
            c.Subtract(12, 7);

            //Object of D
            D d = new D();
            d.add1(5, 6);
            d.add1("swapnil", "padave");


            Console.ReadLine();
           
        }
    }
}
