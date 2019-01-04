namespace StacksAndQueues
{
    public class QueueX<T>
    {
        private int maxSize;
        private T[] queueArray;
        private int nElems;
        private int front;
        private int rear;

        public QueueX()
        {

        }
        public QueueX(int size)
        {
            this.maxSize = size;
            queueArray = new T[maxSize];
            front = 0;
            rear = -1;
            nElems = 0;
        }

        public virtual void Insert(T value)
        {
            if (rear == maxSize - 1)
            {
                rear = -1;
            }
            queueArray[++rear] = value;            
            nElems++;
        }

        public virtual T Remove()
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

    public class PriorityQueue//<T> : QueueX<T> 

    {
        private int maxSize;        
        private int nItems;
        private long[] priorityQueueArray;

        public PriorityQueue(int size)
        {
            this.maxSize = size;
            this.priorityQueueArray = new long[maxSize];
            nItems = 0;
        }

        public void Insert(long value)
        {
            int j;
           if (nItems == 0)
            {
                priorityQueueArray[nItems++] = value;
            }
            else
            {
                for ( j = nItems -1; j>=0;j--)
                {
                    if(value > priorityQueueArray[j])
                    {
                        priorityQueueArray[j + 1] = priorityQueueArray[j];
                    }
                    else
                    {
                        break;
                    }
                }
                priorityQueueArray[j + 1] = value;
                nItems++;
            }
        }

        public long Remove()
        {
            return priorityQueueArray[--nItems];
        }

        public long PeekMin()
        {
            return priorityQueueArray[nItems - 1];
        }

        public bool IsEmpty()
        {
            return nItems == 0;
        }

        public bool IsFull()
        {
            return nItems == maxSize;
        }
    }

}
