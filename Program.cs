using System;

namespace Algebra
{
    class Program
    {
        static void Main(string[] args)
        {
            double disc, deno, x1, x2;

            Console.WriteLine("Enter the value of A: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the value of B:");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the value of C:");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a == 0)
            {
                x1 = -c / b;
                Console.WriteLine("The roots are Linear:", x1);
            }
            else
            {
                disc = (b * b) - (4 * a * c);
                deno = 2 * a;
                if (disc > 0)
                {
                    Console.WriteLine("THE ROOTS ARE REAL AND DISTINCT ROOTS");
                    x1 = (-b / deno) + (Math.Sqrt(disc) / deno);
                    x2 = (-b / deno) - (Math.Sqrt(disc) / deno);
                    Console.WriteLine("THE ROOTS ARE... " + x1 + " and " + x2);
                }
                else if (disc == 0)
                {
                    Console.WriteLine("THE ROOTS ARE REPEATED ROOTS");
                    x1 = -b / deno;
                    Console.WriteLine("THE ROOT IS...: " + x1);
                }
                else
                {
                    Console.WriteLine("THE ROOTS ARE IMAGINARY ROOTS\n");
                    x1 = -b / deno;
                    x2 = ((Math.Sqrt((4 * a * c) - (b * b))) / deno);
                    Console.WriteLine("THE ROOT 1: " + x1 + "+i" + x2);
                    Console.WriteLine("THE ROOT 2:" + x1 + "-i" + x2);
                }
            }

        }
    }
}
