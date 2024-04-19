using GearRatioGenerator;
using System.Diagnostics;
using System.Linq;

namespace GearRatioGeneratorTests
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Check Greatest Common Divisor function
        /// </summary>
        [TestMethod]
        public void GCDTest()
        {
            int gcd = CoprimeGenerator.GCD(4, 8);
            Assert.AreEqual(4, gcd);

            gcd = CoprimeGenerator.GCD(5, 8);
            Assert.AreEqual(1, gcd);
        }

        /// <summary>
        /// Coprimes should not share factors
        /// </summary>
        [TestMethod]
        public void CoprimeTest()
        {
            int[] calculated = CoprimeGenerator.GenerateCoprimes(5, 1, 10);
            int[] expected = [1, 2, 3, 4, 6, 7, 8, 9];
            Assert.IsTrue(calculated.SequenceEqual(expected));
            foreach (int i in calculated)
            {
                Assert.AreEqual(CoprimeGenerator.GCD(i, 5), 1);
            }

            calculated = CoprimeGenerator.GenerateCoprimes(20, 1, 30);
            expected = [1, 3, 7, 9, 11, 13, 17, 19, 21, 23, 27, 29];
            Assert.IsTrue(calculated.SequenceEqual(expected));
            foreach (int i in calculated)
            {
                Assert.AreEqual(CoprimeGenerator.GCD(i, 20), 1);
            }
        }
    }
}