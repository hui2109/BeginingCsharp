using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _42_Ch10OverrideVsNew
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MyDerivedClass myObj = new MyDerivedClass();
            MyBaseClass myBaseObj;
            myBaseObj = myObj;
            myBaseObj.DoSomething();
        }

        private int someData;
        public int SomeData => this.someData;

        public class MyBaseClass
        {
            public virtual void DoSomething() => Console.WriteLine("Base imp");
        }

        public class MyDerivedClass : MyBaseClass
        {
            //public override void DoSomething() => Console.WriteLine("Derived imp");
            new public void DoSomething() => Console.WriteLine("Derived imp");
        }
    }
}