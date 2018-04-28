/*
* 
* Bojan Skrchevski 2018-04-27
*
* Selection sort algorithm implementation in C#.
* 
* 
* 
*/
using System;

class SelectionSortClass
{
    private static int[] SelectionSort(int[] array) {
        
        for(int i = 0; i < array.Length; i++) {
            int current_min_index = i;
            for(int j = current_min_index + 1; j < array.Length; j++) {
                if(array[j] < array[current_min_index]) {
                    current_min_index = j;
                }
            }
            
            if (current_min_index != i) 
            {
                Swap(ref array[i], ref array[current_min_index]);
            }
            
        }

        return array;
    }

    private static void Swap(ref int x, ref int y) {
        int temp = x;
        x = y;
        y = temp;
    }

    static void Main(String[] args) {
        
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] array = Array.ConvertAll(a_temp, Int32.Parse);

        var sorted = SelectionSort(array);

        foreach (var item in sorted) {
            Console.Out.Write(item + " ");
        }

        Console.Out.WriteLine();
        Console.ReadKey();
    }
}