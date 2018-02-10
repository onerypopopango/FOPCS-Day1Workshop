using System;
using System.Threading;

namespace Day1Workshop
{
    class Question5
    {
        static void Main()
        {
            string num1, num2, num3, num4;

            Console.WriteLine("Hello earthling,I want you to give me four numbers. Any sort.");

            Console.Write("First one:\t");
            num1 = Console.ReadLine();

            Console.Write("And another:\t");
            num2 = Console.ReadLine();

            Console.Write("And another:\t");
            num3 = Console.ReadLine();

            Console.Write("Last one:\t");
            num4 = Console.ReadLine();

            Console.WriteLine("Alright, tabulating...");

            double numb1 = Double.Parse(num1);
            double numb2 = Double.Parse(num2);
            double numb3 = Double.Parse(num3);
            double numb4 = Double.Parse(num4);


            Console.WriteLine("*************************************");
            Console.WriteLine("\tInput\t\tOutput");
            Console.WriteLine("\t{0}\t\t{0:0.00}", numb1);
            Console.WriteLine("\t{0}\t\t{0:0.00}", numb2);
            Console.WriteLine("\t{0}\t\t{0:0.00}", numb3);
            Console.WriteLine("\t{0}\t\t{0:0.00}", numb4);
            Console.WriteLine("*************************************");

        }
    }
}
