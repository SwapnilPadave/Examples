using System;

namespace Ex2
{
    abstract class Car
    {
        public abstract void Moving();
        public void Speed()
        {
            Console.WriteLine("55 Kmph");
        }
    }
    class Honda : Car
    {
        public override void Moving()
        {
            Console.WriteLine("The Honda Car Is Moving On 60 Kmph Speed..");
        }
    }       
    class Program
    {
        static void Main(string[] args)
        {
            Honda honda = new Honda();
            honda.Speed();
            honda.Moving();
        }
    }
}
