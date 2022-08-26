using System;

namespace Ex29_OperatorOverloading
{
    //class Calculator
    //{
    //    public int number1, number2;
    //    public Calculator(int num1,int num2)
    //    {
    //        number1 = num1;
    //        number2 = num2;
    //    }
    //    public static Calculator operator -(Calculator c1)
    //    {
    //        c1.number1 = -c1.number1;
    //        c1.number2 = -c1.number2;
    //        return c1;
    //    }
    //    public void Print()
    //    {
    //        Console.WriteLine("Number 1 :-" +number1);
    //        Console.WriteLine("Number 2 :-" +number2);
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var calc = new Calculator(15,-25);
    //        calc = -calc;
    //        calc.Print();
    //    }
    //}

    using System;

    namespace OperatorOvlApplication
    {

        class Box
        {
            private double length;   
            private double breadth;  
            private double height;   

            public double getVolume()
            {
                return length * breadth * height;
            }

            public void setLength(double len)
            {
                length = len;
            }

            public void setBreadth(double bre)
            {
                breadth = bre;
            }

            public void setHeight(double hei)
            {
                height = hei;
            }

           
            public static Box operator +(Box b, Box c)
            {
                Box box = new Box();
                box.length = b.length + c.length;
                box.breadth = b.breadth + c.breadth;
                box.height = b.height + c.height;
                return box;
            }
        }

        class Tester
        {

            static void Main(string[] args)
            {
                Box Box1 = new Box(); 
                Box Box2 = new Box();  
                Box Box3 = new Box();   
                double volume = 0.0;   

              
                Box1.setLength(6.0);
                Box1.setBreadth(7.0);
                Box1.setHeight(5.0);

               
                Box2.setLength(12.0);
                Box2.setBreadth(13.0);
                Box2.setHeight(10.0);

               
                volume = Box1.getVolume();
                Console.WriteLine("Volume of Box1 : {0}", volume);

               
                volume = Box2.getVolume();
                Console.WriteLine("Volume of Box2 : {0}", volume);

                
                Box3 = Box1 + Box2;

               
                volume = Box3.getVolume();
                Console.WriteLine("Volume of Box3 : {0}", volume);
                Console.ReadKey();
            }
        }
    }
}
