using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_04
{
    class A 
    {

    }

    class B
    {

    }
    class Program_01
    {
        static bool BoolVar;
        static void Main(string[] args)
        {
            // !
            bool bFlag = false;
            Console.WriteLine("{0} {1} {2}", !bFlag, !true, !false);

            // +
            string str = "3" + ".14";
            Console.WriteLine(+5);
            Console.WriteLine(5 + 5);
            Console.WriteLine(5 + .5);
            Console.WriteLine("5" + "5");
            Console.WriteLine(5.01f + "5");
            Console.WriteLine(3.14f + "5");
            Console.WriteLine(str);

            // is
            int nValue = 10;
            if (nValue is float)
                Console.WriteLine("Compatible");
            else
                Console.WriteLine("Not Compatible");
            
            if (nValue is Object)
                Console.WriteLine("Compatible");
            else
                Console.WriteLine("Not Compatible");

            object obj = nValue;
            if (obj is int)
                Console.WriteLine("Compatible");
            else
                Console.WriteLine("Not Compatible");

            // as
            string str1 = "123";
            object obj_ = str1;
            string str2 = obj_ as string;
            Console.WriteLine(str2);

            A test1 = new A();
            object obj1 = test1;
            B test2 = obj1 as B;
            if (test2 == null)
                Console.WriteLine("Data Type Change Failed");
            else
                Console.WriteLine("Data Type Change Success!");

            // nullable
            int? x = null;
            int y = x ?? -1;
            Console.WriteLine(y);
            x = 10;
            y = x ?? -1;
            Console.WriteLine(y);
        }
    }
}

