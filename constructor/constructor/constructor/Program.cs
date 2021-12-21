using System;

namespace constructor
{
    class Program
    {
        public string Start;
        public Program()
        {
            Start = "lets run"; // Set the initial value for model

        }


        static void Main(string[] args)
        {
            // buat objek baru
            Program myObj = new Program(); // Create an object of the Car Class (this will call the constructor)

            Console.WriteLine(myObj.Start); // Print the value of model


            Console.WriteLine("Hello World!");
        }
    }
}
