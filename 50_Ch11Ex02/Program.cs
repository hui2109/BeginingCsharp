using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50_Ch11Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AnimalCollection animalCollection = new AnimalCollection();
            animalCollection.Add(new Cow("Donna"));
            animalCollection.Add(new Chicken("Mary"));

            animalCollection[0].Feed();
            animalCollection[1].Feed();

            ((Cow)animalCollection[0]).Milk();
            ((Chicken)animalCollection[1]).LayEgg();
        }
    }
}
