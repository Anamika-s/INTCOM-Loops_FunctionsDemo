using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class Program6
    {
        static void add(int x, int y)
        {
            Console.WriteLine(x+y);
        }
        static void add(int x, int y, int z)
        {
            Console.WriteLine(x + y);
        }
        static void add(float x, float y)
        {
            Console.WriteLine(x + y);
        }
        static void add(int x, int y, float z)
        {
            Console.WriteLine(x + y + z);
        }
        static void Main()
        {
            add(10, 20);
            add(10, 20, 40);
            add(10.9f, 90.8f);
            add(10, 90, 90.5f);
        }
    }
}
