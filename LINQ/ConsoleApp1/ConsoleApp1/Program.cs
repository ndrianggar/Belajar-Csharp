
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqAndLambdas
{
    public class EntryPoint
    {
        public static object[] i { get; private set; }

        static void Main(string[] args)
        {
            string sentence = "I Love Sunnah";
            string[] madzhabs = new string[] {"Imam Syafii", "Imam Hanafi", "Imam Ahmad", "Imam Malik" };
            int[] numberss = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 100, 122, 122, 444 };
            int i = 0;

            var getTheNumber1 = from number in numberss
                                where number > 5
                                select number;

            var getMadzhab = from madzhab in madzhabs
                             select madzhab;


            var getSentence = from s in sentence
                              select s;

            //for( i=0; i < 4; i++);
            //i = i + 1;

            List<int> getListNumber2 = new List<int>();

            foreach(var number in numberss)
            {
                if(number > 5)
                {
                    getListNumber2.Add(number);
                }
            }


            //foreach(var looping in sentence)
            //{
            //    console.writeline(sentence);    
            //}

            //for (int x = 0; x < sentence.Count(); x++);
            //{
            //    sentence[i]; // error not IEnumerable
            //}


            System.Console.WriteLine(string.Join("", getMadzhab));
            System.Console.WriteLine(string.Join(",", getTheNumber1));
            System.Console.WriteLine(string.Join(",", getListNumber2));
        }
    }

}

