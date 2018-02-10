using System;
using System.Threading;

namespace Day1Workshop
{
    class Question4
    {
        static void Main()
        {
            string num;

            Console.Write("Hello earthling, pass me a number: ");
            num = Console.ReadLine();

            double numb = Double.Parse(num);
            double square = numb * numb;

            Console.WriteLine("The square of {0} is {1:0.00}", numb, square);
        }
    }
}
