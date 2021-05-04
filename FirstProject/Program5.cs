using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class Program5
    {
        static void Main()
        {
            int x = 100;
            int y = 200;
            Console.WriteLine("Value of x and y inside Main function are {0} and {1} ", x, y);
            Change1(x, y);
            Console.WriteLine("Value of x and y after calling Change1 function are {0} and {1} ", x, y);
            Change2(ref x, ref y);
            Console.WriteLine("Value of x and y after calling Change2 function are {0} and {1} ", x, y);

        }

        static void Change1(int x, int y)
        {
           // It creates local variables here
            x = 1000;
            y = 2000;
            Console.WriteLine("Value of x and y inside Change1 function are {0} and {1} ", x, y);

        }

        static void Change2(ref int x, ref int y)
        {
            // It creates local variables here
            x = 3000;
            y = 4000;
            Console.WriteLine("Value of x and y inside Change2 function are {0} and {1} ", x, y);

        }
    }
}