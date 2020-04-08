using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatDataType
{
    class Program
    {
        static void Main(string[] args)
        {
            /*#######################################################################################
                   float with point number 
              #######################################################################################*/
            /*
            float a = 10.5;
            this cause error because compilar treat the point number as double type 
            */
            float a = 10.5f;//correct
            Console.WriteLine(a);
            /*#########################################################################################
                float with integer number
            #########################################################################################*/
            float b = 10;//correct we do not need to use  suffix with interger value for float type 
            Console.WriteLine(b);
            /*########################################################################################
                max and min value 
            ###########################################################################################*/
            float max = float.MaxValue;
            Console.WriteLine("max value =  " + max);
            float min = float.MinValue;
            Console.WriteLine("max value =  " + min);
            /*###########################################################################################
                converting between float type and others type in arthimatic operation
             ############################################################################################*/
            /*
             * float with integer type 
             * we do not need to conversion between decimal and int in arthimatic operations
            */
            float x = 10.5f;
            int y = 1;
            float z = x + y;
            Console.WriteLine("z = " + z);
            /*
             * float with double type 
             * we must conversion between double and float in arthimatic operations
            */
            float x2 = 10.5f;
            double y2 = 1.2; 
            //float z2 = x2 + y2;this cause error
            float z2 = x2 + (float)y2;//correct
            Console.WriteLine("z2 = " + z2);
            Console.ReadKey();
        }
    }
}
