using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqQueryOnObject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
                new Person("Bagus", 180, 70, Gender.Male),
                new Person("Bayu", 170, 80, Gender.Male),
                new Person("Dian", 175, 90, Gender.Female),
                new Person("Fachri", 168, 80, Gender.Male),
                new Person("Asep", 160, 80, Gender.Male),
            };


            var fourPeople = from p in people
                                 //where (p.Name.Contains("s"))
                             where p.Name.Length > 1
                             orderby  p.Height descending
                             select p;
            System.Console.WriteLine("=======Print Data With Objek=======");


            foreach (var item in fourPeople)
            {
                //System.Console.WriteLine("=======Print Data With Objek=======");

                // cetak dengan string between
                System.Console.WriteLine($"Name:  {item.Name}, Weight: {item.Weight}, Height: {item.Height}, Gender: {item.Gender}");
            }
        }
    }

    internal class Person
    {
        private string name;
        private int height;
        private int weight;

        public string Name
        {
            get
            {
                return this.name;
            }

            set => this.name = value;

        }

        public int Height
        {
            get
            {
                return this.height;
            }

            set => this.height = value;
        }

        public int Weight
        {
            get
            {
                return this.weight;
            }

            set => this.weight = value;
        }

        public Gender Gender
        {
            get; set;
        }

        public Person(string name, int height, int weight, Gender gender)
        {
            this.Name = name;
            this.Height = height;
            this.Weight = weight;
            this.Gender = gender;
        }


    }

    internal enum Gender
    {
        Male,
        Female
    }



}
