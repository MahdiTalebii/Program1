using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            // Get number n, then print n**2 & n **3.

            int n;

            Console.WriteLine("Enter your number: ");
            n = Convert.ToInt32(Console.ReadLine());

            Power(n);
        }

        static void Power(int n)
        {
            Console.WriteLine(Math.Pow(n, 2));
            Console.WriteLine(Math.Pow(n, 3));
        }
    }//endclass
}