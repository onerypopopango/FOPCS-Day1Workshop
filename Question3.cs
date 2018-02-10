using System;
using System.Threading;

namespace Day1Workshop
{
    class Question3
    {
        static void Main()
        {
            string num;

            Console.Write("Hello earthling, pass me a number. Any number: ");
            num = Console.ReadLine();

            int numb = Int32.Parse(num);
            int square = numb * numb;

            Console.WriteLine("The square of {0} is {1}", numb, square);
        }
    }
}
