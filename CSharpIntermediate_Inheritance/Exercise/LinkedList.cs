using System;
namespace CSharpIntermediate_Inheritance
{
    class LinkedList<T>
    {
        Node<T> head;

        public LinkedList()
        {

        }

        public LinkedList(Node<T> n)
        {
            this.head = n;
        }

        public void InsertFirst(Node<T> n)
        {
            if (n == null) throw new ArgumentNullException(nameof(n), "Cannot insert null");

            if (head == null) head = n;
            else {
                Node<T> start = head;
                n.Next = start;
                head = n;
            }
        }

        public void InsertLast(Node<T> n)
        {
            if (n == null) throw new ArgumentNullException(nameof(n), "Cannot insert null");

            if (head == null) head = n;
            else
            {
                Node<T> start = head;
                while (start.Next != null) start = start.Next;
                start.Next = n;
            }
        }

        public Node<T> PopFirst()
        {
            if (head == null) throw new InvalidOperationException("Cannot Pop empty.");

			Node<T> start = head;
            head = head.Next;
            return start;
        }

        public Node<T> PopLast()
        {
			if (head == null) throw new InvalidOperationException("Cannot Pop empty.");

            Node<T> start = head;
            if (start.Next == null)
            {
                head = null;
                return start;
            }
            else
            {
                while (start.Next.Next != null)
                {
                    start = start.Next;
                }
                Node<T> last = start.Next;
                start.Next = null;
                return last;
            }

        }

        public Node<T> PeekFirst()
        {
            return head;
        }

        public Node<T> PeekLast()
        {
            Node<T> last = head;
            while (last.Next != null)
            {
                last = last.Next;
            }
            return last;
        }

        public void Clear()
        {
            head = null;
        }
    }
}
