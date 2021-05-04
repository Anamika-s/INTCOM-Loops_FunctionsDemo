using System;

namespace FirstProject
{
    class Program2
    {
        static void Main()
        {
            // Print numbers from 1 to 10
            Console.WriteLine("Do while loop");
            int n = 100;
            do
            {
                Console.WriteLine(n);
                n++;
            } while (n <= 10);

            Console.WriteLine("While loop");
             n = 100;
            while(n<=10)
            {
                Console.WriteLine(n);
                n++;
            }
            Console.WriteLine("For loop");
            n = 1;
            for (; n <= 10;)
            {
                Console.WriteLine(n);
                n++;
            }
        }
    }
}
