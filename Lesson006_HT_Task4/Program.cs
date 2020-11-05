using System;

namespace Lesson006_HT_Task4
{
    class MainClass
    {
        static double convertToDollar (double hryvnas)
        {
            double solv = hryvnas * (double)28.5074;
            return solv;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter hryvnas:");
            double hryvnas = double.Parse(Console.ReadLine());
            double results = convertToDollar(hryvnas);
            Console.WriteLine($"{results}");
        }
    }
}
