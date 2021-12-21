using System;

namespace Properties__Get_and_Set_

/*
        properties and Encapsulation
            Before we start to explain properties, you should have a basic understanding of "Encapsulation".

            The meaning of Encapsulation, is to make sure that "sensitive" data is hidden from users. To achieve this, you must:

            1. declare fields/variables as private
            2. provide public get and set methods, through properties, to access and update the value of a private field
                
    
        Properties
            You learned from the previous chapter that private variables can only be accessed within the same class 
            (an outside class has no access to it). However, sometimes we need to access them - and it can be done with properties.

            A property is like a combination of a variable and a method, 
            and it has two methods: a get and a set method:
 */
{
    class Program
    {
        static void Main(string[] args)
        {
            Person myObj = new Person();
            Console.WriteLine("Hello World!");
            myObj.Name = "Liam";

            Animal myObjer = new Animal();
        }
    }

    class Person
    {
        private string name; //field

        public string Name // property
        {
            get{return name; }
            set { name = value; }
        }

    }

    /*

         Automatic Properties (Short Hand)
          C# also provides a way to use short-hand / automatic properties, 
          where you do not have to define the field for the property, 
           and you only have to write get; and set; inside the property.

          The following example will produce the same result as the 
           example above. The only difference is that there is less code:

       */
    class Animal
    {
        public string Name  // property
        { get; set; }
    }

    /*
     Why Encapsulation?
      1.Better control of class members (reduce the possibility of yourself (or others) to mess up the code)
      2.Fields can be made read-only (if you only use the get method), or write-only (if you only use the set method)
      3.Flexible: the programmer can change one part of the code without affecting other parts
      4.Increased security of data
     
     */

}
