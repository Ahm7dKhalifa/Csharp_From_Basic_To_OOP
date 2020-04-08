using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UshortDataType
{
    class Program
    {
        static void Main(string[] args)
        {
            /*#################################################################################################################
               valid value
            ##############################################################################################################*/
            // 2 ^ 16 = 65536 .... 
            // vaild value from 0 to 65535
            ushort a = 100;
            Console.WriteLine(a);
            //ushort b = -100; error with negative number
            // ushort c = 66000; error with pos int value > 65535
            //ushort f = 10.5; error with  point number
            float m = 10.5f;
            ushort n;
            n = (ushort)m; // output 10 only .. we can convert float number ushort number
            Console.WriteLine(n);
            /*##############################################################################################################
               arthimatic operations 
           ###############################################################################################################*/
            ushort x = 10;
            ushort y = 20;
            //short z = x + y; error because arthimatic operation in the right side treat default as int
            ushort z = (ushort)(x + y);
            Console.WriteLine(z);
            ushort z2 = 10 + 20;
            Console.WriteLine(z2); // we can add two value dircetly
            Console.ReadKey();
        }
    }
}
