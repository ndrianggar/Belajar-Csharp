using System;

namespace Methode
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Hello World!");
            // call method
            MyMethod();

            MyMethod1("Hendri");
            MyMethod2("Arab Saudi");

            //call method retun value
            MyMethodReturnValue(3);
            MyMethodMTK(5, 6);
        }

        // Create a Method
        static void MyMethod()
        {

        }

        //Parameters and Arguments
        static void MyMethod1(String fname)
        {
            {
                Console.WriteLine(fname + "Anggara");
            }
        }

        //Default Parameter Value
        static void MyMethod2(string country = "Indonesia")
        {
            Console.WriteLine(country);
        }

        // Return Values
        /*
        The void keyword, used in the examples 
        above, indicates that the method should 
        not return a value.If you want the method
        to return a value, you can use a primitive
        data type (such as int or double) instead 
        of void, and use the return keyword inside 
        the method:
        */

        static int MyMethodReturnValue(int x)
        {
            return 5 + x;
        }

        // function two paramater
        static int MyMethodMTK(int x, int y)
        {
            return x + y;
        }


        // function named parameter
        static void MyMethodNamed(string child1, string child2, string child3)
        {
            Console.WriteLine("The youngest child is: " + child1);
        }
    }

}