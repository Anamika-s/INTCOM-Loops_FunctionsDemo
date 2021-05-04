using System;                   // namespace
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject // project name
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add 2 numbers
            double num1;
            double num2;
            string ch;

            Console.WriteLine("Enter Value of num1");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num1);
            Console.WriteLine("Enter Value of num2");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Choice");

            ch = Console.ReadLine();
            //Console.WriteLine("Sum of num1 & num2 is "
            //    + (num1+num2));
            ////  Console.WriteLine("Sum of %d & %d is %d "
            //      ,num1, num2 , (num1 + num2));

            switch (ch)
            {
                case "1":
                case "+":
                    {
                        Console.WriteLine("Sum of {0} and {1} is {2}"
                         , num1, num2, (num1 + num2));
                        break;
                    }
                case "2":
                case "-":
                    {
                        Console.WriteLine("Difference of {0} and {1} is {2}"
                        , num1, num2, (num1 - num2));
                        break;
                    }
                case "3":
                case "*":
                    {

                        Console.WriteLine("Product of {0} and {1} is {2}"
                        , num1, num2, (num1 * num2));
                        break;
                    }

                case "4":
                case "%":
                    {
                        Console.WriteLine("Remainder of {0} and {1} is {2}"
                        , num1, num2, (num1 % num2));
                        break;
                    }
                case "5":
                case "/":
                    {


                        Console.WriteLine("Quotient of {0} and {1} is {2}"
                        , num1, num2, (num1 / num2));
                        break;
                    }
                default:
                    {

                        Console.WriteLine("Invalid choice");
                        break;
                    }
            }
        }
    }
}

