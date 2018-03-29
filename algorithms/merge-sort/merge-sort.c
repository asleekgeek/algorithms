/*
* 
* Bojan Skrchevski 2018-03-28
*
* Merge sort algorithm implementation in C
*
*/

#include<stdio.h>


/*
* 
* Merge method, implemented with a temporarty array
* 
*/
void merge(int array[], int start, int mid, int end)
{
    int i = 0, j, ll = start;
    int second_half_start = mid + 1;
    int tmpArray[100];
    
    while((start <= mid) && (second_half_start <= end)) {
        // in case both arrays have values
        // compare the first two elements
        // assign the left or the right first 
        // item to the temp array 
        // (assign and increment the counters in one step)
        if(array[start] < array[second_half_start]) {
            tmpArray[i++] = array[start++];
        } else {
            tmpArray[i++] = array[second_half_start++];
        }
    }
    
    // in case we only have the left part of the array
    while(start <= mid) {
        tmpArray[i++] = array[start++];
    }
    
    // in case we only have the right part of the array
    while(second_half_start <= end) {
        tmpArray[i++] = array[second_half_start++];
    }
    
    // reassign the sorted values from the 
    // temporary array to the original array
    for(j=0; j < i; j++) {
        array[ll++] = tmpArray[j];
    }
}

/*
*
* Merge sort method.
*
* Recursively splits the array in halves and calls the merge
* method once it reaches size the end.
* 
*/
void merge_sort(int array[], int start, int end)
{
    int mid;

    if(start < end)
    {
        mid = (end + start) / 2;
        merge_sort(array, start, mid);
        merge_sort(array, mid + 1, end);
        merge(array, start, mid, end);
    }
}

void main()
{
    int array[100];
    int n, i;
    
    printf("\nNum of elements present in the array? :");
    scanf("%d", &n);
    
    for(i=0; i < n; i++)
    {
        scanf("%d", &array[i]);
    }
    
    merge_sort(array, 0, n-1);
    
    printf("\nThe sorted array is...\n");
    for(i=0; i < n; i++)
    {
        printf("%d ", array[i]);
    }

    printf("\n\n");
}