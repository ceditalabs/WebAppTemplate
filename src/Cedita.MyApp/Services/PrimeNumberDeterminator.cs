using $safeprojectname$.Abstractions;
using System;
using System.Linq;

namespace $safeprojectname$.Services
{
    public class PrimeNumberDeterminator : IPrimeNumberDeterminator
    {
        public bool IsPrime(int number)
        {
            return number > 1 && Enumerable.Range(1, number)
                .Where(x => number % x == 0)
                .SequenceEqual(new[] { 1, number });
        }
    }
}
