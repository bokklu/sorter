using Sorter.Service.Contracts;

namespace Sorter.Service.Algorithms
{
    public class InsertionSort : BaseAlgorithm
    {
        public override SortResult Sort(int[] numbers)
            => HandleSort(() =>
            {
                for (int i = 0; i < numbers.Length - 1; ++i)
                {
                    for (int j = i + 1; j > 0; --j)
                    {
                        if (numbers[j - 1] > numbers[j])
                        {
                            var temp = numbers[j - 1];
                            numbers[j - 1] = numbers[j];
                            numbers[j] = temp;
                        }
                    }
                }

                return numbers;
            },
            Algorithm.InsertionSort);
    }
}
