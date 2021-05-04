using System;

namespace FirstProject
{
    class Program3
    {
        static void Main()
        {
            SByte n=1, num;
            int sum = 0;
            while(n<=10)
            {
                n++;
                Console.WriteLine("Enter number");
               num = Convert.ToSByte(Console.ReadLine());
                if (num < 0) continue;
                if (num == 0) break;
               sum = sum + num;
               
            }
            Console.WriteLine("Sum is " + sum);
        }
    }
}
