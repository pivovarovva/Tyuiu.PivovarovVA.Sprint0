using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PivovarovVA.Sprint0.Task5.V0.Lib;

namespace Tyuiu.PivovarovVA.Sprint0.Task5.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            // Пример линейной структуры
            Console.WriteLine("1 + 5 = " + DataService.Addition(1, 5));
            Console.WriteLine("15 - 5 = " + DataService.Subtraction(15, 5));
            Console.WriteLine("10 * 10 = " + DataService.Multiplication(10, 10));

            // Пример разветвляющейся структуры находится в библиотеке классов в методе Division
            Console.WriteLine("5 / 0 = " + DataService.Division(5, 0));

            Console.ReadKey();
        }
    }
}

