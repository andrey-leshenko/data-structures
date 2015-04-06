# data-structures
Basic data structures implemented in C# in the simplest way possible.

## Heaps

### Binary Heap

http://en.wikipedia.org/wiki/Binary_heap

| Operation     | Complexity        |
| ------------- |:----------------- |
| find max      | O(1)              |
| delete max    | O(log n)          |
| insert        | O(log n)          |
| construct     | O(n)              |
| merge         | O(m * log(n + m)) |

### Binominal Heap

http://en.wikipedia.org/wiki/Binomial_heap

| Operation     | Complexity        |
| ------------- |:----------------- |
| find max      | O(log n)          |
| delete max    | O(log n)          |
| insert        | O(log n)          |
| construct     | O(n)              |
| merge         | O(log n)          |

## Sorting Algorithms

### Algorithms
* BubbleSort (http://en.wikipedia.org/wiki/Bubble_sort)
* InsertSort (http://en.wikipedia.org/wiki/Insertion_sort)
* SelectSort (http://en.wikipedia.org/wiki/Selection_sort)
* MergeSort  (http://en.wikipedia.org/wiki/Merge_sort)
* QuickSort  (http://en.wikipedia.org/wiki/Quicksort)
* BucketSort (http://en.wikipedia.org/wiki/Counting_sort)

### Complexity

| Field      | Worst Case Time | Average Case Time | Best Case time | Additional Space |
|------------|-----------------|-------------------|----------------|------------------|
| BubbleSort | O(n^2)          | O(n^2)            | O(n)           | O(1)             |
| InsertSort | O(n^2)          | O(n^2)            | O(n)           | O(1)             |
| SelectSort | O(n^2)          | O(n^2)            | O(n^2)         | O(1)             |
| MergeSort  | O(n log n)      | O(n log n)        | O(n log n)     | O(n)             |
| QuickSort  | O(n^2)          | O(n log n)        | O(n log n)     | O (log n)        |
| BucketSort | O(n + k)        | O(n + k)          | O(n + k)       | O(k)             |

## Will be added later:
- 2-3-4 Tree (http://en.wikipedia.org/wiki/2%E2%80%933%E2%80%934_tree)
- Red-Black Tree (http://en.wikipedia.org/wiki/Red%E2%80%93black_tree)
