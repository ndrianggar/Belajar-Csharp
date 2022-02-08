using System;
using System.Collections.Generic;
using System.Linq;

namespace Grouping_By_Multikey
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>() {

            new Person("Hendri", 29, Gender.Male),
            new Person("Bagus", 28, Gender.Male),
            new Person("Bayu", 27, Gender.Male),
            new Person("Herman", 29, Gender.Male),
            new Person("Barus", 28, Gender.Male),
            new Person("Baqi", 27, Gender.Male)
        };

            var simpleGrouping = people.Where(p=> p.Age > 20)
                                        .GroupBy(p => p.Age);
            Console.WriteLine($"=== Group 1 age ====");
            foreach (var item in simpleGrouping)
            {
                Console.WriteLine($"Usia: {item.Key}");
                foreach(var p in item)
                {
                    Console.WriteLine($"{p.Name} {p.Age}");
                }
            }

            var alphabethicalGroup = people.OrderBy(p => (p.Name))
                                            .GroupBy(p => p.Name[0]);
            Console.WriteLine($"=== Group 2 alphabethic ====");

            foreach (var item in alphabethicalGroup)
            {
                Console.WriteLine($"{item.Key}");
                foreach(var p in item)
                {
                    Console.WriteLine($"{p.Name}");
                }
            }

            var multikey = people.GroupBy(p => new { p.Gender, p.Age }).OrderBy(p => p.Count());
            Console.WriteLine($"=== Group 3 Multikey ====");

            foreach (var item in multikey)
            {
                Console.WriteLine($"{item.Key}");
                foreach(var p in item)
                {
                    Console.WriteLine($"{p.Name}");
                }
            }
        }

        #region
        internal class Person
        {
            private string name;
            private int age;

            public string Name
            {
                get
                {
                    return this.name;

                }
                set => this.name = value;
            }

            public int Age
            {
                get
                {
                    return this.age;
                }

                set => this.age = value;
            }

            public Gender Gender
            {
                get;
                set;
            }

            public Person(string name, int age, Gender gender)
            {
                this.Name = name;
                this.Age = age;
                this.Gender = gender;
            }
        }
        #endregion
        

        internal enum Gender
        {
            Female,
            Male
        }
    }
}
