using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_Ch06Exer03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            order.itemName = "cabbage";
            order.unitCount = 5;
            order.unitCost = 2.3;
            Console.WriteLine(order.PrintInfo());

        }

        struct Order
        {
            public string itemName;
            public int unitCount;
            public double unitCost;

            public double TotalCost()
            {
                return unitCount * unitCost;
            }

            public string PrintInfo()
            {
                return $"Order information: {unitCount} {itemName} items at ${unitCost} each, total cost ${TotalCost()}.";
            }
        }
    }
}
