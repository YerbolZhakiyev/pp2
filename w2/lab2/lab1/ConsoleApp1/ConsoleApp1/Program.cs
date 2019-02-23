using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace task1
{
    class Program
    {
        static bool Polindrome(string a) // checking whether this is polindrome or not
        {
            for (int i = 0; i < a.Length / 2; i++)
            {
                if (a[i] != a[a.Length - 1 - i]) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\123\Desktop\pp2\w2\lab2\lab1\polindrome.txt"); //make an object which will get string for checking 
            string s = sr.ReadToEnd(); // get the string and save it as c 
            if (Polindrome(s) == true)
                Console.WriteLine("Yes");
            else Console.WriteLine("No");






        }
    }
}
