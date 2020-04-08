using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongDataType
{
    class Program
    {
        static void Main(string[] args)
        {
            /*#################################################################
                valid value 
            ###################################################################*/
            // 2 ^ 64 = x ... x / 2 = 9,223,372,036,854,775,807
            //valid value from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            long a = 9223372036854775807;
            Console.WriteLine(a);
            //long b = 9223372036854775808;error
            long c = -10;
            Console.WriteLine(c);
            //long d = 5.5;error with point number
            float g = 5.5f;
            long h = (long)g;
            Console.WriteLine(h);//output 5 only .. we must convert from float to long
            long j = 1000l;
            Console.WriteLine(j); // we can use l or L suffix or not
            
            /*###################################################################################
                arthimatic operation 
            ###################################################################################*/
            long x = 10;
            long y = 20;
            long z = x + y;
            Console.WriteLine(z);
            //we study before the arthimatic operation in the right side treated default as int type .. in this case we do not need to convert the result to int type because long is behavior than int ..64bit > 32bit  
            Console.ReadKey();
        }
    }
}
