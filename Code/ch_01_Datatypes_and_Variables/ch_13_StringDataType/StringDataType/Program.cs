using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDataType
{
    class Program
    {
        static void Main(string[] args)
        {
            //hello github
            //hello github
            //first ; declar only
            string x1;
            //Console.WriteLine(x1);error
            //second declar and assignment to null value 
            string x2 = null;
            Console.WriteLine(x2);
            //third : empty value 
            string x3 ="";
            Console.WriteLine(x3);
            string x4 = System.String.Empty;
            Console.WriteLine(x4);
            //four : special chars
            string oldPath = "c:\\Program Files\\Microsoft Visual Studio 8.0";
            Console.WriteLine(oldPath);
            //five : escape special charcters
            string newPath = @"c:\\Program Files\\Microsoft Visual Studio 9.0";
            Console.WriteLine(newPath);
            //five  @ with " 
            //string x5 = @"hello "ahmed" "; cause error .. @ prevent only " as special char
            //Console.WriteLine(x5);
            string x6 = @"hello ""ahmed"" ";
            Console.WriteLine(x6);
            //sex : string with special chars through \ as escape char 
            string oldPath2 = "c:\\\\Program Files\\\\Microsoft Visual Studio 8.0";
            Console.WriteLine(oldPath2);
            string tab = "hello \t ahmed";
            Console.WriteLine(tab);
            string newLine = "hello \n ahmed";
            Console.WriteLine(newLine);
            Console.ReadKey();
        }
    }
}
