using System;

class ArrayRotation
{

    static void Main(String[] args)
    {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int number_of_elements_in_array = Convert.ToInt32(tokens_n[0]);
        int shift_left_number_of_positions = Convert.ToInt32(tokens_n[1]);
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] original_array = Array.ConvertAll(a_temp, Int32.Parse);

        Console.Out.Write("Before: ");
        foreach (var i in original_array)
        {
            Console.Out.Write(i + " ");
        }

        int[] shifted_array_left = RotateArrayLeft(original_array, shift_left_number_of_positions);

        Console.Out.Write("\nAfter rotating left: ");
        foreach (var i in shifted_array_left)
        {
            Console.Out.Write(i + " ");
        }


        int[] shifted_array_right = RotateArrayRight(original_array, shift_left_number_of_positions);

        Console.Out.Write("\nAfter rotating right: ");
        foreach (var i in shifted_array_right)
        {
            Console.Out.Write(i + " ");
        }

        Console.ReadKey();
    }
    
    /*
     *
     * Method for rotating an array to the left
     *
     *
     */
    private static int[] RotateArrayLeft(int[] original_array, int shift_left_number_of_positions)
    {
        var n = original_array.Length;

        int[] shifted_array = new int[n];

        for(int i = 0; i < n; i++){
            shifted_array[(i + (n - shift_left_number_of_positions)) % n ] = original_array[i];
        }

        return shifted_array;
    }

    /*
     *
     * Method for rotating an array to the right
     *
     *
     */
    private static int[] RotateArrayRight(int[] original_array, int shift_left_number_of_positions)
    {
        var n = original_array.Length;

        int[] shifted_array = new int[n];

        for(int i = 0; i < n; i++){
            shifted_array[(i + shift_left_number_of_positions) % n ] = original_array[i];
        }

        return shifted_array;
    }
}