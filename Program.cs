using System;


namespace Super_Awesome_Brogram
{
    class Program
    {
        static void Main(string[] args)
        {
            //Change appearance of console
            Console.Title = "LochnessConsole";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WindowHeight = 40;

            Console.WriteLine("Hello, what's your name?");

            Console.ReadLine(); 
            
            Console.WriteLine("Okay, jerk.");
            Console.WriteLine("What is your favorite color?");

            Console.ReadLine();
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Wow, what a crappy colour.");

            
            
            Console.ReadKey();
        }
    }
}
