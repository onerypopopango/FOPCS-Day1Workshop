using System;
using System.Threading;

namespace Day1Workshop
{
    class Question1
    {
        static void Main()
        {
            string name;
            string email;

            Console.WriteLine("********************************************");
            Console.Write("Hello earthling, what might your name be: ");
            name = Console.ReadLine();

            Console.Write("And can you provide me with your email details: ");
            email = Console.ReadLine();

            Console.WriteLine("\nThank you, mon ami. Processing...");


            Console.WriteLine(name);
            Console.WriteLine(email);

            Console.WriteLine("Thank you for your information. Shutting down...");
        }
    }
}
