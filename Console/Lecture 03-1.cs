using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_03
{
    class Program
    {
        static bool BoolVar;
        static void Main(string[] args)
        {   
            // bool
            bool LocalBoolVar = true;
            Console.WriteLine("{0} {1}", BoolVar, LocalBoolVar);

            // char
            char Mun = '7';
            int Num = Mun;
            Num += 1;
            Console.WriteLine("Mun = {0} 문자상수값 = {1} 유니코드 문자 = {2}",
             (int)Mun, Num, (char)Num);

            // byte, int
            int Result;
            byte x = 1, y = 2;
            Result = x + y;
            Console.WriteLine(Result);

            // short
            Console.WriteLine("{0} ~ {1}", short.MinValue, short.MaxValue);

            // path
            string str1 = "C:\\temp\\test.txt";
            string str2 = @"C:\temp\test.txt";
            Console.WriteLine("{0} {1}", str1, str2);
            Console.WriteLine("{0}", str1==str2);

            // string
            str1 = "Hello ";
            str2 = "World!";
            string str3 = str1 + str2;
            string str4 = "program" + "ming";
            Console.WriteLine("{0} {1}", str3, str4);
            Console.WriteLine(str3[4]);

            if (str3 == "Hello_World!")
                Console.WriteLine("같음");
            else
                Console.WriteLine("다름");

            // Length
            str1 = "Hello World!";
            Console.WriteLine("문자 개수: {0}", str1.Length); 
        }
    }
}

