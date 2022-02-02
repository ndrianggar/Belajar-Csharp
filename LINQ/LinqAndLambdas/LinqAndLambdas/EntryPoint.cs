using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqAndLambdas
{
    public class EntryPoint
    {
        static void Main(string[] args)
        {
            string sentence = "I Love Sunnah";
            string[] madzhab = { "Imam Syafii", "Imam Hanafi", "Imam Ahmad", "Imam Malik", };
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 100, 122, 122, 444 };

            var getTheNumbers = from number in numbers
                                select number;

            System.Console.WriteLine(string.Join(",", getTheNumbers));
        }
    }
}
