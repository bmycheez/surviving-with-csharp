using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_03
{
    class Program_02
    {
        static bool BoolVar;
        static void Main(string[] args)
        {   
            // var
            var value1 = 3.14f;
            float value2 = 10.1f;
            float sum = value1 + value2;
            Console.WriteLine("{0} {1:f1} {2}", value1, value2, sum);

            // nullable
            int? Num1 = null;
            if (Num1.HasValue)
            {
                Console.WriteLine("올바른 값");
            }
            else
            {
                Console.WriteLine("null 값");
            }
            Console.WriteLine("null : {0}", Num1);

            // Data Type Change
            int value_1 = 127;
            string str1 = value_1.ToString();
            Console.WriteLine();

            int value_2 = Convert.ToInt32(str1);
            Console.WriteLine(value_2);

            string str2 = "3.14";
            float value_3 = float.Parse(str2);
            Console.WriteLine(value_3);
        }
    }
}

