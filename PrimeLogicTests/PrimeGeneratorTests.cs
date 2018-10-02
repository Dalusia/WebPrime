using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeLogic;

namespace PrimeLogicTests
{
    [TestClass]
    public class PrimeGeneratorTests
    {
        private List<int> _primes;

        private void InitPrimes(int primeCount)
        {
            var gen = new PrimeGenerator();
            _primes = gen.FindPrimes(primeCount);
        }

        [TestMethod]
        public void PrimeGenerator_GenerateZeroPrimes_ReturnsEmptyList()
        {
            InitPrimes(0);
            Assert.AreEqual(0, _primes.Count);
        }

        [TestMethod]
        public void PrimeGenerator_GenerateOnePrime_ReturnsSinglePrimeValueTwo()
        {
            InitPrimes(1);
            CollectionAssert.AreEqual(new int[] { 2 }, _primes);
        }

        [TestMethod]
        public void PrimeGenerator_GenerateFivePrimes_ReturnsCorrectValues()
        {
            InitPrimes(5);
            CollectionAssert.AreEqual(new int[] { 2, 3, 5, 7, 11 }, _primes);
        }
    }
}
