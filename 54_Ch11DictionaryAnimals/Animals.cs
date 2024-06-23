using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _54_Ch11DictionaryAnimals
{
    internal class Animals : DictionaryBase
    {
        public void Add(string newID, Animal newAnimal) => Dictionary.Add(newID, newAnimal);
        public void Remove(string animalID) => Dictionary.Remove(animalID);
        public Animal this[string animalID]
        {
            get { return (Animal)Dictionary[animalID]; }
            set { Dictionary[animalID] = value; }
        }

        // Add a simple iterator
        public new IEnumerator GetEnumerator()
        {
            foreach (Animal animal in Dictionary.Values)
            {
                yield return animal;
            }
        }
    }
}
