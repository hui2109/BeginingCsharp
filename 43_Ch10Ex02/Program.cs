using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_Ch10Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassA myObject = new ClassA();
            Console.WriteLine($"myObject.State = {myObject.State}");

            ClassA.ClassB myOtherObject = new ClassA.ClassB();
            myOtherObject.SetPrivateState(myObject, 999);
            Console.WriteLine($"myObject.State = {myObject.State}");
        }
    }

    public class ClassA
    {
        private int state = -1;
        public int State => state;  // "State" property is read only.
        public class ClassB
        {
            public void SetPrivateState(ClassA target, int newState)
            {
                target.state = newState;
            }
        }

        public interface IXXX
        {
            int MyProperty { get; set; }
        }
    }
}
