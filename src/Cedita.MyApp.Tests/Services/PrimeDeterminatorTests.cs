using $ext_safeprojectname$.Abstractions;
using $ext_safeprojectname$.Services;
using Xunit;

namespace $safeprojectname$.Services
{
    public class PrimeDeterminatorTests
    {
        private readonly IPrimeNumberDeterminator primeNumberDeterminator;
        public PrimeDeterminatorTests()
        {
            this.primeNumberDeterminator = new PrimeNumberDeterminator();
        }

        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        [InlineData(11)]
        [InlineData(13)]
        [InlineData(17)]
        public void IsPrime_Valid(int primeNumber)
        {
            var isPrime = primeNumberDeterminator.IsPrime(primeNumber);
            Assert.True(isPrime, $"{primeNumber} should be prime.");
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(4)]
        [InlineData(6)]
        [InlineData(8)]
        [InlineData(9)]
        public void IsPrime_Invalid(int notPrimeNumber)
        {
            var isPrime = primeNumberDeterminator.IsPrime(notPrimeNumber);
            Assert.False(isPrime, $"{notPrimeNumber} should not be prime.");
        }
    }
}
