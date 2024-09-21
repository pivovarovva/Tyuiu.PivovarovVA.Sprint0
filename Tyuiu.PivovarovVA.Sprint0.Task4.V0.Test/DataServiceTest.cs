using Tyuiu.PivovarovVA.Sprint.Task4.V0.Lib;

namespace Tyuiu.PivovarovVA.Sprint.Task4.V0.Test
{
    [TestClass]
    public partial class DataServiceTest
    {
        private DataService DataService;

        [TestInitialize]
        public void Setup()
        {
            DataService = new DataService();
        }

        [TestMethod]
        public void CheckedAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }

        [TestMethod]
        public void CheckedSubtractionValid()
        {
            Assert.AreEqual(5, DataService.Subtraction(10, 5));
        }

        [TestMethod]
        public void CheckedMultiplicationValid()
        {
            Assert.AreEqual(50, DataService.Multiplication(10, 5));
        }

        [TestMethod]
        public void CheckedDivisionValid()
        {
            Assert.AreEqual(1, DataService.Division(5, 5));
        }
    }

    internal class TestClassAttribute : Attribute
    {
    }

    internal class TestMethodAttribute : Attribute
    {
    }
}


