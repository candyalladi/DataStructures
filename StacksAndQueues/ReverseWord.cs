namespace StacksAndQueues
{
    public class ReverseWord<T> : BaseStack<T>
    {
        public ReverseWord(int maxSize)
        {
            this.maxSize = maxSize;
            stackArray = new T[maxSize];
            top = -1;
        }
        public override void Push(T item)
        {
            stackArray[++top] = item;
        }
    }

    public class Delimiters<T> : BaseStack<T>
    {
        public Delimiters(int size)
        {
            this.maxSize = size;
            stackArray = new T[size];
            top = -1;
        }
        public override void Push(T item)
        {
            stackArray[++top] = item;
        }        
    }

}
