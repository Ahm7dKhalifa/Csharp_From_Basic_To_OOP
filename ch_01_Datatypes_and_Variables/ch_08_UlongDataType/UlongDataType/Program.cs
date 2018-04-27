using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlongDataType
{
    class Program
    {
        static void Main(string[] args)
        {
            /*#################################################################
                valid value 
            ###################################################################*/
            // 2 ^ 64 = 18,446,744,073,709,551,615
            //valid value from 0 to 18,446,744,073,709,551,615
            ulong a = 9223372036854775807;
            Console.WriteLine(a);
            //ulong b = 18446744073709551616;error
            //ulong d = 5.5;//error with point number
            float g = 5.5f;
            ulong h = (ulong)g;
            Console.WriteLine(h);//output 5 only .. we must convert from float to ulong
            ulong j = 1000u;
            Console.WriteLine(j); // we can use u or U suffix or not
            /*###################################################################################
                                    arthimatic operation 
            ###################################################################################*/
            ulong x = 10;
            ulong y = 20;
            ulong z = x + y;
            Console.WriteLine(z);
            //we study before the arthimatic operation in the right side treated default as int type .. in this case we do not need to convert the result to int type because long is behavior than int ..64bit > 32bit  
            Console.ReadKey();
        }
    }
}
