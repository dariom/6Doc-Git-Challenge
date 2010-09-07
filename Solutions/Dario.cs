using NUnit.Framework;

namespace Solutions
{
    [TestFixture]
    public class Dario
    {
        [Test]
        public void My_Solution_For_Solving_13195()
        {
            Assert.AreEqual(29, GetMaxPrime(13195));
        }

        [Test]
        public void My_Solution_For_Solving_600851475143()
        {
            Assert.AreEqual(6857, GetMaxPrime(600851475143));
        }

        long GetMaxPrime(long number)
        {
            long maxPrime = 2, candidate = 2;
            while (candidate <= number)
            {
                if (IsPrime(candidate) && (number % candidate == 0))
                {
                    number = number / candidate;
                    maxPrime = System.Math.Max(maxPrime, candidate);
                }

                candidate++;
            }

            return maxPrime;
        }

        bool IsPrime(long number)
        {
            bool isPrime = true;
            long divisor = 2;
            while (divisor * divisor <= number)
            {
                isPrime = (number % divisor != 0);
                divisor++;
            }

            return isPrime;
        }
    }
}
