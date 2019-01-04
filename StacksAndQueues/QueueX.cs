namespace StacksAndQueues
{
    public class QueueX<T>
    {
        private int maxSize;
        private T[] queueArray;
        private int nElems;
        private int front;
        private int rear;

        public QueueX(int size)
        {
            this.maxSize = size;
            queueArray = new T[maxSize];
            front = 0;
            rear = -1;
            nElems = 0;
        }

        public void Insert(T value)
        {
            if (rear == maxSize - 1)
            {
                rear = -1;
            }
            queueArray[++rear] = value;            
            nElems++;
        }

        public T Remove()
        {
            var temp =  queueArray[front++];
            if(front == maxSize)
            {
                front = 0;
            }
            nElems--;
            return temp;
        }

        public T PeekFront()
        {
            return queueArray[front];
        }

        public bool IsEmpty()
        {
            return nElems == 0;
        }

        public bool IsFull()
        {
            return rear == maxSize - 1;
        }
    }

}
