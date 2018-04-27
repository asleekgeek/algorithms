using System;

class BubbleSort
{
    private static int[] BubbleSortRecursive(int[] array) {
        
        bool swaped = false;
        int n = array.Length;

        for(int x = 1; x < n; x++) {
            if(array[x - 1] > array[x]) {
                Swap(ref array[x - 1], ref array[x]);
                swaped = true; 
            }
        }

        if(swaped) {
            BubbleSortRecursive(array);
        }

        return array;
    }

    private static int[] BubbleSortIterative(int[] array) {
        
        bool swaped = false;
        int n = array.Length;

        do {
            swaped = false;
            for(int x = 1; x < n; x++) {
                if(array[x - 1] > array[x]) {
                    Swap(ref array[x - 1], ref array[x]);
                    swaped = true; 
                }
            } 
        } while (swaped);

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

        var sorted = BubbleSortRecursive(array);

        Console.Out.Write("Recursive\n ");
        foreach (var item in sorted) {
            Console.Out.Write(item + " ");
        }

        sorted = BubbleSortIterative(array);

        Console.Out.Write("\nIterative\n ");
        foreach (var item in sorted) {
            Console.Out.Write(item + " ");
        }

        Console.Out.WriteLine();
        Console.ReadKey();
    }
}