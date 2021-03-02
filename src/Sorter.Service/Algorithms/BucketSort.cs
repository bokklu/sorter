using Sorter.Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sorter.Service.Algorithms
{
    public class BucketSort : BaseAlgorithm
    {
        public override SortResult Sort(int[] numbers)
            => HandleSort(() =>
            {
                var sortedNumbers = new List<int>();
                var buckets = new List<int>[numbers.Length];

                for (int i = 0; i < buckets.Length; ++i)
                    buckets[i] = new List<int>();

                for (int i = 0; i < numbers.Length; ++i)
                {
                    var bucketIndex = (int)Math.Floor((double)buckets.Length * numbers[i] / (numbers.Max() + 1));
                    buckets[bucketIndex].Add(numbers[i]);
                }

                var insertionSort = new InsertionSort();

                for (int i = 0; i < buckets.Length; ++i)
                {
                    var temp = insertionSort.Sort(buckets[i].ToArray());
                    sortedNumbers.AddRange(temp.SortedNumbers);
                }

                return sortedNumbers;
            },
            Algorithm.BucketSort);
    }
}
