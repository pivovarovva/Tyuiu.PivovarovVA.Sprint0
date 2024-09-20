using Tyuiu.PivovarovVA.Sprint0.Task3.V0.Lib;
using System;

namespace Tyuiu.PivovarovVA.Sprint0.Task3.V0.Tests
{
    public class DataServiceTest
    {
        public void CheckedValid()
        {
            int result = DataService.Sum(7, 7);
            if (result == 14)
            {
                Console.WriteLine("Тест пройден.");
            }
            else
            {
                Console.WriteLine("Тест не пройден.");
            }
        }
    }
}
