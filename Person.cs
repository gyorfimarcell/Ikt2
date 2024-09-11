using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikt2
{
    public class Person
    {
        string firstName, lastName, id;
        int age;
        List<Dog> dogs = [];

        public Person(string csvLine)
        {
            string[] fields = csvLine.Split(';');
            firstName = fields[0];
            lastName = fields[1];
            id = fields[2];
            age = Convert.ToInt32(fields[2].Split('-')[1]);
        }

        public string FirstName => firstName;
        public string LastName => lastName; 
        public string Id => id; 
        public int Age => age; 
        public List<Dog> Dogs => dogs;

        public override string ToString()
        {
            return $"{firstName} {lastName}, {age} éves";
        }
    }
}
