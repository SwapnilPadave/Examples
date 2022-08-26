using System;

namespace Ex26_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            do
            {
                int result;
                Console.Write("Enter The First Number:-");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter The Second Number:-");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Symbol(/,*,+,-):-");
                string symbol = Console.ReadLine();

                switch (symbol)
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine("Addition :" + result);
                        break;

                    case "-":
                        result = num1 - num2;
                        Console.WriteLine("Subtraction :" + result);
                        break;

                    case "/":
                        result = num1 / num2;
                        Console.WriteLine("Division :" + result);
                        break;

                    case "*":
                        result = num1 * num2;
                        Console.WriteLine("Multiplication :" + result);
                        break;

                    default:
                        Console.WriteLine("Wronge Input..");
                        break;
                }
                Console.ReadLine();
                Console.Write("Continue : (Press y/n)");
                value = Console.ReadLine();
            }
            while (value=="y"||value=="Y");
        }
    }
}
