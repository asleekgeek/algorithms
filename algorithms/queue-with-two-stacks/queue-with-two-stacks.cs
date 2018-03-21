using System;
using System.Collections.Generic;

class QueueWithTwoStacks<T>
{
    Stack<T> stackNewestOnTop = new Stack<T>();
    Stack<T> stackOldestOnTop = new Stack<T>();

    public void enqueue(T value) 
    { 
         stackNewestOnTop.Push(value);
    }

    public T peek() 
    {
         prepOld();
         return stackOldestOnTop.Peek();
    }

    public T dequeue() 
    {
         prepOld();
         return stackOldestOnTop.Pop();
    }
        
    public void prepOld()
    {
         if (stackOldestOnTop.Count == 0)
         {
            while(!(stackNewestOnTop.Count == 0))
            {
                stackOldestOnTop.Push(stackNewestOnTop.Pop());
            }
         }
    }
}

class Solution 
{
    static void Main(String[] args) 
    {
        var stackQueue = new QueueWithTwoStacks<int>();

        int q = Convert.ToInt32(Console.ReadLine());

        for(int i = 0; i < q; i++) 
        {
            string[] a_temp = Console.ReadLine().Split(' ');
            int type = Convert.ToInt32(a_temp[0]);
            if(type == 1) 
            {
                int x = Convert.ToInt32(a_temp[1]);
                stackQueue.enqueue(x);
            }
            else if(type == 2) 
            {
                stackQueue.dequeue();
            }
            else Console.WriteLine(stackQueue.peek());
        }

        Console.ReadKey();
    }
}