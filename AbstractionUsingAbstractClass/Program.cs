using System;

namespace AbstractionUsingAbstractClass
{
    public abstract class Vehical
    {
        public abstract void MovingVehical();
        public void Stoped()
        {
            Console.WriteLine("This vehical is stoped.");
        }
    }
    public class Bus : Vehical
    {
        public override void MovingVehical()
        {
            Console.WriteLine("Bus is moving at full speed.");
        }
    }
    public class Car : Vehical
    {
        public override void MovingVehical()
        {
            Console.WriteLine("Car is moving towerds city.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var bus = new Bus();
            bus.MovingVehical();
            bus.Stoped();

            var car = new Car();
            car.MovingVehical();
            car.Stoped();
        }
    }
}
