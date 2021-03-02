using Sorter.Service.Contracts;
using System.Linq;

namespace Sorter.Service.Algorithms
{
    public class RadixSort : BaseAlgorithm
    {
        public override SortResult Sort(int[] numbers)
            => HandleSort(() =>
            {
                var max = numbers.Max();
                var countingSort = new CountingSort();

                for (int place = 1; max / place > 0; place *= 10)
                    countingSort.LeastSignificantCountingSort(numbers, place);

                return numbers;
            },
            Algorithm.RadixSort);
    }
}
