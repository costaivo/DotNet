using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var name = Console.ReadLine();

            //String Interplolation
            Console.WriteLine($"Your Name is : {name}");

            Console.WriteLine("Exiting Application. Press any key to exit!!");
 
            Console.Read();
        }
    }
}
