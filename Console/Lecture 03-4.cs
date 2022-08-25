using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_03
{
    public struct MyStruct
    {
        public const float PI = 3.1415926f;
        public static int Age = 26;
    }

    public struct MyStruct_02
    {
        public int Age;
        public MyStruct_02(int InAge)
        {
            Age = InAge;
        }
    }

    public struct MyStruct_03
    {
        public int Age;
        public float Num2;
        public bool IsReady;
    }

    public struct MyStruct_04
    {
        public int Kor, Eng, Math, Total;
        public float Average;

        public void Compute()
        {
            Total = Kor + Eng + Math;
            Average = Total / 3.0f;
        }
    }

    enum Days {Sun = 1, Mon, Tue, Wed, Thu, Fri, Sat};

    class MyClass
    {
        public int Age;
    }

    class Program_04
    {
        static bool BoolVar;
        static void Main(string[] args)
        {   
            // const, static
            Console.WriteLine("{0} {1}", MyStruct.PI, MyStruct.Age);

            // constructor
            MyStruct_02 TestStruct1;
            TestStruct1.Age = 12;
            Console.WriteLine(TestStruct1.Age);

            MyStruct_02 TestStruct2 = new MyStruct_02();
            Console.WriteLine(TestStruct2.Age);

            MyStruct_02 TestStruct3 = new MyStruct_02(12);
            Console.WriteLine("{0}", TestStruct3.Age);

            // copy
            MyStruct_02 TestStruct_1, TestStruct_2;
            TestStruct_2.Age = 10;
            TestStruct_1 = TestStruct_2;
            Console.WriteLine("{0}", TestStruct_1.Age);

            // struct, class
            MyStruct_02 test1 = new MyStruct_02();
            test1.Age = 12;
            MyStruct_02 test2 = test1;
            test2.Age = 24;
            Console.WriteLine("{0} {1}", test1.Age, test2.Age);

            MyClass test3 = new MyClass();
            test3.Age = 12;
            MyClass test4 = test3;
            test4.Age = 24;
            Console.WriteLine("{0} {1}", test3.Age, test4.Age);

            // data type
            MyStruct_03 test = new MyStruct_03();
            Console.WriteLine("{0} {1} {2}", test.IsReady, test.Age, test.Num2);

            // application
            MyStruct_04 Test1 = new MyStruct_04();
            Test1.Kor = 80;
            Test1.Eng = 90;
            Test1.Math = 88;
            Test1.Compute();
            Console.WriteLine("총점 : {0} 평균 : {1}", Test1.Total, Test1.Average);

            // enum
            int nValue = (int)Days.Mon;
            Days day = Days.Tue;
            Console.WriteLine("{0} {1}",nValue, day);
        }
    }
}

