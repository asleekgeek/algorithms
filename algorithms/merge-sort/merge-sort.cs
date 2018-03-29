/*
* 
* Bojan Skrchevski 2018-03-18
*
* Merge sort algorithm.
*
*
*/

using System;
using System.Linq;
using System.Collections.Generic;

class MergeSortAlgorithm
{
    static int[] MergeSort(int[] array) 
    {   
        if(array.Length <= 1) {
            return array;
        }

        int middle = array.Length / 2;
        int[] left = MergeSort(array, 0, middle);
        int[] right = MergeSort(array, middle + 1, array.Length - 1);
        
        return Merge(left, right);
    }

    static int[] MergeSort(int[] array, int start, int end) 
    {
        if(array.Length <= 1) {
            return array;
        }

        int middle = array.Length / 2;
        int[] left = MergeSort(array, start, middle);
        int[] right = MergeSort(array, middle + 1, end);
        
        return Merge(left, right);
    }

    static int[] Merge(int[] left, int[] right)
    {
        List<int> result = new List<int>();
        List<int> lefty = new List<int>(left);
        List<int> righty = new List<int>(right);

        while(lefty.Count > 0 || righty.Count > 0) {
            if(lefty.Count > 0 && righty.Count > 0) {
                //if the first item on left is
                //less than right...
                if(lefty[0] < righty[0]) {
                    //take the first item on the left
                    result.Add(lefty.First());
                    lefty.Remove(lefty.First());
                } else {
                    //take the first item on the right
                    result.Add(righty.First());
                    righty.Remove(righty.First());
                }
            } else if(lefty.Count > 0) {
                result.Add(lefty.First());
                lefty.Remove(lefty.First());
            } else {
                result.Add(righty.First());
                righty.Remove(righty.First());
            }
        }

        return result.ToArray();
    }

    static void Main(String[] args) {
        
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] array = Array.ConvertAll(a_temp, Int32.Parse);

        int[] sorted = MergeSort(array);

        foreach (var item in sorted)
        {
            Console.Out.Write(item + " ");
        }

        Console.Out.WriteLine();
        Console.ReadKey();
    }
}