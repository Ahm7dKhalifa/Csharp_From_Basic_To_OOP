using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace one
{
    class Program
    {
        static void Main(string[] args)
        {
            /*=====================================================================================
             first note ": must write static when we invoke method with a class .. not with object 
             ======================================================================================*/
            Console.Write("enter the first -- int -- number ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the second -- int -- number ");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = SumInt( a, b);
            Console.WriteLine(" the result =  " + c);
            /*=======================================================================================
            second note : wrong to write method inside method 
            =========================================================================================*/ 
            
            /*
            static int sum( int x, int y)
            {
                return x + y;
            }
            */
            
            /*===========================================================================================
            third note : we can call method from anthor method
            ===========================================================================================*/
            Console.WriteLine(" the result from sec method =  " +  SumInt2(a, b));
            /*==============================================================================================
            four note : we can use paraMATERS with different type with each other or with return type 
            but take care with the return type .. in this case u can use void ,,  
            ================================================================================================*/
            Console.Write("enter number  -- byte -- type ");
            byte m = Convert.ToByte(Console.ReadLine());
            Console.Write("enter number  -- int -- type ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter number  -- long -- type ");
            long l = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine(" the result for multiType =  " + MultiType(m,n,l));
            /*=================================================================================================
             * five note : take care with the SORT of paras
             * ==============================================================================================*/

            //this is error MultiType(l, n, m);
            /*==================================================================================================
             * sex note : array as paraMETER 
             * ===============================================================================================*/
            decimal[] arr = { 10.5m, 20, 30, 40 };
            Console.WriteLine(" the sum of arr is = " + SumArr(arr));
           
            /*==================================================================================================
             * seven note : example for useing void .. error with return keyword 
             * ================================================================================================*/
              Console.Write(" enter number");
            int e = Convert.ToInt32(Console.ReadLine());
            PosNeg(e);

            Console.ReadKey();
        }
        //first method
        static int SumInt(int a,int b)
        {
            return a + b;
        }
        //second method
        static int SumInt2(int x, int y)
        {
            return SumInt(x,y);
        }
        //third method
        /* wrong 
        static int MultiType( byte x , int y , long z)
        {
            return x + y + z;
        }
        */
        static long MultiType(byte x, int y, long z)
        {
            return x + y + z;
        }
        static decimal SumArr(decimal[] arr)
        {
            int lenght = arr.Length;
            decimal sum = 0;
            for ( int i = 0; i < lenght; i++)
            {
                sum += arr[i];
            }

            return sum;
        }
       static void PosNeg(int e)
        {
            if (e > 0)
            {
                Console.WriteLine("this number is positive");
            }
            else if( e < 0)
            {
                Console.WriteLine("this number is negative");
            }
            else
            {
                Console.WriteLine("this number is zero");
            }

        }
    }
}
