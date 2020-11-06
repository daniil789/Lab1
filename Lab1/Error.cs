using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
   static class Error
    {
        public static void ShowError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Введены некорректные данные");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
