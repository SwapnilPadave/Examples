using System;

namespace Ex27_ConstructorOverloading
{          
        public class Student
        {
            public double SubjectOne;
            public double SubjectTwo;
            string StundentName;

            public Student()
            {
                this.SubjectOne = 80;
            }
            public Student(double SubjectOne)
            {
                this.SubjectOne = SubjectOne;
            }
            public Student(string StundentName, double SubjectOne, double SubjectTwo)
            {
                this.SubjectOne = SubjectOne;
                this.SubjectTwo = SubjectTwo;
                this.StundentName = StundentName;
            }
            public double GetSubjectOneMarks()
            {
                return this.SubjectOne;
            }
            public double GetSubjectTwoMarks()
            {
                return this.SubjectTwo;
            }
            public string GetStudentName()
            {
                return this.StundentName;
            }
        }

    class Program
    {
        static void Main(string[] args)
        {
            var s1 = new Student();
            var s2 = new Student(90);
            var s3 = new Student("Swapnil",88,60);
            Console.WriteLine("One");
            Console.WriteLine("Subjecct One Marks :- {0}",s1.GetSubjectOneMarks());
            Console.WriteLine();
            Console.WriteLine("Two");
            Console.WriteLine("Subject Two Marks :- {0}",s2.GetSubjectOneMarks());
            Console.WriteLine();
            Console.WriteLine("Three");
            Console.WriteLine("Student Name :- {0}",s3.GetStudentName());
            Console.WriteLine("Subjecct One Marks :- {0}", s3.GetSubjectOneMarks());
            Console.WriteLine("Subject Two Marks :- {0}", s3.GetSubjectTwoMarks());
            Console.ReadLine();
        }
    }
}
