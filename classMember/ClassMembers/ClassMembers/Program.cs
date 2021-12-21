using System;

namespace ClassMembers
{
    // ini class 
    class MyClass
    {
        //class member
        string color = "red";
        int speed = 90000;

        // method
        public void say()
        {
            Console.WriteLine("warna :"+  color);
            Console.WriteLine("speed :"+  speed);
        }

        static void Main(string [] args)
        {
            MyClass myObj = new MyClass();
            Console.WriteLine(myObj.color);
            Console.WriteLine(myObj.speed);


            //membuat multiObjek
            MyClass myObj2 = new MyClass();

            myObj2.color = "green";
            myObj2.speed = 10000;

            // pemanggilan function
            myObj.say();

        }
    }
}
