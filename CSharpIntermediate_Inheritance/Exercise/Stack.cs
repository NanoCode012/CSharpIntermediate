namespace CSharpIntermediate_Inheritance
{
    class Stack<T>
    {
        readonly LinkedList<T> _list = new LinkedList<T>();
        public Stack()
        {

        }

        public Stack(T data)
        {
            Push(data);
        }

        public void Push(T data)
        {
            _list.InsertFirst(new Node<T>(data));
        }

        public T Pop()
        {
            return _list.PopFirst().Data;
        }

        public T Peek()
        {
            return _list.PeekFirst().Data;
        }
    }
}
