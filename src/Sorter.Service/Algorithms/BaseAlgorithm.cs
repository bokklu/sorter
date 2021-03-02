using Sorter.Service.Contracts;
using Sorter.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Sorter.Service.Algorithms
{
    public abstract class BaseAlgorithm : IAlgorithmSorter
    {
        public abstract SortResult Sort(int[] numbers);

        protected static SortResult HandleSort(Func<IList<int>> fn, Algorithm algorithm)
        {
            var stopwatch = Stopwatch.StartNew();

            var sortResult = fn();

            stopwatch.Stop();

            return SortResult.Create(algorithm, sortResult, stopwatch.Elapsed);
        }
    }
}
