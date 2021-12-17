using System;

namespace Pengkondisian_Pengontrolan_Perulangan
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = 22;

            //#Pengkondisian
            //cara normal
            if (time < 10)
            {
                Console.WriteLine("Good morning.");
            }
            else if (time < 20)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }

            //cara ringkas
            string result = (time < 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result);

            //#Pengendalian
            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }

            //#Pengulangan
            // cara 1
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

            //cara 2
            int j = 0;
            do
            {
                Console.WriteLine(j);
                j++;
            }
            while (j < 5);


            //cara 3
            for (int m= 0; m<=20;  m =m +2)
            {
                Console.WriteLine(m);
            }

            //#cara 4
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string h in cars)
            {
                Console.WriteLine(h);
            }


            //# Break/Continue

            // break
            for (int l = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    break;
                }
                Console.WriteLine(l);
            }

            //continue
            for (int o = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(o);
            }
        }




    }   

}
