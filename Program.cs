namespace Ikt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.
            string[] lines = File.ReadAllLines("input.txt");
            Console.WriteLine($"1. feladat: {lines.Count(IsSequenceValid)}");

            //2.
            Console.WriteLine($"\n2. feladat: {lines.Count(x => x.IsValid())}");

            // 3.
            List<Person> people = File.ReadAllLines("people.csv").Select(x => new Person(x)).ToList();
            Console.WriteLine("\n3. feladat:");
            Console.WriteLine($"Legfiatalabb személy:\n{people.MinBy(x => x.Age).ToString()}\n---");
            Console.WriteLine($"Legidősebb személy:\n{people.MaxBy(x => x.Age).ToString()}\n---");
            Console.WriteLine($"A fájlban szereplő személyek átlagos életkora: {Math.Round(people.Average(x => x.Age), 2)} év");

            // 4.
            List<Dog> dogs = File.ReadAllLines("dogs.csv").Select(x => new Dog(x)).ToList();
            dogs.ForEach(x => people.Find(y => y.Id == x.OwnerId)?.Dogs.Add(x));
            Person mostDogs = people.MaxBy(x => x.Dogs.Count);
            Console.WriteLine($"\n4. feladat: {mostDogs.FirstName} {mostDogs.LastName} has {mostDogs.Dogs.Count} dogs");
        }

        public static bool IsSequenceValid(string line)
        {
            int open = 0;
            foreach (char x in line)
            {
                open += (x == '(' ? 1 : -1);
                if (open < 0) return false;
            }

            return open == 0;
        }
    }

    public static class ExtensionMethods
    {
        public static bool IsValid(this string line) {
            return Program.IsSequenceValid(line);
        }
    }
}
