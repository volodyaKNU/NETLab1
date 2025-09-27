using Lab1.logic_lab3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace TestLab3
{
    [TestClass]
    public sealed class TestTask1
    {
        [TestMethod]
        public void AllNumbersSuitable()
        {
            Lab3_iss1 specificNumbers = new(27, 54, 162);
            var res = specificNumbers.calculateNumbers();
            Assert.AreEqual(3, res);
        }
        [TestMethod]
        public void AnyNumbersRealatedSpecific()
        {
            Lab3_iss1 specificNumbers = new(2, 5, 8);
            var res = specificNumbers.calculateNumbers();
            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void OneNumberSpecific()
        {
            Lab3_iss1 specificNumbers = new(54, 5, 8);
            var res = specificNumbers.calculateNumbers();
            Assert.AreEqual(1, res);
        }
    }
}
