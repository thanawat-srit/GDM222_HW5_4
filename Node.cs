class Node<T>
{
    private T value;
    private Node<T> next = null;
    private Node<T> before = null;

    public Node(T value)
    {
        this.SetValue(value);
    }

    public void SetNext(Node<T> next)
    {
        this.next = next;
    }

    public void SetBefore(Node<T> before)
    {
        this.before = before;
    }

    public Node<T> Next()
    {
        return this.next;
    }

    public Node<T> Before()
    {
        return this.before;
    }
    
    public T GetValue()
    {
        return this.value;
    }

    public void SetValue(T value)
    {
        this.value = value;
    }
}