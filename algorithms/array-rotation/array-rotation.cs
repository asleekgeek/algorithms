/*
* 
* Bojan Skrchevski 2018-03-17
*
* Implementation of array rotation to left and right.
* Originally posted on Hackerrank: https://www.hackerrank.com/challenges/ctci-array-left-rotation/problem
* 
* Updated to handle right and left array rotation.
*
* Input Format
* 
* The first line contains two space-separated integers denoting the respective values of n (the number of integers) and d (the number of left rotations you must perform). 
* The second line contains n space-separated integers describing the respective elements of the array's initial state.
* 
* 
*/
using System;

class ArrayRotation
{
    /*
     *
     * Method for rotating an array to the left
     *
     *
     */
    public static int[] RotateArrayLeft(int[] original_array, int shift_left_number_of_positions) {

        int[] rotated_array = new int[original_array.Length];

        for(int i = 0; i < original_array.Length; i++) {
            rotated_array[(i + (original_array.Length - shift_left_number_of_positions)) % original_array.Length] = original_array[i];
        }

        return rotated_array;
    }

    /*
     *
     * Method for rotating an array to the right
     *
     *
     */
    public static int[] RotateArrayRight(int[] original_array, int shift_left_number_of_positions) {

        int[] rotated_array = new int[original_array.Length];

        for(int i = 0; i < original_array.Length; i++) {
            rotated_array[(i + shift_left_number_of_positions) % original_array.Length] = original_array[i];
        }

        return rotated_array;
    }

    static void Main(String[] args) {
        
        string[] tokens_n = Console.ReadLine().Split(' ');
        int number_of_elements_in_array = Convert.ToInt32(tokens_n[0]);
        int shift_left_number_of_positions = Convert.ToInt32(tokens_n[1]);
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] original_array = Array.ConvertAll(a_temp, Int32.Parse);

        Console.Out.Write("Before: ");
        foreach (var i in original_array) {
            Console.Out.Write(i + " ");
        }

        int[] shifted_array_left = RotateArrayLeft(original_array, shift_left_number_of_positions);

        Console.Out.Write("\nAfter rotating left: ");
        foreach (var i in shifted_array_left) {
            Console.Out.Write(i + " ");
        }


        int[] shifted_array_right = RotateArrayRight(original_array, shift_left_number_of_positions);

        Console.Out.Write("\nAfter rotating right: ");
        foreach (var i in shifted_array_right) {
            Console.Out.Write(i + " ");
        }

        Console.ReadKey();
    }
}
