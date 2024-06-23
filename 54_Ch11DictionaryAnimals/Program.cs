using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54_Ch11DictionaryAnimals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animals animalCollection = new Animals();
            animalCollection.Add("Hey", new Cow("Hey"));
            animalCollection.Add("Chi", new Chicken("Chi"));
            animalCollection.Add("Lao", new Cow("Lao"));

            foreach (Animal myAnimal in animalCollection)
            {
                Console.WriteLine($"New {myAnimal.ToString()} object added to custom collection, Name = {myAnimal.Name}");
            }

            animalCollection["Lao"].Feed();
        }
    }
}
