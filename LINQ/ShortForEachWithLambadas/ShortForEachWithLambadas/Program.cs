using System;
using System.Collections.Generic;
using System.Linq;

namespace ShortForEachWithLambadas
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] mix = { "string", "d", new List<int>() { 1, 2, 3, 4 }, new List<int>() { 5, 4, 3, 2 }, "dd" };
            List<Warrior> wariors = new List<Warrior>()
            {
                new Warrior() { Height = 100 },
                new Warrior() { Height = 90 },
                new Warrior() { Height = 80 },
                new Warrior() { Height = 70 },
                new Warrior() { Height = 60 },

            };

            List<int> shortWarriors = wariors.Where(wh => wh.Height == 100)
                                      .Select(wh => (wh.Height))
                                      .ToList();

            Console.WriteLine(string.Join(",", wariors));

            //shortForEach
            wariors.ForEach(w => Console.WriteLine(w.Height));
            shortWarriors.ForEach(sw => Console.WriteLine(sw));
        }

            internal class Warrior
        {
            public int Height
            {
                get; set;
            }
        }
    }

}