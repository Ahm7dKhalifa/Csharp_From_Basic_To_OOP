using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternary
{
    class Program
    {
        static void Main(string[] args)
        {
            /*#####################################################################################################################
                ternary: 
                used for assignment value from two value to varible depend on condition
                
                (condition) ? value_one if the condition is true ?  value_two if the condition is false;

                note : 
                the type of value must be same as its varible
                #######################################################################################*/
            int x = (5 > 3) ? 5 : 3;
            Console.WriteLine(x);
            int y = (5 < 3) ? 5 : 3;
            Console.WriteLine(y);
            string a = (100 > 10) ? "this is true " : "this is false";
            Console.WriteLine(a);
            string b = (100 < 10) ? "this is true " : "this is false";
            Console.WriteLine(b);
            //this is false .. use if keyword 
            //( 5 > 3 ) ? int s = 5 : int s = 3; 
            Console.ReadKey();
        }
    }
}
