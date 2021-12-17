using System;

namespace TypeCasting

/*
 C# Type Casting
Type casting is when you assign a value of one data type to another type.

In C#, there are two types of casting:

Implicit Casting (automatically) - converting a smaller type to a larger type size
char -> int -> long -> float -> double

Explicit Casting (manually) - converting a larger type to a smaller size type
double -> float -> long -> int -> char


 */

{
    class Program
    {
        static void Main(string[] args)
        {
            // Example Implicit
            Console.WriteLine("=========Contoh Implicit===========");

            int myInt = 9;
            double myDouble = myInt;       // Automatic casting: int to double
            bool myBool = true;

            // Console.WriteLine($"{myInt}");                   // Outputs 9
            Console.WriteLine($" ini implicit {myDouble}");   // Outputs 9


            //
            Console.WriteLine("=========Contoh Eksplisit===========");
            double myDoubleExplicit = 9.78;
            int myIntExplicite  = (int)myDoubleExplicit;    // 

            Console.WriteLine($" ini explicite {myDoubleExplicit}");   // Outputs




            Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string


        }
    }
}
