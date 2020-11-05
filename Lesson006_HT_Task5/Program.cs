using System;

namespace Lesson006_HT_Task5
{
    class MainClass
    {
        static void positive (double a)
        {
            if (a < 0)
            {
                Console.WriteLine("Negative");
            }
            else
            {
                Console.WriteLine("Positive");
            }
        }
        static void simple(double a)
        {
            if (a % a == 0 && a % 1 == 0 && a % 2 != 0)
            {
                Console.WriteLine("Simple");
            }
            else if (a % a == 0 && a % 1 == 0 && a % 2 == 0)
            {
                Console.WriteLine("Not simple");
            }
        }
        static void div(double a)
        {
            if(a%2 ==0)
            {
                Console.WriteLine("Divide on 2");
            }
            else if (a % 5 == 0)
            {
                Console.WriteLine("Divide on 5");
            }
            else if (a % 3 == 0)
            {
                Console.WriteLine("Divide on 3");
            }
            else if (a % 6 == 0)
            {
                Console.WriteLine("Divide on 6");
            }
            else if (a % 9 == 0)
            {
                Console.WriteLine("Divide on 9");
            }
            else
            {
                Console.WriteLine("Do not divide on this nubers");
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            double number = double.Parse(Console.ReadLine());
            positive(number);
            simple(number);
            div(number);
        }
    }
}
