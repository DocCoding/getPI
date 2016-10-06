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
            while (!valid)
            {
                switch (Console.ReadLine())
                {
                    case "LF":
                        Console.Write("Please enter the number of iterations of the Leibniz formula:");
                        ulong steps = ulong.Parse(Console.ReadLine());
                        double pi = getPILeibniz(steps);
                        Console.WriteLine($"PI ~ {pi}");
                        valid = true;
                        break;
                    case "G":

                        valid = true;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }
            }
            Console.ReadKey();
        }

        static double getPILeibniz(ulong steps)
        {
            double piQuarters = 0;
            double sign = 1;
            for (ulong i = 1; i <= steps; i += 2)
            {
                piQuarters += sign / i;
                sign = -sign;
            }
            return 4 * piQuarters;
        }

        static double getPiGeometric(double width)
        {
            double piQuarters = 0;

            return 4 * piQuarters;
        }
    }
}
