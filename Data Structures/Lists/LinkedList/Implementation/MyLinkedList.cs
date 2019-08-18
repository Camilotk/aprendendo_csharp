// add = O(1) worst case | get = O(n)
public class LinkedList
{
    // First element
    private Node head;

    // Print all Nodes in LinkedList
    public void printAllNodes()
    {
        Node current = head;
        while (current != null)
        {
            Console.WriteLine(current.data);
            current = current.next;
        }
    }

    // Add in Head
    public void AddFirst(Object data)
    {
        Node toAdd = new Node();

        toAdd.data = data;
        toAdd.next = head;

        head = toAdd;
    }

    // Add in Tail
    public void AddLast(Object data)
    {
        if (head == null)
        {
            head = new Node();

            head.data = data;
            head.next = null;
        }
        else
        {
            Node toAdd = new Node();
            toAdd.data = data;

            Node current = head;
            while (current.next != null)
            {
                current = current.next;
            }

            current.next = toAdd;
        }
    }
}
