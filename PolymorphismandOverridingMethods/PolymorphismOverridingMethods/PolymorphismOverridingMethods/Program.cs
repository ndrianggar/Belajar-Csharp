using System;

/*
 Polymorphism means "many forms", and it occurs when we have many classes
  that are related to each other by inheritance. 
        
   Polimorfisme berarti "banyak bentuk", dan itu terjadi ketika kita memiliki 
   banyak kelas yang terkait satu sama lain melalui pewarisan.
  
   Like we specified in the previous chapter; 
   Inheritance lets us inherit fields and methods from another class.
   Polymorphism uses those methods to perform different tasks. 
   This allows us to perform a single action in different ways.

   Seperti yang kami tentukan di bab sebelumnya; 
   Warisan memungkinkan kita mewarisi bidang dan metode dari kelas lain. 
   Polimorfisme menggunakan metode tersebut untuk melakukan tugas yang berbeda. 
   Ini memungkinkan kita untuk melakukan satu tindakan dengan cara yang berbeda.

    For example, think of a base class called 
    Animal that has a method called animalSound(). 
    Derived classes of Animals could be Pigs, Cats, Dogs, Birds -
    And they also have their own implementation of an animal sound 
    (the pig oinks, and the cat meows, etc.):
    
   
Misalnya, pikirkan kelas dasar yang disebut Animal yang memiliki metode yang
disebut animalSound(). Kelas Hewan yang diturunkan dapat berupa Babi, Kucing,
Anjing, Burung - Dan mereka juga memiliki penerapan sendiri dari suara hewan
(suara babi, dan kucing mengeong, dll.): 
 
 */

namespace PolymorphismOverridingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ini APlikasi dengan konsep Polymorphism");
            Console.WriteLine();

            Santri mySantri = new Santri(); // Create a Santri object
            Santri myBanat = new Banin(); // Create a myBanin object
            Santri myBanin = new Banat(); // Create a myBanat object

            // don't virtual and override
            Console.WriteLine("=== Program not With Override ===");

            mySantri.hafalanQuran();
            myBanat.hafalanQuran();
            myBanin.hafalanQuran();

            Console.WriteLine("");
            Console.WriteLine("=== Program With Override ===");

            SantriWithOverride mySantri1 = new SantriWithOverride(); // Create a Santri object
            SantriWithOverride myBanat1 = new BanatWithOverride(); // Create a myBanin object
            SantriWithOverride myBanin1 = new BaninWithOverride(); // Create a myBanat object

            // with virtual and override
            mySantri1.hafalanQuran();
            myBanat1.hafalanQuran();
            myBanin1.hafalanQuran();
        }
    }

    class Santri // Base class (parent)
    {
        public void hafalanQuran()
        {
            Console.WriteLine("Santri punya hafalan Quran");
        }
    }

    class Banin : Santri // Derived class (child)
    {
        public void hafalanQuran()
        {
            Console.WriteLine("Aku punya hafalan 20 juz");
        }
    }

    class Banat : Santri // Derived class (child)
    {
        public void hafalanQuran()
        {
            Console.WriteLine("Aku punya hafalan 30 juz");
        }
    }

    /*
            Not The Output I Was Looking For
            The output from the example above was probably not what you expected.
             That is because the base class method overrides the derived class meth
             od, when they share the same name.

            However, C# provides an option to override the base class method, 
            by adding the virtual keyword to the method inside the base class, 
             and by using the override keyword for each derived class methods:
     */

    class SantriWithOverride
    {
        public virtual void hafalanQuran()
        {
            Console.WriteLine("punya hafalan quran");
        }
    }

    class BaninWithOverride : SantriWithOverride
    {
        public override void hafalanQuran()
        {
            Console.WriteLine("Aku punya hafalan 20 juz");
        }
    }

    class BanatWithOverride : SantriWithOverride
    {
        public override void hafalanQuran()
        {
            Console.WriteLine("Aku punya hafalan 30 juz");
        }
    }

}
