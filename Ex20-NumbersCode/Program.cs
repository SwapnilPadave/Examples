using System;

namespace Ex20_NumbersCode
{
    class Program
    {
        //Find Duplicate No
        static void DuplicateNo(int[] arr,int size)
        {
            int i, j;
            Console.Write("Duplicate No Are:-");
            for (i = 0; i < size - 1; i++)
            {
                for (j = i + 1; j < size; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Console.Write(arr[i] + " ");
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            //  Print No From 1 To 10
            int c;
            for (c = 1; c <= 10; c++)
            {
                Console.Write(c+ ",");
            }
            Console.WriteLine("--No In Ascending Order--");

            // Print No In Reverse Order From 10 To 1
            int d;
            for (d = 10; d >= 1; d--)
            {
                Console.Write(d+ ",");
            }
            Console.WriteLine("--No In Descending Order--");

            // No Which Are Divided By 2
            int a;
            for (a = 1; a <= 50; a++)
            {
                if (a % 2 == 0)
                {
                    Console.Write(a+ ",");
                }
            }
            Console.WriteLine("--Divide By 2--");

            // No Which Are Divided By 3
            int b;
            for (b = 1; b <= 50; b++)
            {
                if (b % 3 == 0)
                {
                    Console.Write(b+",");
                }
            }
            Console.WriteLine("--Divide By 3--");

            // Fibonacci Series
            int n1 = 0, n2 = 1, n3, i, num;
            Console.Write("Enter The Number:-");
            num = int.Parse(Console.ReadLine());
            Console.Write(n1 + " " + n2 + " ");
            for (i = 2; i < num; ++i)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
            Console.WriteLine("--Fibonacci Series--");

            // Find Duplicate No 
            int[] arr = { 4, 2, 4, 7, 9, 2, 4, 6, 0, 1, 4, 5 };
            int arr_size = arr.Length;
            DuplicateNo(arr, arr_size);
            Console.WriteLine("--Duplicate No--");

            // Find Missing No
            int[] arr1 = { 1, 2, 3, 4, 5, 7, 8, 9, 10 };
            int missno, totalSum;
            totalSum = (arr1.Length + 1) * (arr1.Length + 2) / 2;
            foreach(var item in arr1)
            {
                totalSum = totalSum - item;
            }
            missno = totalSum;
            Console.Write("Missing No:- {0}", missno);
            Console.WriteLine(" --Missing No Form Array--");

            // Find Second Big No In Array
            var array = new int[] { 12, 2, 6, 3, 7, 9,51,61 };
            int fBno = 0, sBno = 0;
            for(int i1 = 0; i1 < array.Length; i1++)
            {
                int arrayItem = array[i1];
                if (arrayItem > fBno)
                {
                    sBno = fBno;
                    fBno = arrayItem;
                }
                else if (arrayItem > sBno && arrayItem < fBno)
                {
                    sBno = arrayItem;
                }
            }
            Console.Write($"Second Big No:- {sBno}");
            Console.WriteLine("--Second Big No In Array--");

            // Square Root Of The No
            Console.WriteLine("Enter A Number :-");
            int no = Convert.ToInt32(Console.ReadLine());
            double sqrtNo = Math.Sqrt(no);
            Console.Write("Square Root Of {0} is {1}", no, sqrtNo);
            Console.WriteLine(" --Square Root Of The No--");

            // Swapping Two No Without Using Third variable            
            int a1= 15;
            int b1 = 20;
            Console.WriteLine("--No Before Swapping-- a1= " + a1 + ", b1= " + b1+"---");
            a1 = a1 + b1;
            b1 = a1 - b1;
            a1 = a1 - b1;
            Console.WriteLine("--No After Swapping-- a1=" + a1 + ", b1=" + b1+"---");


        }
    }
}
