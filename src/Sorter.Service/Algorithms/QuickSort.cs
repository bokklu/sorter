using Sorter.Service.Contracts;

namespace Sorter.Service.Algorithms
{
    public class QuickSort : BaseAlgorithm
    {
        public override SortResult Sort(int[] numbers) 
            => HandleSort(() => ExecuteQuickSort(numbers, 0, numbers.Length - 1), Algorithm.QuickSort);

        private static int[] ExecuteQuickSort(int[] numbers, int left, int right)
        {
            if (left < right)
            {
                var pivotIndex = Partition(numbers, left, right);

                ExecuteQuickSort(numbers, left, pivotIndex - 1);
                ExecuteQuickSort(numbers, pivotIndex + 1, right);
            }

            return numbers;
        }

        private static int Partition(int[] arr, int left, int right)
        {
            var pivot = arr[right];
            var i = left;

            for (int j = left; j < right; j++)
            {
                if (arr[j] < pivot)
                {
                    var tempInner = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tempInner;
                    i++;
                }
            }

            var tempOuter = arr[i];
            arr[i] = arr[right];
            arr[right] = tempOuter;

            return i;
        }
    }
}
