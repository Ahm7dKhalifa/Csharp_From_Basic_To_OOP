using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All
{
    class Program
    {
        static void Main(string[] args)
        {
            for ( int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
         
            //we can not use the same varible i the same program
            //int i = 10000000;
            //but we can use it in anthor loop

            /*########################################################################################################
             * break .. going out from the loop
             * ######################################################################################################*/
            for (int i = 0; i <= 10; i++)
            {
                if(i == 5)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            /*###############################################################################################################
             * continue .. going out from only this iteration 
             * ##########################################################################################################*/ 
            for (int i = 0; i <= 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
        
    }
}
