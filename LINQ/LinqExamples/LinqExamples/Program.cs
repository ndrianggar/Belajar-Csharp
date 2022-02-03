using System;
using System.Collections.Generic;
using System.Linq;
namespace LinqExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "I Love Sunnah";
            string[] kutub = { "aqidah", "fiqih", "sirah", "bahasaarab", "ahklak", "tazkiyatunnufus" };
            int[] numbers = { 1, 2, 3, 45, 6, 6, 7, 77, 8, 8, 89, 9 };

            var kutubs = from kitaab in kutub
                         where kitaab.Contains("h") && (kitaab.Length < 5)
                         select kitaab;

            //bool getResult = kutubs.Contains("s");

            //Console.WriteLine(getResult);
            Console.WriteLine(string.Join(", ", kutub));


            var getNumbers = from n in numbers
                             where (n > 0) && (n < 100)
                             //where n == 8
                             orderby n descending
                             select n;

            List<int> newNumbers = new List<int>();

            foreach(var n in numbers)
            {
                if(n < 5)
                {
                    newNumbers.Add(n);
                }
            }


            Console.WriteLine(string.Join(", ", getNumbers));
            Console.WriteLine(string.Join(", ", newNumbers));

        }

    }
}
