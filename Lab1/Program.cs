using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            string operation = string.Empty;

            while (operation != "5")
            {
                Console.WriteLine($"Выберете номер задания: \n 1.Найти значение выражений  \n 2.");

                operation = Console.ReadLine();

                switch (operation)
                {
                    case "1":
                        var task1 = new Task1();
                        Console.Clear();
                        break; 
                }
            }
        }
    }
}
