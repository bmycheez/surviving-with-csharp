using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_03
{
    class Program_05
    {
        static bool BoolVar;
        static void Main(string[] args)
        {   
            // declaration by new
            int nVal1 = 12;
            int nVal2 = new int();
            Console.WriteLine("{0} {1}", nVal1, nVal2);

            // Array
            int[] Array1 = {1, 2, 3};
            int[] RefArray;
            RefArray = Array1;
            RefArray[1] = 20;
            Console.WriteLine("{0} {1} {2}", Array1[0], Array1[1], Array1[2]);

            
        }
    }
}

