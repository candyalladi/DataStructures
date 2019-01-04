namespace Sorting
{
    public class SelectionSort : SortFactory
    {
        private int outter;
        private int inner;
        private int min;

        public SelectionSort(int maxSize)
        {
            numbers = new long[maxSize];
            nElems = 0;
        }

        public override void Sort()
        {
            for (outter = 0; outter < nElems-1; outter ++)
            {
                min = outter;
                for (inner = outter +1;inner < nElems; inner++)
                {
                    if(numbers[inner] < numbers[min])
                    {
                        min = inner;
                    }
                }
                Swap(outter, min);

            }
        }
    }

}
