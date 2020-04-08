using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SByteDataType
{
    class Program
    {
        static void Main(string[] args)
        {
            /*#########################################################################################################
                valid value : from -128 to 127 
            ###########################################################################################################*/
            sbyte a = -128;
            Console.WriteLine(a);
            //sbyte b = -129; error with negative number < -128 
            sbyte b = 127;
            Console.WriteLine(b);
            // sbyte c = 128; error with positive number > 127 
            //sbyte d = 12.5; error with point number
            //sbyte f = -12.5; //error with point number
            float h = 10.5f;
            sbyte j;
            j = (sbyte)h; //output 10 only .. we can convert float to sbyte 
            Console.WriteLine(j);
            float h2 = -10.5f;
            sbyte j2;
            j2 = (sbyte)h2; //output -10 only .. we can convert float to sbyte 
            Console.WriteLine(j2);
           
            /*###########################################################################################################
                arthimatic operations
            #######################################################################################################*/
            sbyte x = 10;
            sbyte y = -5;
            //sbyte z = x + y; error because the arthimatic expression in the right left treat by default as int
            sbyte z;
            z = (sbyte)(x + y);
            Console.WriteLine(z);
            sbyte z2;
            z2 = 10 - 5;
            Console.WriteLine(z2);// we can add two sbyte value directly 
            Console.ReadKey();
        }
    }
}
