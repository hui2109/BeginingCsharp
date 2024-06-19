using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46_Ch10Exer01
{
    public class MyClass
    {
        protected string myString;
        public virtual string GetString()
        {
            return myString;
        }
        public string ContainedString
        {
            set => myString = value;
        }
    }

    public class MyDerivedClass : MyClass
    {
        public override string GetString()
        {
            return base.GetString() + " (output from derived class) ";
        }
    }
}
