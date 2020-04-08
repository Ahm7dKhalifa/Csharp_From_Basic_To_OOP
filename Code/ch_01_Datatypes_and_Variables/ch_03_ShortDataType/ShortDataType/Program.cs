using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortDataType
{
    class Program
    {
        static void Main(string[] args)
        {
            /*#################################################################################################################
               valid value
            ##############################################################################################################*/
            // 2 ^ 16 = 65536 .... 65536 / 2 = 32768
            // vaild value from -32768 to 32767
            short a = 100;
            Console.WriteLine(a);
            short b = -100;
            Console.WriteLine(b);
            //short c = 33000; error with pos int number > 32767
            //short d = -33000; error with pos int number > -32768
            //short f = 10.5;error with pos or neg point number 
            float m = 10.5f;
            short n;
            n = (short) m; // output 10 only .. we can convert float number short number
            Console.WriteLine(n);
            /*##############################################################################################################
                arthimatic operations 
            ###############################################################################################################*/
            short x = 10;
            short y = -30;
            //short z = x + y; error because arthimatic operation in the right sude treat default as int
            short z = (short) (x + y);
            Console.WriteLine(z);
            short z2 = 10 - 30;
            Console.WriteLine(z2); // we can add two value dircetly
            Console.ReadKey();
        }
    }
}
