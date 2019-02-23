using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Program
    {
        static bool prime(int n) // function for checking whether this number is prime or not 
        {
            if (n == 1 || n == 0) return false;
            for (int i = 2; i <= n ; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\123\Desktop\pp2\w2\lab2\lab2\1.txt"); // object which will take text
            StreamWriter sw = new StreamWriter(@"C:\Users\123\Desktop\pp2\w2\lab2\lab2\2.txt"); // object which will write prime numbers 
            string n = sr.ReadLine(); // read text form file and put it into n
            string[] text = n.Split(' '); // input n to the new array every element of string
            string[] k = ["abs", "123", "2323", "qwer"];
            foreach (string a in k)
            {
                Console.WriteLine(a);
            }
            foreach (string s in text) //loop will look through all numbers and check is this number prime or not
            {
                if (prime(int.Parse(s)))
                    sw.Write(s + " ");
            }
            sr.Close();
            sw.Close();
            Console.ReadKey();
        }
    }
}