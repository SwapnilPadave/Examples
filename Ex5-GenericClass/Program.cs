using System;

namespace Ex5_GenericClass
{
    public class Generic
    {
        public void Display<T>(string msg, T value)
        {
            Console.WriteLine("{0} : {1}", msg, value);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Generic g = new Generic();
            g.Display<int>("Integer", 111);
            g.Display<string>("String", "Swapnil Padave");
            g.Display<double>("Decimal ", 111.11);
            g.Display<float>("Float", 11.11f);
        }
    }

    //public class Generic<T>
    //{
    //    private T data;
    //    public T value
    //    {
    //        get
    //        {
    //            return this.data;
    //        }
    //        set
    //        {
    //            this.data = value;
    //        }
    //    }
    //}
    //class Test
    //{
    //    static void Main(string[] args)
    //    {
    //        Generic<string> name = new Generic<string>();
    //        name.value = "Swapnil Padave";

    //        Generic<int> age = new Generic<int>();
    //        age.value = 28;

    //        Generic<float> salary = new Generic<float>();
    //        salary.value = 10000.50f;

    //        Generic<double> workHrs = new Generic<double>();
    //        workHrs.value = 9.30;

    //        Console.WriteLine("Name : "+name.value);
    //        Console.WriteLine("Age : "+age.value);
    //        Console.WriteLine("Salary :"+salary.value);
    //        Console.WriteLine("Working hours :"+workHrs.value);
    //    }
    //}
}
