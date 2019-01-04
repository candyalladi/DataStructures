namespace Sorting
{
    public class InsertionSort : SortFactory
    {
        public InsertionSort(int size)
        {
            numbers = new long[size];
            nElems = 0;
        }
        public override void Sort()
        {
            int inner, outter;
            for (outter =1; outter < nElems; outter++)
            {
                long temp = numbers[outter];
                inner = outter;
                while (inner > 0 && numbers[inner-1] >= temp)
                {
                    numbers[inner] = numbers[inner - 1];
                    --inner;
                }
                numbers[inner] = temp;
            }
        }
    }

}
