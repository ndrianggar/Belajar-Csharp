using System;

namespace AccessModifiers
{
    class Quran
    {
        //public
        public string model;
    }
    class Program
    {
        // private
        private string model = "Yureka";


        static void Main(string[] args)
        {
            
            // create objek
            Program myObj = new Program();
            
            // call object and change value with access modifier private
            myObj.model = "udemy";
            
            // create objek
            Quran Qrn = new Quran();
            // call object and change value with access modifier public
            Qrn.model = "Mushaf utsmani";


            /*
             
             
             Why Access Modifiers?
                To control the visibility of class members (the security level of each individual class and class member).
              Note: By default, all members of a class are private if you don't specify an access modifier:

                class Car
                {
                  string model;  // private
                  string year;   // private
             */
        }
    }
}
