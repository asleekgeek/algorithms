public class Node<T>
{
    public T data;
    public Node<T> next;
}

public class Queue<T>
{
    private Node<T> head = null;
    private Node<T> tail = null;

    public void Enqueue(T data) {
        
        var node = new Node<T> {
            data = data,
            next = null
        };
        
        if(tail != null) {
            tail.next = node;
        }

        tail = node;

        if(head == null) {
            head = node;
        }
    }

    public T Dequeue() {
    
        if (IsEmpty()) throw new QueueEmptyException();

        var firstValue = head.data;
        head = head.next;

        if(IsEmpty()) {
            tail = null;
        }

        return firstValue;
    }

    public T Peek() {
    
        if (IsEmpty()) throw new QueueEmptyException();

        return head.data;
    }

    public bool IsEmpty() {
        return head == null;
    }
}
