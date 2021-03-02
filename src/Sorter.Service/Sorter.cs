using Sorter.Service.Algorithms;
using Sorter.Service.Contracts;
using Sorter.Service.Interfaces;
using Sorter.Service.Validators;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sorter.Service
{
    public class Sorter : ISorter
    {
        public IEnumerable<SortResult> Sort(SortOptions sortOptions)
        {
            var sortOptionsValidator = new SortOptionsValidator();
            var sortOptionsValidatorResult = sortOptionsValidator.Validate(sortOptions);

            if (!sortOptionsValidatorResult.IsValid)
                throw new ApplicationException($"Invalid sort options provided: {sortOptionsValidatorResult.Errors.Single()}");

            return sortOptions.SortingAlgorithms.Select(algorithm => AlgorithmSelector(algorithm, sortOptions.Numbers.ToArray()));
        }

        private static SortResult AlgorithmSelector(Algorithm algorithm, int[] numbers)
            => algorithm switch
            {
                Algorithm.QuickSort => new QuickSort().Sort(numbers),
                Algorithm.BubbleSort => new BubbleSort().Sort(numbers),
                Algorithm.MergeSort => new MergeSort().Sort(numbers),
                Algorithm.InsertionSort => new InsertionSort().Sort(numbers),
                Algorithm.SelectionSort => new SelectionSort().Sort(numbers),
                Algorithm.HeapSort => new HeapSort().Sort(numbers),
                Algorithm.RadixSort => new RadixSort().Sort(numbers),
                Algorithm.BucketSort => new BucketSort().Sort(numbers),
                Algorithm.CountingSort => new CountingSort().Sort(numbers)
            };
    }
}
