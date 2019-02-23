using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // input number
            int i, j;  // describe two variables of loops
            int[,] arr = new int[n, n]; // create 2d array
            for (i = 0; i < n; i++) // loop which makes "srar triangle"
            {
                for (j=0; j <= i; j++)
                {
                    Console.Write("[*]");
                }
                Console.WriteLine();
            }
        }
    }
}
