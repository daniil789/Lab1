using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Task3
    {
        public Task3()
        {
            var a = 100;
            var b = 0.001;

            var numerator = (float)(Math.Pow(a - b, 3) - Math.Pow(a, 3));
            var denominator = (float)(Math.Pow(-b, 3) + 3 * a * b * b - 3 * a * a * b);

            var result = numerator / denominator;

            Console.WriteLine($"Значение выражения = {result}");

            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}
