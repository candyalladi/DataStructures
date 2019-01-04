using System;

namespace DataStructures
{
    public class BinarySearch
    {
        int[] sortedList = new int[] { 1, 2, 3, 4, 5 };

        public void FindNumber(int searchElement)
        {
            int lowerBound = 0;
            int counter = 0;
            int higherBound = sortedList.Length -1 ;

            for (int i = 0; i < higherBound; i++)
            {
                counter++;
                int curIndex = (lowerBound + higherBound) / 2;

                if (sortedList[curIndex] == searchElement)
                {
                    Console.WriteLine($"Element found at {curIndex} index with no.of counts {counter}");
                    return;
                }
                else if (lowerBound > higherBound)
                {
                    Console.WriteLine("No element found!");
                    return;
                }
                else
                { 
                    if (sortedList[curIndex] < searchElement)
                    {
                        lowerBound = curIndex + 1;
                    }
                    else if (sortedList[curIndex] > searchElement)
                    {
                        higherBound = curIndex - 1;
                    }
                }
            }
        }
    }
}
