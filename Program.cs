using System;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Task57(3.3, 9.9));
        }

        static string Task57(double a, double b)
        {
            if (a == 0)
                return "Число a не может быть равным 0!";
            else
                return $"Число {a}" + (b % a <= 0.0001 ? " " : " не ") + $"является делителем числа {b}";
        }
    }
}

