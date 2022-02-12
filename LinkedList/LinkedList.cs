public class LinkedList
{
    // attributes
    private Node head;
    private Node current;
    public int Count;

    // constructors
    public LinkedList()
    {
        head = new Node();
        current = head;
    }
    // behaviors
    

    // Add node after last element
    public void AddAtLast(object data)
    {
        Node newNode = new Node();
        newNode.Data = data;
        current.Next = newNode;
        current = newNode;
        Count++;
    }


    // add node as first element
    public void AddAtStart(object data)
    {
        Node newNode = new Node()
        {
            Data = data
        };

        newNode.Next = head.Next;
        head.Next = newNode;
        Count++;
    }

    // Remove node from Start
    public void RemoveFromStart()
    {
        if (Count > 0)
        {
            head.Next = head.Next.Next;
            Count--;
        }
        else
        {
            Console.WriteLine("LinkedList is empty...");
        }
    }


    // traverse list

    public void PrintAllNodes()
    {
        // traverse from head
        Console.Write("Head ->");
        Node current = head;
        while (current.Next != null)
        {
            current = current.Next;
            Console.Write(current.Data);
            Console.Write("->");
        }
        Console.WriteLine("NULL");
    }



}

public class Node
{
    // attributes
    public Node Next;
    public object Data;
   
}



class Program
{
    static void Main(string[] args)
    {
        LinkedList linkedlist = new LinkedList();
        linkedlist.PrintAllNodes();
        Console.WriteLine();

        linkedlist.AddAtLast(12);
        linkedlist.AddAtLast("John");
        linkedlist.AddAtLast("Michael");
        linkedlist.AddAtLast(34);
        linkedlist.PrintAllNodes();
        Console.WriteLine();

        linkedlist.AddAtStart(55);
        linkedlist.PrintAllNodes();
        Console.WriteLine();

        linkedlist.RemoveFromStart();
        linkedlist.PrintAllNodes();

        Console.ReadKey();

    
    }
}