using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello " + args[0]);

            // untuk menangani error IndexOutOfTheBoundsRange dengan kondisi if

            var bilanganPecahan = new Double [5];
            bilanganPecahan[0] = 3.2;
            


            if (args.Length > 0)
            {
                Console.WriteLine($"Hello {args[0]} ");

            }
            else
            {
                Console.WriteLine("args length lebih dari 0 tapi data kosong");
            }
        }
    }
}
