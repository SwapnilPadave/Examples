using System;

namespace Ex23_IsOperator
{
    
    //    public class Student
    //    {

    //    }
    //    public class Teacher
    //    {

    //    }
    //class itisas
    //{
    //    static void testClass(object o)
    //    {
    //        if (o is Student)
    //        { Console.WriteLine($"The instance: {nameof(o)} we recieved as argument is from Student class!"); }
    //        else if (o is Teacher)
    //        { Console.WriteLine($"The instance: {nameof(o)} we recieved as argument is from Teacher class!"); }
    //        else
    //        { Console.WriteLine($"The instance: {nameof(o)} we recieved as argument is from neither Teacher nor Student class!"); }
    //    }

    //    static void Main(string[] args)
    //    {
    //        Student s = new Student();
    //        Teacher t = new Teacher();
    //        int i = 0;
    //        testClass(s);
    //        testClass(t);
    //        testClass(i);
    //        Console.ReadKey(); 
    //    }
    //} 

    public class Animal
    {

    }
    public class Human
    {

    }
    class isOperator
    {
        static void testClass(object i)
        {
            if(i is Animal)
            {
                Console.WriteLine($"The Object {nameof(i)} is From Animal Class");
            }
            else if(i is Human)
            {
                Console.WriteLine($"The Object {nameof(i)} is From Human Class");
            }
            else
            {
                Console.WriteLine($"The Object {nameof(i)} is Nighter From Animal or Human class");
            }

        }
        static void Main(string[] args)
        {
            Animal a = new Animal();
            Human b = new Human();
            int i = 0;
            testClass(a);
            testClass(b);
            testClass(i);
            Console.ReadKey();
        }
    }
}
