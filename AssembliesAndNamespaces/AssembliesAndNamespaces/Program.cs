using System;
using System.IO;
using System.Net;

namespace AssembliesAndNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write one string to a text file.
            //string text = "A class is the most powerful data type in C#. Like a structure, " +
            //               "a class defines the data and behavior of the data type. ";
            // WriteAllText creates a file, writes the specified string to the file,
            // and then closes the file.    You do NOT need to call Flush() or Close().
            //System.IO.File.WriteAllText(@"C:\Users\Porsha\Documents\Visual Studio 2015\Projects\AssembliesAndNamespaces\WriteToFileExercise\WriteText.txt", text);

            WebClient client = new WebClient();
            string reply = client.DownloadString("http://msdn.microsoft.com");


            Console.WriteLine(reply);
            File.WriteAllText(@"C:\Users\Porsha\Documents\Visual Studio 2015\Projects\AssembliesAndNamespaces\WriteToFileExercise\WriteText.txt", reply);

            Console.ReadLine();
        }
    }
}
