using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void Factorial(double nn, out double Y)
            {
                Y = 1;
                for (int i = 1; i <= nn; i++)
                {
                    Y = Y * i;

                }
            }

            void Stepen(double A, double j, out double Y)
            {
                Y = 1;
                for (int i = 1; i <= j; i++)
                { 
                 Y *= A;
                }
            }
            Console.WriteLine("Введите x и y: ");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите n и m: ");
            double n = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите a и c: ");
            double a = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            Stepen(x + y, n, out double S1);
            Stepen(c, m, out double S2);
            Factorial(y, out double P);
            double F = S1 + a * P / S2;
            Console.WriteLine($"F= {F}");
        }
    }
}
