# Data Structures And Algorithms

## Algorithms

### Sorting Algorithms

1. **Comparison Sort**
   1. [Bubble Sort](documentation/BubbleSort.md)
   2. Insertion Sort
   3. Selection Sort
   4. Heap Sort
   5. Merge Sort
   6. Quick Sort
   7. Tree Sort
   8. Shell Sort
2. **Index Based Sort**
   1. Count Sort
   2. Bucket/Bin Sort
   3. Radix Sort

#### Criteria for Analysis

- **Number of the Comparison:** Total how many element comparison are being done.
- **Swap:** How many Swap are being performed
- **Adaptive:** If array is already sorted then algorithm should take minimum time.
- **Stable:** In case of equal elements, their existing position/ordering should not change. Because if we have a complex time then list is already sorted based on one key and if we try to sort it based on second key, in this case new sorting, previous order of the equal element should be preserved.
- **Extra Memory:**

#### Time Complexity

| **Algorithm**   | **Complexity** |
| --------------- | -------------- |
| Bubble Sort     | $O(n^2)$       |
| Insertion Sort  | $O(n^2)$       |
| Selection Sort  | $O(n^2)$       |
| Heap Sort       | $O(nlogn)$     |
| Merge Sort      | $O(nlogn)$     |
| Quick Sort      | $O(nlogn)$     |
| Tree Sort       | $O(n^(3/2))$   |
| Shell Sort      | $O(n^2)$       |
| Count Sort      | $O(n)$         |
| Bucket/Bin Sort | $O(n)$         |
| Radix Sort      | $O(n)$         |
