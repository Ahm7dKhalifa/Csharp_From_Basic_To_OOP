using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If
{
    class Program
    {
        static void Main(string[] args)
        {
            /*#################################################################################
                if 
             #################################################################################*/
             if(5 > 3)
            {
                Console.WriteLine("this is true");
            }
            if (3 > 5)
            {
                Console.WriteLine("this statement is not excuted because the condition is false ");
            }
            if ( !(3 > 5) )
            {
                Console.WriteLine("this statement is excuted because the condition is true");
            }
            /*#############################################################################
                if - else 
              ############################################################################*/
            if( 5 > 3 )
            {
                Console.WriteLine("this statement is excuted if the condition is true");
            } 
            else
            {
                Console.WriteLine("this statement is excuted if the condition is false");
            }

            if (3 > 5)
            {
                Console.WriteLine("this statement is excuted if the condition is true");
            }
            else
            {
                Console.WriteLine("this statement is excuted if the condition is false");
            }
            /*###################################################################################
                if else 
            ###################################################################################*/
            if( 5 < 3 )
            {
                Console.WriteLine("this statement is excuted if this condition is true 5 < 3");
            }
            else if( 5 == 5 )
            {
                Console.WriteLine("this statement is excuted if this condition is true 5 == 3");
            }
            else
            {
                Console.WriteLine("this statement is excuted if all before condition is false");
            }

            //multi true 
            //when there more conditions are true ..  the only code block for the firest condition is excuted and another code blocks although thier conitions are true not excuteded   
            if (5 > 3)
            {
                Console.WriteLine("this statement is excuted if this condition is true 5 > 3");
            }
            else if (5 == 5)
            {
                Console.WriteLine("this statement is not excuted although this condition is true 5 == 5");
            }
            else
            {
                Console.WriteLine("this statement is excuted if all before condition is false");
            }
            //we can unuse else with else if
            if (5 < 3)
            {
                Console.WriteLine("this statement is excuted if this condition is true 5 < 3");
            }
            else if (5 == 5)
            {
                Console.WriteLine("this statement is excuted if this condition is true 5 == 3");
            }
            else if (5 > 1)
            {
                Console.WriteLine("this statement is not excuted although this condition is true 5 == 3");
            }
            /*################################################################################################
             * if with data type 
             ################################################################################################*/
            // char  
            char a = 'A';
            if ( a == '\u0041')
            {
                Console.WriteLine("true");
            }
            Console.WriteLine(a);
            //string 
            string one = "ahmed";
            string two = "ahmed";
            string three = "Ahmed";
            if(one == two)
            {
                Console.WriteLine("ok..same value");
            }
            if ( one == three)
            {
                Console.WriteLine("ok.. DO OT CARE WITH CAPTIAL LETTERS");
            }
            else
            {
                Console.WriteLine("ok.. Take CARE WITH CAPTIAL LETTERS");
            }
            //array 
            int[] f = { 1, 2, 3 };
            int[] c = { 1, 2, 3 };
            if( f[1] == c[1] )
            {
                Console.WriteLine("ok..same value");
            }
            
            Console.ReadKey();
        }
    }
}
