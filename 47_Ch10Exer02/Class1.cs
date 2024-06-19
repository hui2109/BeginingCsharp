using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47_Ch10Exer02
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCopyableClass obj1 = new MyCopyableClass();
            obj1.ContainedInt = 5;
            MyCopyableClass obj2 = obj1.GetCopy();
            obj1.ContainedInt = 9;
            Console.WriteLine(obj1.ContainedInt);
            Console.WriteLine(obj2.ContainedInt);
        }
    }

    public class MyCopyableClass
    {
        protected int myInt;
        public int ContainedInt
        {
            get
            {
                return myInt;
            }
            set
            {
                myInt = value;
            }
        }

        public MyCopyableClass GetCopy()
        {
            return (MyCopyableClass)MemberwiseClone();
        }
    }
}
