using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteDataType
{
    class Program
    {
        static void Main(string[] args)
        {
            //hello
            //hello
            /*###############################################################################################################
                valid value => integer number from 0 to 255 
             ###########################################################################################################*/ 
            byte a = 10;
            Console.WriteLine(a);
            //byte b = 256; error with with integer number bigeger than 255
            //byte c = -200; error with negative number
            //byte d = 25.2; error with point number
            //byte h = 10.0; error with integer number with point
            byte k = (byte)25.2;
            Console.WriteLine(k);//output 25 only .. we can convert float value to byte data type
            float n = 25.5f;
            byte m = (byte)n;//we can convert float to byte; 
            Console.WriteLine(m);
            //byte f = "a";error with string
            //byte s = "10";error also

            /*###############################################################################################################
                arthimatic operation
             ###########################################################################################################*/
            byte x = 2;
            byte y = 3;
            byte z;
            //z = x + y;  error !! because the arithmetic expression on the right-hand side of the assignment operator evaluates to int by default.
            //z = x + 30;
            z = 10 + 20;//we can add two integer value directly 
            Console.WriteLine(z);
            byte x2 = 2;
            byte y2 = 3;
            byte z2;
            //z2 = (byte) x2 +  y2; error because the arithmetic expression on the right-hand side of the assignment operator evaluates to int by default.
            z2 = (byte) (x2 +  y2);
            Console.WriteLine(z2);



            Console.ReadKey();

        }
    }
}
