using System;

namespace Ex3
{
    public partial class Student
    {
        public void Homework()
        {
            Console.WriteLine("You Have To Do This Task As Soon As Possible..");
        }
        public void Attendance()
        {
            Console.WriteLine("Students Attendence Is 75% Required...");
        }
    }
    public partial class Student
    {
        public void ParrentsMeeting()
        {
            Console.WriteLine("One Of Your Parrents Must Present In The Meeting...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Homework();
            student.Attendance();
            student.ParrentsMeeting();
        }
    }
}
