using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace Lecture_04
{
    class Program_02
    {
        static int GetNumber(int index)
        {
            int[] nums = { 300, 600, 900 };
            if (index >= nums.Length)
                throw new IndexOutOfRangeException();
            return nums[index];
        }

        static void Main(string[] args)
        {
            // if   
            int nNum = 10;
            if (true)
                Console.WriteLine("Hello World!");
            else
                Console.WriteLine("C# Programming");

            // switch 1
            int nNum_ = 1;
            switch (nNum_)
            {
                case 1:
                    Console.WriteLine("1");
                    break;
                case 2:
                    Console.WriteLine("2");
                    break;
            }

            // switch 2
            string str = "yes";
            switch (str)
            {
                case "no":
                    Console.WriteLine("no!");
                    break;
                case "yes":
                    Console.WriteLine("yes!");
                    break;
            }

            // switch 3
            char value = 'a';
            switch (value)
            {
                case 'a':
                    Console.WriteLine("a");
                    break;
                case 'b':
                    Console.WriteLine("b");
                    break;
            }

            // foreach 1
            int[] Array1 = { 1, 2, 3, 4 };

            foreach (int nValue in Array1)
                Console.WriteLine(nValue);

            // foreach 2
            ArrayList List = new ArrayList();
            List.Add(1);
            List.Add(2);
            List.Add(3);

            foreach (int mm in List)
                Console.WriteLine(mm);

            // try catch 1
            int[] array = { 1, 2, 3 };
            try{
                array[3] = 10;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Array Index Error!");
                Console.WriteLine(e.ToString());
                array[2] = 10;
            }

            for (int i = 0; i < array.Length; i++)
                Console.Write("{0}, ", array[i]);

            // try catch 2
            // int m;
            int m = 0;
            try{
                m = 12;
                Console.WriteLine("try output: {0}", m);
            }
            catch{
                Console.WriteLine("Error!");
            }

            Console.WriteLine("output outside try: {0}", m);

            // finally 1
            int[] array_ = array;
            try{
                Console.WriteLine("Exception in try!");
                array[3] = 10;
            }
            finally
            {
                Console.WriteLine("Finally!");
            }

            foreach (var mm in array)
                Console.WriteLine("{0} ", m);

            // finally 2
            int ii = 0;
            try{
                ii = 12;
            }
            finally
            {
                ii = 100;
                Console.WriteLine("Finally i = {0}", ii);
            }

            ii = 200;
            Console.WriteLine("i outside finally: {0}", ii);

            // throw
            int result = GetNumber(3);
        }
    }
}

