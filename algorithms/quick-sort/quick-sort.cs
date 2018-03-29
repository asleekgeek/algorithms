using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class QuickSortList
{
    private static List<int> QuickSort(List<int> list)
    {
        int number_of_elements = list.Count();
        if (number_of_elements < 2) {
            return list;
        }

        var pivot = number_of_elements - 1;
        var pivotValue = list[pivot];
        var left = new List<int>();
        var right = new List<int>();

        for (int i = 0; i < number_of_elements; i++) {
            if (i != pivot) {
                if (list[i] < pivotValue) {
                    left.Add(list[i]);
                } else {
                    right.Add(list[i]);
                }
            }
        }

        var merged = QuickSort(left);
        merged.Add(pivotValue);
        merged.AddRange(QuickSort(right));
        return merged;
    }

    static void Main(String[] args) 
    {
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] array = Array.ConvertAll(a_temp, Int32.Parse);

        var sorted = QuickSort(array.ToList());

        foreach (var item in sorted) {
            Console.Out.Write(item + " ");
        }

        Console.Out.WriteLine();
        Console.ReadKey();
    }
}