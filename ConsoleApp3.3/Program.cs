using System;
namespace ConsoleApp18
{
    class Program
    {
        double exp(double x)
        {
            if (x < 0) return 1 / exp(-x);
            double y = 2 * x, p = 1, s = 1, q = 0;
            while (p / s > 1e-19)
            {
                q++; p *= y / q;
                s += p;
            }
            return s;
        }
        static void Main()
        {
            double x, y; while (true)
            {
                Console.Write("x » ");
                x = double.Parse(Console.ReadLine());
                y = (x); Console.WriteLine
                (y + ", error=" + (y / Math.Exp(2 * x) - 1));
            }
        }
    }
}