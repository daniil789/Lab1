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

    class Triangle
    {
        public int x1 { get; set; }
        public int y1 { get; set; }
        public int x2 { get; set; }
        public int y2 { get; set; }
        public int x3 { get; set; }
        public int y3 { get; set; }

        public Triangle()
        {
            x1 = -10;
            y1 = 0;

            x2 = 0;
            y2 = 5;

            x3 = 0;
            y3 = -5;

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
                var triangle = new Triangle();

                var isTriangleContainsPoint = IsTriangleContainsPoint(point, triangle);
                var isCircleContainsPoint = IsCircleContainsPoint(point, circle);

                if (isCircleContainsPoint || isTriangleContainsPoint)
                    Console.WriteLine("Точка внутри области");
                else
                    Console.WriteLine("Точка за пределами области");

                Console.WriteLine("Попробовать ещё раз?(Y/N)");
                YN = Console.ReadLine();
            }
        }

        public bool IsCircleContainsPoint(Point point, Circle circle)
        {
            return Math.Pow(point.X - circle.X0, 2) + Math.Pow(point.Y - circle.Y0, 2) <= Math.Pow(circle.R, 2);
        }

        public bool IsTriangleContainsPoint(Point point, Triangle triangle)
        {
            var x = (triangle.x1 - point.X) * (triangle.y2 - triangle.y1) - (triangle.x2 - triangle.x1) * (triangle.y1 - point.Y);
            var y = (triangle.x2 - point.X) * (triangle.y3 - triangle.y2) - (triangle.x3 - triangle.x2) * (triangle.y2 - point.Y);
            var z = (triangle.x3 - point.X) * (triangle.y1 - triangle.y3) - (triangle.x1 - triangle.x3) * (triangle.y3 - point.Y);

            return x >= 0 && y >= 0 && z >= 0 || x <= 0 && y <= 0 && z <= 0;
        }

    }
}
