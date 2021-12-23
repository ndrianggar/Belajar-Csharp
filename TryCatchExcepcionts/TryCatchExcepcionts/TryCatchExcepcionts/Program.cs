using System;

namespace TryCatchExcepcionts
{
    class Program
    {
        static void Main(string[] args)
        {
            checkAge(19);
            Console.WriteLine("== Try Catch, Final dan Exceptions == ");

            // #try
            try
            {
                int[] number = { 1, 2, 3, 4, 5, 7, 8, 6, 4 };

                Console.WriteLine(number[10]);
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // #Custome error Try
            try
            {
                string[] university = { "Lipia" , "UIM", "Al-Azhar" };
                Console.WriteLine(university[4]);
            }catch(Exception e)
            {
                Console.WriteLine("data tidak bisa dicari");
            }

            // #Finnaly error Try
            try
            {
                int[] bilangan = {1,2,3 };
                Console.WriteLine(bilangan[4]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Salah index");
            }
            finally
            {
                Console.WriteLine("index selesai");

            }


            /*
                    The throw keyword
                    The throw statement allows you to create a custom error.
                    The throw statement is used together with an exception class. There are many exception classes available in 
                    C#: ArithmeticException, FileNotFoundException, IndexOutOfRangeException, TimeOutException, etc:
             
             */

            
        }

        static void checkAge(int age)
        {
            if(age < 19)
            {
                throw new ArithmeticException("Access denied");
            }
            else
            {
                Console.WriteLine("Access granted - You are old enough!");

            }
        }
    }
}
