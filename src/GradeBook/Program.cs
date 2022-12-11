using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 19.25;
            double y = 18.75;
            double sum = x + y;

            Console.WriteLine($"Average is {sum / 2}.");

            var result = 0.0;
            var numbers = new[] { 12.5, 13.75, 16 };
            foreach (var number in numbers)
            {
                result += number;
            }
            Console.WriteLine($"result is {result}");

            List<double> grades = new List<double>() { 12.5, 13.75, 16 };
            grades.Add(20.45);

            var result2 = 0.0;
            foreach (var number in grades)
            {
                result2 += number;
            }
            double average = result2 / grades.Count;
            Console.WriteLine($"result2 is {result2}");
            Console.WriteLine($"average is {average:N2}");
        }
    }
}
