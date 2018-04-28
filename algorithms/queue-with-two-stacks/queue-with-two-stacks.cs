/*
* 
* Bojan Skrchevski 2018-03-27
*
* Implementation of a queue data structureby using 2 stacks.
* 
* Originally posted on Hackerrank: https://www.hackerrank.com/challenges/ctci-queue-using-two-stacks/problem
* 
*  
* Input Format
* 
* The first line contains a single integer, q, denoting the number of queries. 
* Each line i of the q subsequent lines contains a single query in the form:
* 
* 1 x: Enqueue element  into the end of the queue.
* 2: Dequeue the element at the front of the queue.
* 3: Print the element at the front of the queue.
* 
* All three queries start with an integer denoting the query type, but only query 1 is followed by an additional space-separated value, x, denoting the value to be enqueued.
* 
* 
*/

using System;
using System.Collections.Generic;

class QueueWithTwoStacks<T>
{
    Stack<T> stackNewestOnTop = new Stack<T>();
    Stack<T> stackOldestOnTop = new Stack<T>();

    public void Enqueue(T value) { 
         stackNewestOnTop.Push(value);
    }

    public T Peek() {
         prepOld();
         return stackOldestOnTop.Peek();
    }

    public T Dequeue() {
         prepOld();
         return stackOldestOnTop.Pop();
    }
        
    private void prepOld() {
         if (stackOldestOnTop.Count == 0) {
            while(!(stackNewestOnTop.Count == 0)) {
                stackOldestOnTop.Push(stackNewestOnTop.Pop());
            }
         }
    }
}

class Solution 
{
    static void Main(String[] args) {
        
        var stackQueue = new QueueWithTwoStacks<int>();
        int q = Convert.ToInt32(Console.ReadLine());

        for(int i = 0; i < q; i++) {
            string[] a_temp = Console.ReadLine().Split(' ');
            int type = Convert.ToInt32(a_temp[0]);
            if(type == 1) {
                int x = Convert.ToInt32(a_temp[1]);
                stackQueue.Enqueue(x);
            } else if(type == 2) {
                stackQueue.Dequeue();
            } else Console.WriteLine(stackQueue.Peek());
        }

        Console.ReadKey();
    }
}
