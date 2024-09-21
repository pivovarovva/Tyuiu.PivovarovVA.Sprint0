using System;

namespace Tyuiu.PivovarovVA.Sprint0.Task5.V0.Lib
{
    public class DataService
    {
        public static int Addition(int a, int b)
        {
            return a + b;
        }

        public static int Subtraction(int a, int b)
        {
            return a - b;
        }

        public static int Multiplication(int a, int b)
        {
            return a * b;
        }

        public static double Division(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Ошибка: деление на ноль.");
                return -1; // Возвращаем -1 или можно использовать Exception
            }
            return (double)a / b; // Приводим к double для точного деления
        }
    }
}
