using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
      public bool Prime (int n)
        {
            if (n == 1 || n == 0) return false;
            for (int i = 2; i < n; i++)
            {if (i % n == 0)
                    return false; }
            return true;
        }
        }
    }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // input number
            int[] a = new int[n]; // create array
            int cnt = 0; // counter=0
            for (int i = 0; i < n; i++)  // input numbers into array 
            {
                int b = int.Parse(Console.ReadLine());
                a[i] = b;
            }
            for (int i = 0; i < n; i++) // if prime number then counter will increase for 1 
            {
                if (Prime(a[i]))
                {
                    cnt++;
                }
            }
            Console.WriteLine(cnt); // output number of prime numbers
            for (int i = 0; i < n; i++) // loop for output prime numbers 
            {
                if (Prime(a[i]))
                {
                    Console.Write(a[i] + " "); // show prime number from array and space
                }
            }
        }
    }
}