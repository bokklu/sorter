![Sorter](https://i.imgur.com/sUgVSLZ.png)

# Sorter
A console application implementing some of the popular sorting algorithms.

## Usage
### Command
```shell
dotnet run -a quicksort,bubblesort,radixsort,bucketsort -n 10,7,3,6,2,5,1
```
### Result
```shell
Algorithm: QuickSort,  Sorted Numbers: [1,2,3,5,6,7,10], Speed: 0.393ms
Algorithm: BubbleSort, Sorted Numbers: [1,2,3,5,6,7,10], Speed: 0.2868ms
Algorithm: RadixSort,  Sorted Numbers: [1,2,3,5,6,7,10], Speed: 0.6176ms
Algorithm: BucketSort, Sorted Numbers: [1,2,3,5,6,7,10], Speed: 1.0264ms
```
## The implemented sorting algorithms:
### BubbleSort
Bubble sort is a comparison sorting algorithm that repeatedly steps through the list, compares adjacent elements and swaps them if they are in the wrong order. The pass through is repeated until the list is sorted. The algorithm is named for the way smaller or larger elements "bubble" to the top of the list.

- Time Complexity:
  - Best Case: 0(n)
  - Worst Case: O(n²)
  - Average Case: O(n²)

- Space Complexity: O(1)

### SelectionSort
Selection sort is another comparison sorting algorithm in which it sorts array by repeatedly finding the minimum element from the unsorted part and putting it at the beginning (the sorted part).

- Time Complexity:
  - Best Case:  O(n²)
  - Worst Case: O(n²)
  - Average Case: O(n²)

- Space Complexity: O(1)

### InsertionSort
Insertion sort is another sorting algorithm that places an unsorted element at its suitable place in each iteration (one item at a time).

- Time Complexity:
  - Best Case: O(n) 
  - Worst Case: O(n²)
  - Average Case: O(n²)

- Space Complexity: O(1)

### QuickSort
Quick sort is a divide-and-conquer algorithm. It works by selecting a 'pivot' element from the array and partitioning the other elements into two sub-arrays, according to whether they are less than or greater than the pivot. The sub-arrays are then sorted recursively.

- Time Complexity:
  - Best Case: O(n log n)
  - Worst Case: O(n²)
  - Average Case: O(n log n)

- Space Complexity: O(log n)

### MergeSort
Similar to quick sort, merge sort is also a divide-and-conquer algorithm. It repeatedly breaks down a list into several sublists until each sublist consists of a single element and merging those sublists in a manner that results into a sorted list.

- Time Complexity:
  - Best Case: O(n log n)
  - Worst Case: O(n log n)
  - Average Case: O(n log n)

- Space Complexity: O(n)

### HeapSort
Heap sort is a comparison based sorting technique based on Binary Heap data structure. It is similar to selection sort where we first find the maximum element and place the maximum element at the end. We repeat the same process for the remaining elements.

- Time Complexity:
  - Best Case: O(n log n)
  - Worst Case: O(n log n)
  - Average Case: O(n log n)

- Space Complexity: O(1)

### CountingSort
Counting sort is a sorting algorithm that sorts the elements of an array by counting the number of occurrences of each unique element in the array. The count is stored in an auxiliary array and the sorting is done by mapping the count as an index of the auxiliary array.

- Time Complexity:
  - Best Case: O(n + k), where k is the range of the non-negative key values
  - Worst Case: O(n + k)
  - Average Case: O(n + k)

- Space Complexity: O(n + k)

### RadixSort
Radix sort is a non-comparitive sorting algorithm. It avoids comparison by creating and distributing elements into buckets according to their radix (number of unique digits). Radix sort uses counting sort as a subroutine to sort.

- Time Complexity:
  - Best Case: O(wn), where w is the number of bits required to store each key.
  - Worst Case: O(wn)
  - Average Case: O(wn)

- Space Complexity: O(w + n)

### BucketSort
Bucket sort works by distributing the elements of an array into a number of buckets. Each bucket is then sorted individually by using a different sorting algorithm (in our case we used the insertion sort).

- Time Complexity:
  - Best Case: O(n + k), where k is the number of buckets
  - Worst Case: O(n²)
  - Average Case: O(n + k)

- Space Complexity: O(nk)
