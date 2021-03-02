using Sorter.Service.Contracts;

namespace Sorter.Service.Algorithms
{
    public class HeapSort : BaseAlgorithm
    {
        public override SortResult Sort(int[] numbers)
            => HandleSort(() => ExecuteHeapSort(numbers), Algorithm.HeapSort);

        private int[] ExecuteHeapSort(int[] numbers)
        {
            for (int i = numbers.Length / 2 - 1; i >= 0; --i)
                Heapify(numbers, numbers.Length, i);

            for (int i = numbers.Length - 1; i > 0; --i)
            {
                var temp = numbers[0];
                numbers[0] = numbers[i];
                numbers[i] = temp;

                Heapify(numbers, i, 0);
            }

            return numbers;
        }

        private void Heapify(int[] arr, int maxHeap, int index)
        {
            var left = 2 * index + 1;
            var right = 2 * index + 2;
            var parent = index;

            if (left < maxHeap && arr[left] > arr[parent])
                parent = left;

            if (right < maxHeap && arr[right] > arr[parent])
                parent = right;

            if (parent != index)
            {
                var temp = arr[index];
                arr[index] = arr[parent];
                arr[parent] = temp;

                Heapify(arr, maxHeap, parent);
            }
        }
    }
}
