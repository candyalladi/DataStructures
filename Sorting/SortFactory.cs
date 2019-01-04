using System;

namespace Sorting
{
    public abstract class SortFactory
    {
        public abstract void Sort();

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

    public class SortStores
    {
        public SortFactory CreateSort(string sortType, int size)
        {
            SortFactory sortFactory = null;
            switch (sortType)
            {
                case "InsertionSort":
                    Console.WriteLine("Sorting using Insertion Sort");
                    return new InsertionSort(size);
                case "SelectionSort":
                    Console.WriteLine("Sorting using Selection Sort");
                    return new SelectionSort(size);
                case "BubbleSort":
                    Console.WriteLine("Sorting using Bubble Sort");
                    return new BubbleSort(size);
                default:
                    return sortFactory;
            }
        }
    }

}
