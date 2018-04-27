using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two
{
    class Program
    {
        static void Main(string[] args)
        {
            /*==================================================================================
             * FIRST NOTE : MULTI PARAMETERS AS ARRAY --> params keyword
             * ================================================================================*/
            int a = sum( 10, 20 , 30, 40);
            Console.WriteLine(a);
            /*==================================================================================
             * second NOTE : MULTI PARAMETERS AS ARRAY with differnet type
             * =================================================================================*/
            Console.Write("enter operation : ");
            string operate = Convert.ToString(Console.ReadLine());
            Console.Write("enter FIRST NUMBER : ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter second NUMBER : ");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter third NUMBER : ");
            int third = Convert.ToInt32(Console.ReadLine());
            sum2(operate, first, second, third);
            /*=====================================================================================
             * third note : optionAL parameters which have intial values
             * ====================================================================================*/
            int sumThree = sum3(30,20);//45
            Console.WriteLine(sumThree);
            /*=====================================================================================
             *  FOUR NOTE : ORDER BY POSITION OR NAME 
             *  ==================================================================================*/
            int sumThree2 = sum3(z: 30, x: 20, y: 5);//-5
            Console.WriteLine(sumThree2);
            /*======================================================================================
             * five note : overloading --> write the same function name but change the parameters or change the the arrange of them
             * ====================================================================================*/
            int sumThree3 = sum3(100,200,400);//-100 excute the third method
            Console.WriteLine(sumThree3);
            int sumThree4 = sum3(100f, 200f, 400f);//8000000 excute the four method
            Console.WriteLine(sumThree4);
            Console.ReadKey();
            /*=================================================================
             * sex note : compilor give error when varible has the same name of function
             * ===============================================================*/
            //int sum = sum(10,20,30);error
        }

        static int sum(params int[] all)
        {
           int add = 0;
            foreach ( int element in all)
            {
                add += element; 
            }
            return add;
        }

        static void sum2(string operation ,params int[] all)
        {
            int add = 0;
            if (operation == "sum")
            {
                foreach (int element in all)
                {
                    add += element;
                }
                Console.WriteLine("the results =  " + add);
            }
            else if (operation == "sub")
            {
                foreach (int element in all)
                {
                    add += element;
                }
                Console.WriteLine("the results =  " + add);
            }
            else
            {
                Console.WriteLine("enter cooerct operate ");
            }
       }
        //third method
        static int sum3(int x, int y = 10, int z = 5)
        {
            int add = x + y - z;
            
            return add;
        }
        //four method 
        static int sum3(float x, float y = 10, float z = 5)
        {
            int add =(int) (x * y * z);

            return add ;
        }
    }
}
