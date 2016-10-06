using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getPI__
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to calcPI()! Would you like to calculate PI using the Leibniz formula (\"LF\") or use a geometric approach (\"G\")?");
            bool valid = false;
            decimal pi = 0;
            ulong steps = 0;
            while (!valid)
            {
                switch (Console.ReadLine())
                {
                    case "LF":
                        Console.Write("Please enter the number of iterations of the Leibniz formula:");
                        steps = ulong.Parse(Console.ReadLine());
                        pi = getPILeibniz(steps);
                        valid = true;
                        break;
                    case "G":
                        Console.Write("Please enter the number of rectangles you want to fit into one quarter of the circle:");
                        steps = ulong.Parse(Console.ReadLine());
                        pi = getPIGeometric(steps);
                        valid = true;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }
            }
            Console.WriteLine($"PI ~ {pi}");
            Console.ReadKey();
        }

        static decimal getPILeibniz(ulong steps)
        {
            decimal piQuarters = 0;
            decimal sign = 1;
            for (ulong i = 1; i <= steps; i += 2)
            {
                piQuarters += sign / i;
                sign = -sign;
            }
            return 4 * piQuarters;
        }

        static decimal getPIGeometric(ulong steps)
        {
            decimal piQuarters = 0;
            decimal width = Decimal.Divide(1,steps);
            for (ulong i = 1; i <= steps; i++)
            {
                piQuarters += (decimal)((double)width * Math.Sqrt(1 - Math.Pow(((double)width * i),2)));
            }
            return 4 * piQuarters;
        }
    }
}
