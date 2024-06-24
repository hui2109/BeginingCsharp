using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55_Ch11Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Checker check = new Checker();
            ClassA try1 = new ClassA();
            ClassB try2 = new ClassB();
            ClassC try3 = new ClassC();
            ClassD try4 = new ClassD();
            MyStruct try5 = new MyStruct();
            object try6 = try5;  // boxing


            Console.WriteLine("Analyzing ClassA type variable:");
            check.Check(try1);

            Console.WriteLine("\nAnalyzing ClassB type variable:");
            check.Check(try2);

            Console.WriteLine("\nAnalyzing ClassC type variable:");
            check.Check(try3);

            Console.WriteLine("\nAnalyzing ClassD type variable:");
            check.Check(try4);

            Console.WriteLine("\nAnalyzing MyStruct type variable:");
            check.Check(try5);

            Console.WriteLine("\nAnalyzing boxed MyStruct type variable:");
            check.Check(try6);
        }
    }

    class Checker
    {
        public void Check(object paraml)
        {
            if (paraml is ClassA)
                Console.WriteLine("Variable can be converted to ClassA.");
            else
                Console.WriteLine("Variable can't be converted to ClassA.");

            if (paraml is IMyInterface)
                Console.WriteLine("Variable can be converted to IMyInterface.");
            else
                Console.WriteLine("Varibale can't be converted to IMyInterface.");

            if (paraml is MyStruct)
                Console.WriteLine("Variable can be converted to MyStruct.");
            else
                Console.WriteLine("Variable can't be converted to MyStruct.");
        }
    }

    interface IMyInterface { }
    class ClassA : IMyInterface { }
    class ClassB : IMyInterface { }
    class ClassC { }
    class ClassD : ClassA { }
    struct MyStruct : IMyInterface { }
}
