public class Node<T>
{
    public T data;
    public Node<T> next;
}

public class Stack<T>
{
    private Node<T> top = null;

    public void Push(T data) {
    
        var newElement = new Node<T> {
            data = data,
            next = top
        };

        top = newElement;
    }

    public T Pop() {
    
        if(IsEmpty()) throw new StackEmptyException();

        var topValue = top.data;
        top = top.next;

        return topValue;
    }

    public T Peek() {
    
        if(IsEmpty()) throw new StackEmptyException();

        return top.data;
    }

    public bool IsEmpty() {
        return top == null;
    }
}

public class StackEmptyException : Exception {}
