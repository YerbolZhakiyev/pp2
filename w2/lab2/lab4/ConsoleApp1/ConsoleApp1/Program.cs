using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\123\Desktop\pp2\w2\lab2\lab4\file1.txt"); //  object which willw write text into the file
            sw.Write("Yerbol"); //writing text into file
            sw.Close(); //close this function
            File.Copy(@"C:\Users\123\Desktop\pp2\w2\lab2\lab4\file1.txt", @"C:\Users\123\Desktop\pp2\w2\lab2\lab4\file2.txt"); //copy this file and make new
            File.Delete(@"C:\Users\123\Desktop\pp2\w2\lab2\lab4\file1.txt"); // delete old file
        }
    }
}