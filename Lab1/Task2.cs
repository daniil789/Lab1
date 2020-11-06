using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point()
        {
            try
            {
                Console.WriteLine("Укажите точку: ");
                Console.WriteLine("Введите x...");
                X = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите y...");
                Y = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Error.ShowError();
            }
        }
    }

    class Circle
    {
        public int R { get; set; }
        public int X0 { get; set; }
        public int Y0 { get; set; }

        public Circle()
        {
            R = 5;
            X0 = 5;
            Y0 = 0;

        }

    }


    class Task2
    {
        public Task2()
        {
            string YN = string.Empty;
            while (YN != "N" && YN != "n")
            {
                var point = new Point();
                var circle = new Circle();

               Console.WriteLine(IsCircleContainsPoint(point, circle));



                Console.WriteLine("Попробовать ещё раз?(Y/N)");
                YN = Console.ReadLine();
            }


        }

        public bool IsCircleContainsPoint(Point point, Circle circle)
        {
            return Math.Pow(point.X - circle.X0, 2) + Math.Pow(point.Y - circle.Y0, 2) <= Math.Pow(circle.R, 2);
        }

    }
}
