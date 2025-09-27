using Lab1.logic_lab3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace TestLab3
{
    [TestClass]
    public sealed class TestTask2
    {
        [TestMethod]
        public void Range_1_To_20_Returns_4()
        {
            Task2 specificNumbers = new(1,20);
            var res = specificNumbers.FindTargetNumbersCount();
            Assert.AreEqual(4, res);
        }
        [TestMethod]
        public void Range_1_To_5_Returns_1()
        {
            int result = new Task2(1,5).FindTargetNumbersCount();
            Assert.AreEqual(1, result); 
        }
        [TestMethod]
        public void Range_12_To_13_Returns_0()
        {
            int result = new Task2(12,13).FindTargetNumbersCount();
            Assert.AreEqual(0, result);
        }
    }
}
