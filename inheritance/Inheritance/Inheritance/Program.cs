using System;

namespace Inheritance
{

    /*
            Inheritance (Derived and Base Class)
                In C#, it is possible to inherit fields and methods from one class to another. We group the "inheritance concept" into two categories:

                Derived Class (child) - the class that inherits from another class
                Base Class (parent) - the class being inherited from
                To inherit from a class, use the : symbol.

                In the example below, the Car class (child) inherits the fields and methods from the Vehicle class (parent):
     
     */
    class Vehicle // base class (parent)
    {
        public string brand = "Honda";
        
        public void bell()
        {
            Console.WriteLine("tuit tuit");
        }
    }

    class Car : Vehicle // derived class (child)
    {
        public string type = "civic"; // car field 


    }

    class Program
    {
        static void Main(string[] args)
        {
            Car myObj = new Car();
            myObj.bell();
            
            // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
            Console.WriteLine(myObj.brand + " " + myObj.type);
        }
    }
}
