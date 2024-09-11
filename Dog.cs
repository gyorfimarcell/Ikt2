using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikt2
{
    public class Dog
    {
        string name, breed, age, ownerId;

        public Dog(string csvLine) {
            string[] fields = csvLine.Split(';');
            name = fields[0];
            breed = fields[1];
            age = fields[2];
            ownerId = fields[3];
        }

        public string Name => name;
        public string Breed => breed;
        public string Age => age;
        public string OwnerId => ownerId;
    }
}
