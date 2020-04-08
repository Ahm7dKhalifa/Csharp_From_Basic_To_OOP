using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalDataType
{
    class Program
    {
        static void Main(string[] args)
        {
            /*#######################################################################################
                  decimal with point number 
             #######################################################################################*/
            /*
            decimal a = 10.5;
            this cause error because compilar treat the point number as double type 
            */
            decimal a = 10.5m;//correct
            Console.WriteLine(a);
            /*#########################################################################################
                decimal with integer number
            #########################################################################################*/
            decimal b = 10;//correct we donot need to use m suiffix with interger value for decimal type 
            Console.WriteLine(b);
            /*########################################################################################
                max and min value 
            ###########################################################################################*/
            decimal max = decimal.MaxValue;
            Console.WriteLine("max value =  " + max);
            decimal min = decimal.MinValue;
            Console.WriteLine("max value =  " + min);
            /*###########################################################################################
                converting between decimal type and others type in arthimatic operation
             ############################################################################################*/
            /*
             * decimal with integer type 
             * we do not need to conversion between decimal and int in arthimatic operations
            */
            decimal x = 10.5m;
            int y = 1;
            decimal z = x + y;
            Console.WriteLine("z = " + z);
            /*
             * decimal with float type 
             * we must conversion between decimal and float in arthimatic operations
            */
            decimal x2 = 10.5m;
            float y2 = 1.2f;
            //decimal z2 = x2 + y2;this cause error
            decimal z2 = x2 + (decimal)y2;//correct
            Console.WriteLine("z2 = " + z2);
            Console.ReadKey();
        }
    }
}
