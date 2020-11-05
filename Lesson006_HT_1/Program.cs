using System;

namespace Lesson006_HT_1
{
    class MainClass
    {
        static int Calculate (int a, int b, int c)
        {
            int Res = (a + b + c) / 2;
            return Res;
        }
        public static void Main(string[] args)
        {
            int calculate = Calculate(2, 4, 6);
            Console.WriteLine(calculate);
        }
    }
}
