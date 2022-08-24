using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_03
{
    class Program_03
    {
        static bool BoolVar;
        static void Main(string[] args)
        {   
            // Boxing and unboxing
            int i = 123;
            object obj = i;
            Console.WriteLine("{0}", (int)obj);

            object o = i;
            i = 456;
            Console.WriteLine("{0} {1}", i, (int)o);

            // ReadKey
            ConsoleKeyInfo KeyInfo;
            do 
            {
                KeyInfo = Console.ReadKey();
                if (KeyInfo.KeyChar == 'a')
                {
                    Console.WriteLine("you pushed 'a'");
                }
            } while (KeyInfo.Key != ConsoleKey.Escape);

            // ReadLine
            int Kor, Eng, Math, Total;
            float Average;

            Console.Write("Input Korean score: ");
            Kor = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input English score: ");
            Eng = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Math score: ");
            Math = Convert.ToInt32(Console.ReadLine());
            Total = Kor + Eng + Math;
            Average = Total / 3.0f;
            Console.WriteLine("{0} {1} {2} {3} {4}", Kor, Eng, Math, Total, Average);
        }
    }
}

