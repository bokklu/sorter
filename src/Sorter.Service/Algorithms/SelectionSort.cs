using Sorter.Service.Contracts;

namespace Sorter.Service.Algorithms
{
    public class SelectionSort : BaseAlgorithm
    {
        public override SortResult Sort(int[] numbers)
            => HandleSort(() =>
            {
                for (int i = 0; i < numbers.Length - 1; ++i)
                {
                    var minIndex = i;

                    for (int j = i + 1; j < numbers.Length; ++j)
                        if (numbers[j] < numbers[minIndex])
                            minIndex = j;

                    var temp = numbers[minIndex];
                    numbers[minIndex] = numbers[i];
                    numbers[i] = temp;
                }

                return numbers;
            },
            Algorithm.SelectionSort);
    }
}
