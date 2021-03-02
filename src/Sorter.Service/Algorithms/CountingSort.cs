using Sorter.Service.Contracts;
using System.Linq;

namespace Sorter.Service.Algorithms
{
    public class CountingSort : BaseAlgorithm
    {
        public override SortResult Sort(int[] numbers)
            => HandleSort(() =>
            {
                var sortedNumbers = new int[numbers.Length];
                var counts = new int[numbers.Max() + 1];

                for (int i = 0; i < numbers.Length; ++i)
                    counts[numbers[i]]++;

                for (int i = 1; i < counts.Length; ++i)
                    counts[i] += counts[i - 1];

                for (int i = numbers.Length - 1; i >= 0; --i)
                {
                    var value = numbers[i];
                    sortedNumbers[counts[value] - 1] = numbers[i];
                    counts[value]--;
                }

                return sortedNumbers;
            },
            Algorithm.CountingSort);

        public void LeastSignificantCountingSort(int[] numbers, int place)
        {
            var max = numbers.Max();
            var sortedNumbers = new int[numbers.Length];
            var counts = new int[max + 1];

            for (int i = 0; i < numbers.Length; ++i)
                counts[(numbers[i] / place) % 10]++;

            for (int i = 1; i < 10; ++i)
                counts[i] += counts[i - 1];

            for (int i = numbers.Length - 1; i >= 0; --i)
            {
                var countIndex = (numbers[i] / place) % 10;
                sortedNumbers[counts[countIndex] - 1] = numbers[i];
                counts[countIndex]--;
            }

            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = sortedNumbers[i];
        }
    }
}
