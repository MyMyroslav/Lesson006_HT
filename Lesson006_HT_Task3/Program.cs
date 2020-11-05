using System;

namespace Lesson006_HT_Task3
{
    class MainClass
    {
        static int add (int a, int b)
        {
            int solv = a + b;
            return solv;
        }
        static int sub(int a, int b)
        {
            int solv = a - b; 
            return solv;
        }
        static int mul(int a, int b)
        {
            int solv = a * b;
            return solv;
        }
        static int div(int a, int b)
        {
            if (b != 0)
            {
                int solv = a / b;
                return solv;
            }
            else
            {
                Console.WriteLine("Cant divide on 0");
                return 0;
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b");
            int b = int.Parse(Console.ReadLine());
            int adda = add(a, b);
            int suba = sub(a, b);
            int mula = mul(a, b);
            int diva = div(a, b);
            Console.WriteLine($"Add = {adda}, Mul = {mula}, Sub = {suba}, Div = {diva}");
        }
    }
}
