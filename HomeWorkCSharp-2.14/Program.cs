using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCSharp_2._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.14. Даны основания и высота равнобедренной трапеции. Найти ее периметр.
            Console.WriteLine("Программа для вычисления периметра равнобедренной трапеции по основаниям и высоте.");
        imputA:
            Console.Write("Введите основание \"a\": ");
            double a = Convert.ToDouble(Console.ReadLine());
            if (a > 0)
            {
            imputB:
                Console.Write("Введите основание \"b\": ");
                double b = Convert.ToDouble(Console.ReadLine());
                if (b > 0)
                {
                imputH:
                    Console.Write("Введите высоту \"h\": ");
                    double h = Convert.ToDouble(Console.ReadLine());
                    if (h > 0)
                    {
                        double P = a + b + 2 * Math.Sqrt(Math.Pow(h, 2) + Math.Pow((a - b), 2) / 4);
                        Console.WriteLine("Периметр равнобедренной трапеции павен: " + P.ToString("#.##"));
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Введено неверное значение.");
                        goto imputH;
                    }
                }
                else
                {
                    Console.WriteLine("Введено неверное значение.");
                    goto imputB;
                }
            }
            else
            {
                Console.WriteLine("Введено неверное значение.");
                goto imputA;
            }
        }
    }
}
