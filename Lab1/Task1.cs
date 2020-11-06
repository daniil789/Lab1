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

        public Task1()
        {
            string operation = string.Empty;

            while (operation != "5")
            {
                Console.WriteLine("Выберете выражение, которое хотите вычислить: \n 1.m+--n \n 2.m++<--n \n 3.--m>n— \n 4.Arccos(x+x2) \n 5.Выбрать другое задание");

                operation = Console.ReadLine();

                switch (operation)
                {
                    case "1":
                        N1();
                        Console.Clear();
                        break;
                    case "2":
                        N2();
                        Console.Clear();
                        break;
                    case "3":
                        N3();
                        Console.Clear();
                        break;
                    case "4":
                        N4();
                        Console.Clear();
                        break;
                    case "5":
                        return;
                }
            }

        }

        private static void N1()
        {
            string YN = string.Empty;
            while (YN != "N" && YN != "n")
            {
                try
                {
                    Console.WriteLine("Вычисляется выражение m+--n, введите m...");
                    var m = EnterNumber();

                    Console.WriteLine("Вычисляется выражение m+--n, введите n...");
                    var n = EnterNumber();

                    Console.WriteLine($"m+--n = {m + --n} \n");
                }
                catch
                {
                    Console.WriteLine("Введены некорректные данные.\n");
                }

                Console.WriteLine("Попробовать ещё раз?(Y/N)");
                YN = Console.ReadLine();

            }
        }

        private static void N2()
        {
            string YN = string.Empty;
            while (YN != "N" && YN != "n")
            {
                try
                {
                    Console.WriteLine("Вычисляется выражение m++<--n, введите m...");
                    var m = EnterNumber();

                    Console.WriteLine("Вычисляется выражение m++<--n, введите n...");
                    var n = EnterNumber();

                    Console.WriteLine($"m++<--n = {m++ < --n} \n");
                }
                catch
                {
                    Console.WriteLine("Введены некорректные данные.\n");
                }

                Console.WriteLine("Попробовать ещё раз?(Y/N)");
                YN = Console.ReadLine();

            }
        }

        private static void N3()
        {
            string YN = string.Empty;
            while (YN != "N" && YN != "n")
            {
                try
                {
                    Console.WriteLine("Вычисляется выражение --m>n—, введите m...");
                    var m = EnterNumber();

                    Console.WriteLine("Вычисляется выражение --m>n—, введите n...");
                    var n = EnterNumber();

                    Console.WriteLine($"m++<--n = {--m > n--} \n");
                }
                catch
                {
                    Console.WriteLine("Введены некорректные данные.\n");
                }

                Console.WriteLine("Попробовать ещё раз?(Y/N)");
                YN = Console.ReadLine();

            }
        }

        private static void N4()
        {
            string YN = string.Empty;
            while (YN != "N" && YN != "n")
            {
                try
                {
                    Console.WriteLine("Вычисляется выражение Arccos(x+x2), введите x...");
                    var x = EnterNumber();

                    Console.WriteLine($"Arccos(x+x2) = {Math.Acos(x+x*x)} \n");
                }
                catch
                {
                    Console.WriteLine("Введены некорректные данные.\n");
                }

                Console.WriteLine("Попробовать ещё раз?(Y/N)");
                YN = Console.ReadLine();

            }
        }

    }
}
