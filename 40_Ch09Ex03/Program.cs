using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _40_Ch09Ex03
{
    internal class Program
    {
        class MyClass
        {
            public int val;
        }

        struct myStruct
        {
            public int val;
        }

        static void Main(string[] args)
        {
            MyClass objectA = new MyClass();
            objectA.val = 10;
            MyClass objectB = objectA;
            Console.WriteLine(objectB.val);
            objectB.val = 20;

            myStruct structA = new myStruct();
            structA.val = 30;
            myStruct structB = structA;
            Console.WriteLine(structB.val);
            structB.val = 40;

            Console.WriteLine($"objectA.val = {objectA.val}");
            Console.WriteLine($"objectB.val = {objectB.val}");
            Console.WriteLine($"structA.val = {structA.val}");
            Console.WriteLine($"structB.val = {structB.val}");
        }
    }
}
