using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UintDataType
{
    class Program
    {
        static void Main(string[] args)
        {
            /*#################################################################################################################
              valid value
           ##############################################################################################################*/
            // 2 ^ 32 = 4000000000 (around value) .. 
            // vaild value from 0 to  4,294,967,295
            uint a = 5;
            Console.WriteLine(a);
            //uint b = -5; error with neg number
            //uint c = 4294967296; error with number greater than > 4,294,967,295
            //uint d = 5.2; error with point number
            /*------------------------- uint with float number ------------------------*/
            float f = 10.5f;
            uint j;
            j = (uint)f;//output 10 only .. we must convert from float to uint
            Console.WriteLine(j);
            /*------------------------- uint with byte and sbyte number -------------------*/
            byte x = 10;
            uint x1 = x; // we do not need convert byte to uint
            Console.WriteLine(x1);
            sbyte y = 3;
            //uint y1 = y; we can not assignment sbyte (negative or positive number )to uint .. because sbyte may be contain pos or neg values and uint can contain only pos num 
            sbyte k = -5;
            //uint l = k;error also
            /*-------------------------- uint with short and ushort number -------------------*/
            short sh = 5;
            //uint sh2 = sh;error we can not assignment short type to uint type 
            uint q = (uint)k;//error value
            Console.WriteLine(q);
            ushort t = 12345;
            uint h = t;
            Console.WriteLine(h);
            /*--------------------------- uint and int -------------------*/
            int abc = 99;
            // uint xyz = abc; error .. we must convert because int may be contain pos or neg values and uint can contain only pos num 
            uint xyz = (uint)abc;
            Console.WriteLine(xyz);
            int abc2 = -99;
            uint xyz2 = (uint)abc2;
            Console.WriteLine(xyz2);//error value
            /*##########################################################################################################
                suffix value u
             ######################################################################################################*/
            //we can use suffix u or not 
            uint u = 1254;
            uint u2 = 1254u;
            Console.WriteLine(u);
            Console.WriteLine(u2);
            /*###############################################################################################################
                arthimatic operation 
            ##############################################################################################################*/
            //we must convert byte to uint type in arthmetic operations
            byte z1 = 10;
            ushort z2 = 190; 
            uint z3 = (uint)z1 + z2;
            uint z4 = (uint)(z1 + z2);
            Console.WriteLine(z3);
            Console.WriteLine(z4);
            //we donot need to convert ushort to uint ... all u family with each other no problem..note with range value only
            ushort r = 10;
            uint h2 = 12;
            uint p = r + h2;
            Console.WriteLine(p);
            //we must convert short and int into uint
            int aq = 10;
            short az = 20;
            //uint au = az + aq;error
            uint au1 = (uint)(aq + az);
            uint au2 = (uint)aq + (uint)az;
            Console.WriteLine(au1);
            Console.WriteLine(au2);
           
            Console.ReadKey();

        }
    }
}
