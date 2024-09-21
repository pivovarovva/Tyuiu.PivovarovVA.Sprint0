using System;
using Tyuiu.PivovarovVA.Sprint.Task4.V0.Lib;

namespace Tyuiu.PivovarovVA.Sprint0.Task4.V0
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Вызовы методов из DataService
            Console.WriteLine(DataService.Addition(1, 5));
            Console.WriteLine(DataService.Subtraction(15, 5));
            Console.WriteLine(DataService.Multiplication(10, 10));
            Console.WriteLine(DataService.Division(5, 5));

            Console.ReadKey(); // Ожидание нажатия клавиши
        }
    }
}
