using System;

namespace Ex37_InheriatanceWithAbstractClassAndInterface
{
    public abstract class A
    {
        public abstract void Drive();
        public void Moving()
        {
            Console.WriteLine("Car Is Moving");
        }
    }
    public interface IB
    {
        public void Drive();
        public void Moving();
    }
    public class C : A, IB
    {
        public override void Drive()
        {
            Console.WriteLine("Man driving Car");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var c = new C();
            c.Drive();
            c.Moving();            
        }
    }
}
