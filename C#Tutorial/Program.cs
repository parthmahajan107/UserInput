using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Tutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write first number: ");
            int a = Convert.ToInt32(Console.ReadKey());

            Console.WriteLine("Write second number: ");
            int b = Convert.ToInt32(Console.ReadKey());

            int c = a + b; 

            Console.WriteLine("Sum of both the numbers: "+ c);
            Console.ReadKey();
        }
    }
}
