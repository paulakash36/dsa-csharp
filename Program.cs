namespace DSA
{
 
    public class Node
    {
        public int element;
        public Node next;

        public Node(int element, Node next)
        {
            this.element = element;
            this.next = next;
        }
    }
    internal class LinkedList
    {
        private Node head;
        private Node tail;
        private int size;
        public LinkedList()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public int length()
        {
            return size;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public void AddLast(int e)
        {
            Node newNode = new Node(e, null);
            if (IsEmpty())
                head = newNode;
            else
                tail.next = newNode;
            tail = newNode;
            size++;
        }

        public void AddFirst(int e)
        {
            Node newNode = new Node(e, null);
            if (IsEmpty())
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.next = head;
                head = newNode;
            }
            size++;
        }

        public void Display()
        {
            Node p = head;
            while(p != null)
            {
                Console.Write(p.element + "--> ");
                p = p.next;
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            LinkedList l = new LinkedList();
            l.AddLast(1);
            l.AddLast(4);
            l.AddLast(6);
            l.AddFirst(-1);
            l.AddFirst(-5);
            l.Display();
            Console.WriteLine("Size of Linked List : "+l.length());
        }
    }
}