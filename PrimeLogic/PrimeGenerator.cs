using System;
using System.Collections.Generic;

namespace PrimeLogic
{
    public class PrimeGenerator
    {
        public List<int> FindPrimes(int numberOfPrimes)
        {
            var primes = new List<int>();
            LoopToFindPrimes(numberOfPrimes, primes);
            return primes;
        }

        private static void LoopToFindPrimes(int numberOfPrimes, List<int> primes)
        {
            int p = 2;
            while (numberOfPrimes > 0)
            {
                if (IsPrime(p)) {
                    primes.Add(p);
                    numberOfPrimes--;
                }

                p++;
            }
        }

        private static bool IsPrime(int numberToTest)
        {
            for (int i = 2; i < numberToTest; i++)
                if (numberToTest % i == 0) return false;
            return true;
        }
    }
}
