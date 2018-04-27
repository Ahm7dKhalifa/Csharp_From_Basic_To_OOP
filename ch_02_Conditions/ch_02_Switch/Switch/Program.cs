using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            /*######################################################################################################
             *  switch used to compare the value of varible with multi value 
             *  switched used in equality case only and not used in greater or less operatores
             *  ###################################################################################################*/
            int x = 5;
            switch( x )
            {
                case 1:
                    Console.WriteLine("this statment well be excuted if this condition is true x = 1");
                    Console.WriteLine("this statment also well be excuted");
                    break;
                case 5:
                    Console.WriteLine("this statment well be excuted if this condition is true x = 5");
                    Console.WriteLine("this statment also well be excuted");
                    break;
                case 7:
                    Console.WriteLine("this statment well be excuted if this condition is true x = 7");
                    Console.WriteLine("this statment also well be excuted");
                    break;
                default:
                    Console.WriteLine("this statment well be excuted if all conditions is false");
                    Console.WriteLine("this statment also well be excuted");
                    break;
            }
            /*##############################################################################################################
             * switch can excute the same code for more one value for the same varible 
             * #########################################################################################################*/ 

            int y = 5;
            switch (y)
            {
                case 1:
                    Console.WriteLine("this statment well be excuted if this condition is true y = 1");
                    Console.WriteLine("this statment also well be excuted");
                    break;
                case 5:
                case 7:
                    Console.WriteLine("this statment well be excuted if y = 5 or y = 7");
                    Console.WriteLine("this statment also well be excuted");
                    break;
                default:
                    Console.WriteLine("this statment well be excuted if all conditions is false");
                    Console.WriteLine("this statment also well be excuted");
                    break;
            }

            /*
             * this code is false 
             * we must use break keyword if we write statements in the case   
             
            int z = 5;
            switch (x)
            {
                case 1:
                    Console.WriteLine("this statment well be excuted if this condition is true x = 1");
                    Console.WriteLine("this statment also well be excuted");
                    break;
                case 5:
                    Console.WriteLine("this statment well be excuted if this condition is true x = 5");
                    Console.WriteLine("this statment also well be excuted");
                   
                case 7:
                    Console.WriteLine("this statment well be excuted if this condition is true x = 7");
                    Console.WriteLine("this statment also well be excuted");
                    break;
                default:
                    Console.WriteLine("this statment well be excuted if all conditions is false");
                    Console.WriteLine("this statment also well be excuted");
                    break;
            }
            */
                    Console.ReadKey();
        }
    }
}
