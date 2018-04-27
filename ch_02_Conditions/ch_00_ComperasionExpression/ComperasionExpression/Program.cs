using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComperasionExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            /*###############################################################################
                the return of comperasion exp is boolean value
            ################################################################################*/
            Console.WriteLine(5 > 4);
            Console.WriteLine(4 > 5);
            bool x = 5 > 4; //return true
            //int x = 5 > 4; error because the return of comperasion exp is boolean value
            Console.WriteLine(x);
            /*################################################################################
                to use multi conditions we must use logic operators
            #################################################################################*/    
            bool y = 5 > 4 && 4 > 5;//return false
            Console.WriteLine(y);
            bool z = (5 > 4 && 4 > 5);//return false
            Console.WriteLine(y);
            Console.ReadKey();
            
        }
    }
}
