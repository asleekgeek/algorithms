public class Node<T>
{
    public T data;
    public Node<T> next;
}

public class Stack<T>
{
    private Node<T> top = null;

    public void Push(T data)
    {
        if(IsEmpty())
        {
            top = new Node<T> 
            {
                data = data,
                next = null
            }; 
        } else {
            var newElement = new Node<T>
            {
                data = data,
                next = top
            };

            top = newElement;
        }        
    }

    public T Pop()
    {
        if(IsEmpty()) return default(T);

        var topValue = top.data;
        top = top.next;

        return topValue;
    }

    public T Peek()
    {
        if(IsEmpty()) throw new StackEmptyException();

        return top.data;
    }

    public bool IsEmpty()
    {
        return top == null;
    }
}

public class StackEmptyException : Exception {}
