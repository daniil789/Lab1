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

            var result = (Math.Pow(a - b, 3) - Math.Pow(a, 3)) / (Math.Pow(-b, 3) + 3 * a * b * b - 3 * a * a * b);

            Console.WriteLine($"Значение выражения = {result}");

            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}
