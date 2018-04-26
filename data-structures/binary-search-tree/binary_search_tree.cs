public class Node<T>
{
    public int key;
    public T data;

    public Node<T> left;
    public Node<T> right;
}

public class BinarySearchTree<T>
{
    private Node<T> root = null;

    public Node<T> Insert(int key, T value) {
        return InsertAtNode(root, key, value);
    }

    public void Traverse(Action<T> action) {
        
        if (root == null) {
            return;
        }

        Traverse(root.left, action);
        action(root.data);
        Traverse(root.right, action);
    }

    private void Traverse(Node<T> node, Action<T> action) {
        
        if (root == null) {
            return;
        }

        Traverse(root.left, action);
        action(root.data);
        Traverse(root.right, action);
    }

    private Node<T> InsertAtNode(Node<T> node, int key, T value)     {
        
        if (node == null) {
            node = new Node<T>{ key = key, data = value };
        } else if (key == root.key) {
            node.data = value;
        } else if (key < root.key) {
            node.left = InsertAtNode(node.left, key, value);
        } else {
            node.right = InsertAtNode(node.right, key, value);
        }

        return node;
    }
}
