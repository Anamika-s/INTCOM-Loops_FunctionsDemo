using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class Program8
    {
        static void Operations(int x, int y,
          out int add , out int subtract,
          out int product, out int div)

        {
            add = x + y;
            subtract = x - y;
            product = x * y;
            div = x / y;
        }
        static void Main()
        {
            int add, subtract, product, div;
            Operations(20, 10, out add, out subtract,
                out product, out div);
            Console.WriteLine("Sum is " + add);
            Console.WriteLine("Difference is " + subtract);
            Console.WriteLine("Product is " + product);
            Console.WriteLine("Quotient is " + div);
        }
    }
}
