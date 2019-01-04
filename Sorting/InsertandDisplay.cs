using System;

namespace Sorting
{
    public class InsertandDisplay
    {
        public long[] numbers;
        public int nElems;

        public void Insert(long value)
        {
            numbers[nElems] = value;
            nElems++;
        }

        public void Display()
        {
            for (int i = 0; i < nElems; i++)
            {
                Console.WriteLine(numbers[i]);

            }
        }

        public void Swap(long one, long two)
        {
            long temp = numbers[one];
            numbers[one] = numbers[two];
            numbers[two] = temp;
        }
    }

}
