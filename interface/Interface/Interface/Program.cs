using System;
//An interface is a completely "abstract class",
//which can only contain abstract methods and properties
//(with empty bodies):

/*/ interface
interface Animal 
        {
          void animalSound(); // interface method (does not have a body)
          void run(); // interface method (does not have a body)
        }

            It is considered good practice to start with the
            letter "I" at the beginning of an interface, as it makes it easier
            for yourself and others to remember that it is an interface and not a class.
            
                Ini dianggap praktik yang baik untuk memulai dengan huruf "I" di awal antarmuka,
                    karena memudahkan Anda dan orang lain untuk mengingat bahwa itu adalah antarmuka dan bukan kelas.
            
     By default, members of an interface are abstract and public.
Note: Interfaces can contain properties and methods, but not fields.

  */


/*
  Notes on Interfaces:
       - Like abstract classes, interfaces cannot be used 
         to create objects (in the example above, it is not possible 
         to create an "IAnimal" object in the Program class)
       - Interface methods do not have a body - the body is provided by the "implement" class
          On implementation of an interface, you must override all of its methods
       - Interfaces can contain properties and methods, but not fields/variables
       - Interface members are by default abstract and public
       - An interface cannot contain a constructor (as it cannot be used to create objects)
        
      Why And When To Use Interfaces?
        1) To achieve security - hide certain details and only show the important details of an object (interface).

        2) C# does not support "multiple inheritance" (a class can only inherit from one base class). 
           However, it can be achieved with interfaces, because the class can implement multiple interfaces. Note: To implement multiple interfaces,
           separate them with a comma (see example below).

 */

namespace Interface
{
    // #Single interface
    interface ISantri
    {
        void hafalanSantri(); //interface method (does not have a body)
    }

    class Banin : ISantri
    {
        public void hafalanSantri()
        {
            Console.WriteLine("aku hafal 4 juz");
        }
    }

    // #Multiple interface

    interface Isantri1
    {
        void hafalanSantri1();
    }

    interface Isantri2
    {
        void hafalanSantri2();
    }

    class Banat : Isantri1, Isantri2
    {
        public void hafalanSantri1()
        {
            Console.WriteLine("aku hafal 5 juz");
        }

        public void hafalanSantri2()
        {
            Console.WriteLine("aku hafal 6 juz");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== penerapan interface ===");
            Banin myBanin = new Banin();
            myBanin.hafalanSantri();


            Banat myBanat = new Banat();
            myBanat.hafalanSantri1();
            myBanat.hafalanSantri2();
        }
    }
}
