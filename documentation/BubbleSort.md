# Bubble Sort

**Links:** [GeeksForGeeks](https://www.geeksforgeeks.org/bubble-sort/)

Bubble sort is a simple sorting algorithm that repeatedly steps through the list, _compares adjacent elements and swaps them if they are in the wrong order_. The pass through the list is repeated until the list is sorted.

The comparison sort algorithm is named for the way smaller or larger elements "bubble" to the top of the list.

One interation of the list is called one pass. And, in each interation we are finding the largest element among unsorted list and bring it the start of the sorted list.

If the iteration doesn't swap any element, list is sorted.

![](https://media.geeksforgeeks.org/wp-content/cdn-uploads/gq/2014/02/bubble-sort1.png)

```csharp

 for (int i = 0; i < array.Length - 1; i++)
 {
    var swaped = false;
    for (int j = 0; j < array.Length - i - 1; j++)
    {
        if (array[j + 1].CompareTo(array[j]) > 0)
        {
            swaped = true;
            var temp = array[j];
            array[j] = array[j + 1];
            array[j + 1] = temp;
        }
    }
    if (!swaped) break;
 }

```

### Analysis of the Algorithms

- Number of the Passes `-->` n-1
- Number of Comparision `-->` n(n-1)/2 `-->` O(n<sup>2</sup>)
- Number of the Swap `-->` n(n-1)/2 `-->` O(n<sup>2</sup>)

> _With each pass/iteration we get one largest element, So if perform `k` passes we will get `k` largest elements. If we need to find `k^th^` element, so instead of sorting all the element in the list we use to algorithm to find the `k^th^` element. Drawback is the list will be half sorted and halfunsorted._
