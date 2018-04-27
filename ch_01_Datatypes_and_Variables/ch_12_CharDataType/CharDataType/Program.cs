using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharDataType
{
    class Program
    {
        static void Main(string[] args)
        {
            //firest way
            char x1 = 'x';
            Console.WriteLine(x1);
            //second way : u -> unicode
            char x2 = '\u0058';
            Console.WriteLine(x2);
            //third way : x-> hexa
            char x3 = '\x0058';
            Console.WriteLine(x3);
            //four way 
            int a = 88; //88 in decimal = 58 in hexa
            char x4 = (char)a;
            Console.WriteLine(x4);
           
            Console.ReadKey();
        }
    }
}
