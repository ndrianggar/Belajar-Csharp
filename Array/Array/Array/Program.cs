using System;
using System.Linq;
namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {

            //Access the Elements of an Array
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            for (int i = 0; i < cars.Length; i++)
            {

                // looping array
                Console.WriteLine(cars[i]);
                //Change an Array Element
                cars[0] = "Opel";
                Console.WriteLine(cars[0]);

                //Array Length
                Console.WriteLine(cars.Length);


                //The foreach Loop
                // foreach (type variableName in arrayName)
                // {
                // code block to be executed
                // }

                foreach (string j in cars)
                {
                    Console.WriteLine(j);

                }
            }


            // Sort Array
            System.Array.Sort(cars);

            // Sort an int
            int[] myNumbers = { 5, 1, 8, 9 };
            System.Array.Sort(myNumbers);
            foreach (int i in myNumbers)
            {
                Console.WriteLine(i);
            }

            //System.Linq Namespace
            Console.WriteLine(myNumbers.Max());


            //Other Ways to Create an Array
            // Create an array of four elements, and add values later
            string[] carss = new string[4];

            // Create an array of four elements and add values right away 
            string[] carsss = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

            // Create an array of four elements without specifying the size 
            string[] carsssss = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

            // Create an array of four elements, omitting the new keyword, and without specifying the size
            string[] carssssss = { "Volvo", "BMW", "Ford", "Mazda" };



            // to create array with declare and add values and using new
            // Declare an array
            string[] delman;

            delman = new String[4];
            Console.WriteLine(delman[0]);
            // Add values, using new
            cars = new string[] { "Volvo", "BMW", "Ford" };
            //Wrong to create array
            // Add values without using new (this will cause an error)
            //  cars = { "Volvo", "BMW", "Ford"};
        }
    }
}
