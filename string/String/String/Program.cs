using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Hendri ";
            string lastName = "Angggara";
            string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";


            Console.WriteLine("The length of the txt string is: " + txt.Length);
           
            //Method
            Console.WriteLine(txt.ToUpper());   // Outputs "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
            Console.WriteLine(txt.ToLower());   // Outputs "ABCDEFGHIJKLMNOPQRSTUVWXYZ"

            // String Concatenation
            string name = firstName + lastName;
            Console.WriteLine(name);


            // Concat
            string namapertama = "John ";
            string namakedua = "Doe";
            string nama = string.Concat(namapertama, namakedua);
            Console.WriteLine(nama);

            //bool
            Console.WriteLine(name == nama); // returns True, because the value of x is equal to 10


        }
    }
}
