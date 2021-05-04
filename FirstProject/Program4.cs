using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class Program4
    {
        static void Main()
        {
            int x=20, y=10;
            //Console.WriteLine("Enter Value of x");
            //x = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine("Enter Value of y");
            //y = Convert.ToInt16(Console.ReadLine());
            int res;
            res= AddNumbers(x, y);
            Console.WriteLine("Sum is " + res);
            Console.WriteLine("Difference is " + SubtractNumbers(x, y));
            Console.WriteLine("Product is " + MultiplyNumbers(x, y));
        }

        static int AddNumbers(int x, int y)
        {
            return x + y;
        }
        static int SubtractNumbers(int x, int y)
        {
           int res = x-y;
            return res;
        }

        static int  MultiplyNumbers(int x, int y)
        {
            return(x * y);
        }
    }
}
