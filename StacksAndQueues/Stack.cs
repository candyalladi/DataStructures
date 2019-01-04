using System;

namespace StacksAndQueues
{
    public class Stack<T> : BaseStack<T>
    {
        public Stack(int maxSize)
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

}
