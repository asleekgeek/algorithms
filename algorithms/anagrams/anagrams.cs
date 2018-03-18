/*
* 
* Bojan Skrchevski 2018-03-18
*
* Minimum number of character deletions required to make the two strings anagrams.
*
*
*/

using System;
using System.Linq;

class Anagrams
{
    static void Main(String[] args)
    {
        string a = Console.ReadLine();
        string b = Console.ReadLine();

        var sum = GetNumberOfDifferentCharacters(a, b);

        Console.WriteLine(sum);
        Console.ReadKey();
    }

    private static int GetNumberOfDifferentCharacters(string a, string b)
    {
        int[] freq = new int[26];

        foreach (var c in a)
        {
            ++freq[c - 'a'];
        }

        foreach (var c in b)
        {
            --freq[c - 'a'];
        }

        var sum = freq.Sum(Math.Abs);
        return sum;
    }
}