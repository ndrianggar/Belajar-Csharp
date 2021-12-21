using System;

namespace Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //Method Overloading
            //  With method overloading, multiple methods can have the same name with different parameters:
            /*
             int MyMethod(int x)
             float MyMethod(float x)
             double MyMethod(double x, double y)
             *
             */
            int myNumber =  PlusMethodInt(3,4);
            Console.WriteLine(myNumber);

            double myNumber2 = PlusMethodDouble(34.5, 78.9);
            Console.WriteLine(myNumber2);




            int myNum1 = PlusMethod(8, 5);
            double myNum2 = PlusMethod(4.3, 6.26);
            Console.WriteLine("Int: " + myNum1);
            Console.WriteLine("Double: " + myNum2);
        }

        static int PlusMethodInt(int x, int y)
        {
            return x + y;
        }

        static double PlusMethodDouble(double x, double y)
        {
            return x + y;
        }

        //Instead of defining two methods that should do the same thing, it is better to overload one.
        //In the example below, we overload the PlusMethod method to work for both int and double:
        static int PlusMethod(int x, int y)
        {
            return x + y;
        }

        static double PlusMethod(double x, double y)
        {
            return x + y;
        }
    }
}
