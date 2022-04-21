# Bubble Sort Algorithm
**Wikipedia says:** Bubble sort~~~, sometimes referred to as sinking sort, is a simple sorting algorithm that repeatedly steps through the list, compares adjacent elements and swaps them if they are in the wrong order. The pass through the list is repeated until the list is sorted. The algorithm, which is a comparison sort, is named for the way smaller or larger elements "bubble" to the top of the list.

This simple algorithm performs poorly in real world use and is used primarily as an _educational tool_.

Bubble sort has an average complexity of O(n^2), so its not practical.

## Why did I do this?
I did this to learn algorithms and hone my C# skills. Its really not that mind breaking, but not a child's toy too.

### Then why did I write this much of a README if its just learning?
Well, I didn't really know the **Markdown**, so thought I could learn its syntax this way.

## Psuedo code 

    procedure bubbleSort(A : list of sortable items)
        n := length(A)
        repeat
            swapped := false
            for i := 1 to n-1 inclusive do
                /* if this pair is out of order */
                if A[i-1] > A[i] then
                    /* swap them and remember something changed */
                    swap(A[i-1], A[i])
                    swapped := true
                end if
            end for
        until not swapped
    end procedure




