using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Task1
    {
        private static double EnterNumber()
        {
            return Convert.ToDouble(Console.ReadLine());

        }

        static double n;
        static double m;
        static double x;

        public Task1()
        {
            string YN = string.Empty;
            string operation = string.Empty;
            while (YN != "N" && YN != "n")
            {
                try
                {
                    Console.Write("m = ");
                    m = EnterNumber();
                    Console.Write("n = ");
                    n = EnterNumber();
                    Console.Write("x = ");
                    x = EnterNumber();
                    Console.WriteLine();

                    for (int i = 1; i <= 4; i++)
                    {
                        Console.WriteLine(GetResult(i));
                        Console.WriteLine();
                    }
                }
                catch
                {
                    Error.ShowError();
                }

                Console.WriteLine("Попробовать ещё раз?(Y/N)");
                YN = Console.ReadLine();
            }
        }

        public static object GetResult(int numberCase)
        {
            switch (numberCase)
            {
                case 1:
                    Console.Write("m+--n = ");
                    return m + --n;
                case 2:
                    Console.Write("m++<--n - ");
                    return m++ < --n;
                case 3:
                    Console.Write("--m>n-- - ");
                    return --m > n--;
                case 4:
                    Console.Write("arcos(x + x^2) = ");
                    return N4();
                default:
                    return null;
            }
        }

        private static double N4()
        {
            return Math.Acos(x + x * x);
        }

    }
}

