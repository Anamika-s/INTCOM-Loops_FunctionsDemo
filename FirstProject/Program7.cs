using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class Program7
    {
        static void DisplayDetails(int rn=9 ,
            string name="XXXXXX"
            ,string address="Delhi", int marks=70)
        {
            Console.WriteLine("Roll No is " + rn);
            Console.WriteLine("Name is " + name);
            Console.WriteLine("Address is "  + address);
            Console.WriteLine("Marks are " + marks);
        }
        static void Main()
        {
           // DisplayDetails(1, "Delhi", "Deepak", 90);
            // Named Paramters 
            DisplayDetails(rn: 1,address: "Delhi",
                name: "Deepak");

            DisplayDetails(1, "Delhi", "Deepak", 80);
            DisplayDetails();
        }
    }
}
