namespace StacksAndQueues
{
    public abstract class BaseStack<T>
    {
        public int maxSize;
        public T[] stackArray;
        public int top;

        public abstract void Push(T item);

        public T Pop()
        {
            return stackArray[top--];
        }

        public T Peek()
        {
            return stackArray[top];
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public bool IsFull()
        {
            return top == maxSize - 1;
        }
    }

}
