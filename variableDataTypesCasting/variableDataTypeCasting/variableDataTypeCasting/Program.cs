using System;

namespace variableDataTypeCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * 
             * A data type specifies the size and type of variable values. It is important to use the correct data type for the corresponding variable; to avoid errors, to save time and memory, but it will also make your code more maintainable and readable. The most common data types are:

Data Type	Size	Description
int	4 bytes	Stores whole numbers from -2,147,483,648 to 2,147,483,647
long	8 bytes	Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
float	4 bytes	Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits
double	8 bytes	Stores fractional numbers. Sufficient for storing 15 decimal digits
bool	1 bit	Stores true or false values
char	2 bytes	Stores a single character/letter, surrounded by single quotes
string	2 bytes per character	Stores a sequence of characters, surrounded by double quotes


            */

            int myNum = 5;               // Integer (whole number)
            double myDoubleNum = 5.99D;  // Floating point number
            char myLetter = 'D';         // Character
            bool myBool = true;          // Boolean
            string myText = "Hello";     // String




            Console.WriteLine($"ini adalah type int: {myNum}");
            Console.WriteLine($"ini adalah type Floating: {myDoubleNum}");
            Console.WriteLine($"ini adalah type Character: {myLetter}");
            Console.WriteLine($"ini adalah type myBool: {myBool}");
            Console.WriteLine($"ini adalah type string: {myText}");
        }
    }
}
