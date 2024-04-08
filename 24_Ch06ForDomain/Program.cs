using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace _24_Ch06ForDomain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            string text = "";  // 必须进行初始化
            for (i = 0; i < 10; i++)
            {
                text = $"Line {Convert.ToString(i)}";
                Console.WriteLine(text);
            }

            Console.WriteLine($"The last output in loop: {text}");
        }
    }
}
