namespace CSharpIntermediate_Inheritance
{
    class Stack<T>
    {
        LinkedList<T> list = new LinkedList<T>();
        public Stack()
        {

        }

        public Stack(T data)
        {
            Push(data);
        }

        public void Push(T data)
        {
            list.InsertFirst(new Node<T>(data));
        }

        public T Pop()
        {
            return list.PopFirst().Data;
        }
    }
}
