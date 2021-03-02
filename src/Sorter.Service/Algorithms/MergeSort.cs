using Sorter.Service.Contracts;
using System;

namespace Sorter.Service.Algorithms
{
    public class MergeSort : BaseAlgorithm
    {
        public override SortResult Sort(int[] numbers)
            => HandleSort(() => ExecuteMergeSort(numbers, 0, numbers.Length - 1), Algorithm.MergeSort);

        private static int[] ExecuteMergeSort(int[] numbers, int left, int right)
        {
            if (left < right)
            {
                var middle = (left + right) / 2;

                ExecuteMergeSort(numbers, left, middle);
                ExecuteMergeSort(numbers, middle + 1, right);

                Merge(numbers, left, middle, right);
            }

            return numbers;
        }

        private static void Merge(int[] arr, int left, int middle, int right)
        {
            var leftArray = new int[middle - left + 1];
            var rightArray = new int[right - middle];

            Array.Copy(arr, left, leftArray, 0, middle - left + 1);
            Array.Copy(arr, middle + 1, rightArray, 0, right - middle);

            int i = 0;
            int j = 0;
            for (int k = left; k < right + 1; k++)
            {
                if (i == leftArray.Length)
                {
                    arr[k] = rightArray[j];
                    j++;
                }
                else if (j == rightArray.Length)
                {
                    arr[k] = leftArray[i];
                    i++;
                }
                else if (leftArray[i] <= rightArray[j])
                {
                    arr[k] = leftArray[i];
                    i++;
                }
                else
                {
                    arr[k] = rightArray[j];
                    j++;
                }
            }
        }
    }
}
