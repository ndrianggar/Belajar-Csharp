using System;
using System.Collections.Generic;
using System.Linq;

namespace Grouping
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
                new Person("Hendri", 30, Gender.Male),
                new Person("Bagus", 29, Gender.Male),
                new Person("Kurniawan", 28, Gender.Male),
                new Person("Nur", 24, Gender.Female),
                new Person("Ana", 39, Gender.Female),
                new Person("Ghea", 80, Gender.Female),
                new Person("Fitri", 76, Gender.Female),

            };

            // coba inget syntax foreach Lambadas
            people.ForEach(p => Console.WriteLine(p.Gender));

            //
            var genderGroup = from p in people
                              group p by p.Gender;

            Console.WriteLine("========== Group =============");

            foreach (var person in genderGroup) {
                Console.WriteLine($"{person.Key}");

                foreach (var pn in person)
                {
                    Console.WriteLine($" {pn.Name} - {pn.Gender}");
                }
             }
            Console.WriteLine("========== Group 2=============");

            var groupWithConditions = from p in people
                                      where p.Age > 20
                                      group p by p.Age;

            foreach (var key in groupWithConditions)
            {
                Console.WriteLine($"{key.Key}");
                foreach(var item in key)
                {
                    Console.WriteLine($"{item.Age} {item.Name}");
                }
            }

            var alphaBetichalGroup = from p in people
                                     orderby p.Name
                                     group p by p.Name[0];
            Console.WriteLine("========== Group 3 =============");
            foreach (var key in alphaBetichalGroup)
            {
              

                Console.WriteLine($"{key.Key}");
                foreach(var item in key)
                {
                    Console.WriteLine($"{item.Name}");
                }
            }
        }

    }

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
            this.Gender = gender;
            this.Age = age;
        }


    } 

    internal enum Gender
    {
        Female,
        Male
    }
}
