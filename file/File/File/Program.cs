using System;
using System.IO;

/*
 The File class has many useful methods for creating and getting information about files. For example:

Method      	Description
===========================================================
AppendText()	Appends text at the end of an existing file
Copy()	        Copies a file
Create()       	Creates or overwrites a file
Delete()	    Deletes a file
Exists()	    Tests whether the file exists
ReadAllText()	Reads the contents of a file
Replace()   	Replaces the contents of a file with the contents of another file
WriteAllText()	Creates a new file and writes the contents to it. If the file already exists, it will be overwritten.
        
 
 
 */
namespace File
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("File Text");

      
        }
    }

    class Test
    {
        public static void Mains()
        {
            string writeText = "test"; // Create a Text String
             System.IO.File.WriteAllText("filename.txt", writeText);


            string readText = System.IO.File.ReadAllText("filename.txt");  // Read the contents of the file
            Console.WriteLine(readText);  // Output the content
        }
    }
}
