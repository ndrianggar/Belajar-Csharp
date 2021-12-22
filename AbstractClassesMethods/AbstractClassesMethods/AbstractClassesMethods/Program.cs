using System;

/* 

       Abstract Classes and Methods
        Data abstraction is the process of hiding certain details and showing 
        only essential information to the user.
        Abstraction can be achieved with either abstract classes or 
        interfaces (which you will learn more about in the next chapter).

        The abstract keyword is used for classes and methods:
        Abstract class: is a restricted class that cannot be used 
        to create objects (to access it, it must be inherited from another class).
        Abstract method: can only be used in an abstract class, 
        and it does not have a body. The body is provided by the derived class 
        (inherited from).
        An abstract class can have both abstract and regular methods:


      From the example above, it is not possible to create an object of the Animal class:
            Animal myObj = new Animal(); // Will generate an error (Cannot create an instance of the abstract class or interface 'Animal')
        
        To access the abstract class, it must be inherited from another class. 


 */



namespace AbstractClassesMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Banin mySantri = new Banin();
            mySantri.belajar();
            mySantri.hafalanQuran();
        
        }
    }

    abstract class Santri
    {

        // Abstract method (does not have a body)
        public abstract void hafalanQuran();

        //Reguler method
        public void belajar()
        {
            Console.WriteLine("Belajar ...");
        }
    }

    class Banin : Santri
    {
        public override void hafalanQuran()
        {
            // The body of hafalanQuran() is provided here
            Console.WriteLine("Hafal 3 juz");
        }
    }
}
