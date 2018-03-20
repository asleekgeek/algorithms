/*
 * 
 * Bojan Skrchevski 2018-03-18
 *
 * Hash Tables: Ransom Note
 *
 * Originally posted on Hackerrank as part of Cracking the coding interview tutorial
 * link: https://www.hackerrank.com/challenges/ctci-ransom-note/problem
 *
 * A kidnapper wrote a ransom note but is worried it will be traced back to him.
 * He found a magazine and wants to know if he can cut out whole words from it and
 * use them to create an untraceable replica of his ransom note.
 * The words in his note are case-sensitive and he must use whole words available in the magazine,
 * meaning he cannot use substrings or concatenation to create the words he needs.
 * Given the words in the magazine and the words in the ransom note, print Yes if he can
 * replicate his ransom note exactly using whole words from the magazine; otherwise, print No.
 *
 *
 * Input Format
 *
 * The first line contains two space-separated integers describing the
 * respective values of  (the number of words in the magazine) and  (the number of words in the ransom note). 
 * The second line contains  space-separated strings denoting the words present in the magazine. 
 * The third line contains  space-separated strings denoting the words present in the ransom note.
 *
 *
 * Output Format
 *
 * Print Yes if he can use the magazine to create an untraceable replica of his ransom note; otherwise, print No.
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;

class RansomNote
{
    static void Main(String[] args)
    {
        string[] tokens_m = Console.ReadLine().Split(' ');
        int m = Convert.ToInt32(tokens_m[0]);
        int n = Convert.ToInt32(tokens_m[1]);
        string[] magazine = Console.ReadLine().Split(' ');
        string[] ransom = Console.ReadLine().Split(' ');

        string result = IsRansomNoteReplicable(m, n, magazine, ransom);

        Console.WriteLine(result);
        Console.ReadKey();
    }

    private static string IsRansomNoteReplicable(int m, int n, string[] magazine, string[] ransom)
    {
        var magazineDictionary = new Dictionary<string, int>();

        foreach (var s in magazine)
        {
            if (magazineDictionary.ContainsKey(s))
            {
                magazineDictionary[s]++;
            }
            else
            {
                magazineDictionary.Add(s, 1);
            }
        }

        foreach (var s in ransom)
        {
            if (magazineDictionary.ContainsKey(s))
            {
                magazineDictionary[s]--;
            }
            else
            {
                return "No";
            }
        }

        var retVal = !magazineDictionary.Values.Any(x => x < 0);

        return retVal ? "Yes" : "No";
    }
}