using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText(@"C:\Users\Porsha\Documents\Visual Studio 2015\Projects\HandlingExceptions\Example.txt");
                Console.WriteLine(content);
            }
            //specific exception
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("There was a problem.");
                Console.WriteLine("Make sure the name of the file is named correctly: Example.txt");
            }
            //specific exception
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("There was a problem.");
                Console.WriteLine("Make sure C:\\file_path_here exists.");
            }
            //general exception
            catch(Exception ex)
            {
                Console.WriteLine("There was a problem reading the file.");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //code to finalize
                //setting objects to null
                //closing database connections
                //this code will always run
                Console.WriteLine("I am a final declaration statement. Clsoing application now...");
            }
            Console.ReadLine();

        }
    }
}
