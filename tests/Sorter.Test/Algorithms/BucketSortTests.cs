using NUnit.Framework;
using Sorter.Service.Algorithms;
using Sorter.Service.Interfaces;
using System.Linq;

namespace Sorter.Test.Algorithms
{
    [TestFixture]
    internal sealed class BucketSortTests
    {
        private IAlgorithmSorter _bucketSort;

        [SetUp]
        public void SetUp()
        {
            _bucketSort = new BucketSort();
        }

        [TestCase(new int[1] { 10 }, ExpectedResult = new int[1] { 10 })]
        [TestCase(new int[5] { 10, 7, 3, 5, 4 }, ExpectedResult = new int[5] { 3, 4, 5, 7, 10 })]
        [TestCase(new int[10] { 2932, 2, 58, 10, 3000, 236, 1, 43, 3, 3001 }, ExpectedResult = new int[10] { 1, 2, 3, 10, 43, 58, 236, 2932, 3000, 3001 })]
        public int[] BucketSort_Success(int[] input) => _bucketSort.Sort(input).SortedNumbers.ToArray();
    }
}
