/*
 * 
 * Bojan Skrchevski 2018-03-20
 *
 * Balanced brackets using Stack data structure.
 *
 * Note: This implementation uses the Stack<T> implementation from the data-structures directory.
 * 
 *
 * A bracket is considered to be any one of the following characters: (, ), {, }, [, or ].
 * 
 * Two brackets are considered to be a matched pair if the an opening bracket (i.e., (, [, or 
 * {) occurs to the left of a closing bracket (i.e., ), ], or }) of the exact same type. 
 * There are three types of matched pairs of brackets: [], {}, and ().
 * A matching pair of brackets is not balanced if the set of brackets it encloses are not matched. 
 * For example, {[(])} is not balanced because the contents in between { and } are not balanced. 
 * The pair of square brackets encloses a single, unbalanced opening bracket, (, 
 * and the pair of parentheses encloses a single, unbalanced closing square bracket, ].
 * Some examples of balanced brackets are []{}(), [({})]{}() and ({(){}[]})[].
 *
 * By this logic, we say a sequence of brackets is considered to be balanced if the following conditions are met:
 *
 * It contains no unmatched brackets.
 *
 * The subset of brackets enclosed within the confines of a matched pair of brackets is also a matched pair of brackets.
 *
 * Given  strings of brackets, determine whether each sequence of brackets is balanced. 
 *
 * If a string is balanced, print YES on a new line; otherwise, print NO on a new line.
 *
 */

using System;
using System.Collections.Generic;

class Brackets {

    static void Main(String[] args) {
        
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++) {
            string expression = Console.ReadLine();

            bool result = IsBalanced(expression);

            Console.Out.WriteLine(result ? "YES" : "NO");
        }

        Console.ReadKey();
    }

    private static bool IsBalanced(string expression) {
        
        var openedBracketsList = new List<char> {'{', '(', '['};
        Stack<char> stack = new Stack<char>();

        foreach (var c in expression) {
            if (openedBracketsList.Contains(c)) {
                stack.Push(c);
            } else if(!stack.IsEmpty()) {
                var openedBracket = stack.Pop();

                switch (openedBracket)
                {
                    case '(': if (c != ')') return false;
                        break;
                    case '{' : if (c != '}') return false;
                        break;
                    case '[' : if (c != ']') return false;
                        break;
                    default: return false;
                }
            } 
            else return false;
        }

        return (stack.IsEmpty());
    }
}
