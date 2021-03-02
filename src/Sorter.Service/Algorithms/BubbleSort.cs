using Sorter.Service.Contracts;

namespace Sorter.Service.Algorithms
{
    public class BubbleSort : BaseAlgorithm
    {
        public override SortResult Sort(int[] numbers)
            => HandleSort(() =>
            {
                for (int i = 0; i < numbers.Length - 1; ++i)
                {
                    for (int j = 0; j < numbers.Length - i - 1; ++j)
                    {
                        if (numbers[j] > numbers[j + 1])
                        {
                            var temp = numbers[j];
                            numbers[j] = numbers[j + 1];
                            numbers[j + 1] = temp;
                        }
                    }
                }

                return numbers;
            },
            Algorithm.BubbleSort);
    }
}
