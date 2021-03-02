using System;
using System.Collections.Generic;

namespace Sorter.Service.Contracts
{
    public sealed class SortResult
    {
        public Algorithm Algorithm { get; }
        public IEnumerable<int> SortedNumbers { get; }
        public TimeSpan Speed { get; }

        private SortResult(Algorithm algorithm, IEnumerable<int> sortedNumbers, TimeSpan speed)
        {
            Algorithm = algorithm;
            SortedNumbers = sortedNumbers;
            Speed = speed;
        }

        public static SortResult Create(Algorithm algorithm, IEnumerable<int> sortedNumbers, TimeSpan speed)
            => new SortResult(algorithm, sortedNumbers, speed);
    }
}
