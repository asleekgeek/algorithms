/*
* 
* Bojan Skrchevski 2018-04-27
*
* Merge sort algorithm implementation.
* 
* 
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class MergeSortList
{
    private static List<int> MergeSort(List<int> unsorted)
    {
        if (unsorted.Count <= 1) {
            return unsorted;
        }

        List<int> left = new List<int>();
        List<int> right = new List<int>();

        int middle = unsorted.Count / 2;
        for (int i = 0; i < middle; i++) {
            left.Add(unsorted[i]);
        }
        for (int i = middle; i < unsorted.Count; i++) {
            right.Add(unsorted[i]);
        }

        left = MergeSort(left);
        right = MergeSort(right);
        
        return Merge(left, right);
    }

    private static List<int> Merge(List<int> left, List<int> right)
    {
        List<int> result = new List<int>();

        while(left.Count > 0 || right.Count>0) {
            if (left.Count > 0 && right.Count > 0) {
                if (left.First() <= right.First()) {
                    result.Add(left.First());
                    left.Remove(left.First());
                } else {
                    result.Add(right.First());
                    right.Remove(right.First());
                }
            } else if(left.Count>0) {
                result.Add(left.First());
                left.Remove(left.First());
            }
            else if (right.Count > 0) {
                result.Add(right.First());
                right.Remove(right.First());    
            }    
        }

        return result;
    }

    static void Main(String[] args) 
    {
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] array = Array.ConvertAll(a_temp, Int32.Parse);

        var sorted = MergeSort(array.ToList());

        foreach (var item in sorted) {
            Console.Out.Write(item + " ");
        }

        Console.Out.WriteLine();
        Console.ReadKey();
    }
}