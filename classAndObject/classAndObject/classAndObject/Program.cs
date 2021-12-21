using System;

namespace classAndObject
{
    class Car
    {
        public string color = "red"; // cara agar bisa diakses dari luar kelas

    }
    class Program
    {
        static void Main(string[] args)
        {

            Car myObj = new Car();

            Console.WriteLine(myObj.color);              
        }

    
    }
}
