using System;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test 57
            Console.WriteLine(Task57(0.000541, 9.9));

            // Test 164
            Console.WriteLine(Task164(1, 2, 3));
            Console.WriteLine(Task164(1, 3, 2));
            Console.WriteLine(Task164(2, 1, 3));
            Console.WriteLine(Task164(2, 3, 1));
            Console.WriteLine(Task164(3, 1, 2));
            Console.WriteLine(Task164(3, 2, 1));
        }

        // Task 57
        static string Task57(double a, double b)
        {
            if (a == 0)
                return "Число a не может быть равным 0!";
            else
                return $"Число {a}" + (b % a <= 0.0001 ? " " : " не ") + $"является делителем числа {b}";
        }

        // Task 164
        static string Task164(double a, double b, double c)
        {
            double minV, avgV, maxV;

            minV = Math.Min(Math.Min(a, b), c);
            maxV = Math.Max(Math.Max(a, b), c);

            if (maxV == a)
                avgV = Math.Max(b, c);
            else
                avgV = Math.Max(Math.Min(b, c), a);

            return $"Min={minV}, Avg={avgV}, Max={maxV}";
        }


    }
}

