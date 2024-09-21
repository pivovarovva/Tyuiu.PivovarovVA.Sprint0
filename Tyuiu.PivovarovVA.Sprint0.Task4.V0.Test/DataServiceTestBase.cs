using Tyuiu.PivovarovVA.Sprint.Task4.V0.Lib;

namespace Tyuiu.PivovarovVA.Sprint.Task4.V0.Test
{
    [TestClass]
    public class DataServiceTestBase
    {
        public void CheckedAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }
        public void CheckedDivisionValid() => Assert.That(DataService.Division(9, 3), Is.EqualTo(3));
        public void CheckedMultiplicationValid()
        {
            Assert.AreEqual(50, DataService.Multiplication(10, 5));
        }
         void CheckedSubtractionValid()
        {
            Assert.AreEqual(5, DataService.Subtraction(10, 5));
        }
        private void Setup()
        {
            SetDataServiceTest(new DataService());
        }

        private void SetDataServiceTest(DataService dataService)
        {
            throw new NotImplementedException();
        }
    }
}