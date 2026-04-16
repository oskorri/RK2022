 using System;

namespace RK2022
{
    class Program
    {
        static void Main(string[] args)
        {
            // ax2 + bx + c = 0
            double a, b, c;

            Console.WriteLine("ax^2+bx+c=0");
            Console.WriteLine("Podaj a(x^2)");
            a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj b(x)");
            b = Double.Parse(Console.ReadLine()); 
            Console.WriteLine("Podaj c");
            c = Double.Parse(Console.ReadLine());

            double delta = b * b - 4 * a * c;

            if (delta >= 0)
            {
                double x1 = (-b - Math.Sqrt(delta)) / 2 * a;
                double x2 = (-b + Math.Sqrt(delta)) / 2 * a;

                Console.WriteLine("x1={0} x2={1}", x1, x2);
            } else
            {
                Console.WriteLine("brak rozwiązań");
            }            

        }
    }
}
