using System;
using System.Linq;

namespace Ex33_XOROperator
{
    class Program
    {      
        static void Main(string[] args)
        {
            //var s1 = "";
            //// Creating an object array
            //// Here, It is consist of four 
            //// elements only
            //object[] array = { "Hello", "Geeks", 12345, 786 };

            //// Using Join method
            //// Here separator is ', '( comma )
            // s1 = string.Join(", ", array);

            //// Finally after joining process gets over
            //// Getting the output of value of string s1
            //Console.WriteLine(s1);

            var a1 = new string[2];
            a1[0] = "ajay";
            a1[1] = "Swapnil";
            var a2 = new string[2];
            a2[0] = "ajay";
            a2[1] = "Swapnil";
            var a3 = new string[2];

            var emailIds = "";
            //var arr2 = new string[15];
            var arr2 = a1.Concat(a2).Concat(a3).ToArray();
            var arr3 = arr2.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            //if (a1 != null)
            //{
            //    a1.Concat(arr2).ToArray();
            //}
            //if (a2 != null)
            //{
            //    a2.Concat(arr2).ToArray();

            //}
            //if (a3 != null)
            //{
            //    a3.Concat(arr2).ToArray();
            //}
            emailIds = string.Join(",", arr3);
            foreach (var s in arr3)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine(emailIds);
        }
    }
}
