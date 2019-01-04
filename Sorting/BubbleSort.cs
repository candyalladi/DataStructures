namespace Sorting
{
    public class BubbleSort : SortFactory
    {
       
        public BubbleSort(int max)
        {
            numbers = new long[max];
            nElems = 0;
        }

       

        public override void Sort()
        {
            int outer, inner = 0;
            for (outer = nElems -1 ; outer > 1; outer --)
            {
                for (inner= 0; inner < outer; inner++)
                {
                    if(numbers[inner] > numbers[inner + 1])
                    {
                        Swap(inner, inner + 1);
                    }
                }
            }
        }
    }

}
