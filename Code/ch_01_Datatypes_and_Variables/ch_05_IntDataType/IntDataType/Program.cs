using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntDataType
{
    class Program
    {
        static void Main(string[] args)
        {
            /*#################################################################################################################
               valid value
            ##############################################################################################################*/
            // 2 ^ 32 = 4000000000 (around value) .. 4000000000 / 2 = 2000000000
            // vaild value from -2,147,483,648 to 2,147,483,647
            int a = 5000000;
            Console.WriteLine(a);
            //int b = 2147483648; error
            int c = -5;
            Console.WriteLine(c);
            //int d = 5.5;error with point number
            float g = 5.5f;
            int m = (int)g;//output only 5 ... we must convert from float to int
            /*##############################################################################################################
                arthimatic operations 
            ###############################################################################################################*/
            int x = 10;
            int y = 20;
            int z = x + y;
            Console.WriteLine(z);//correct because arthimatic expression in  right side treat as int by default
            float x2 = 10.1f;
            int y2 = 20;
            // int z2 = x2 + y2; error..we can not add float number to int
            int z2 = (int)x2 + y2;//correct because we must convert float to int
            Console.WriteLine(z2);
            //we can add byte or sbyte dircetly to int type 
            byte v = 65;
            byte n = 5;
            int s = v + n;
            Console.WriteLine(s);
            sbyte v2 = 80;
            sbyte n2 = -10;
            int s2 = v2 + n2;
            Console.WriteLine(s2);
            Console.ReadKey();
        }
    }
}
