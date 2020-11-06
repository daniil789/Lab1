using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            string operation = string.Empty;

            while (operation != "4")
            {
                Console.WriteLine($"Выберете номер задания: \n 1.Найти значение выражений  \n 2.Определить, пренадлежит ли точка области \n 3. Посчитать значение выражения \n 4.Завершить" );

                operation = Console.ReadLine();

                switch (operation)
                {
                    case "1":
                        var task1 = new Task1();
                        Console.Clear();
                        break;
                    case "2":
                        var task2 = new Task2();
                        Console.Clear();
                        break;
                    case "3":
                        var task3 = new Task3();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
