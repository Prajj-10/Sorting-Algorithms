namespace Quick_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 3, 2, 8, 4, 9 };
            Console.WriteLine("Unsorted List : " + String.Join(", ", array));
            QuickSort(array,0,array.Length-1);
            Console.WriteLine("Sorted List : " + String.Join(",", array));
        }
        public static void Swap(int[]array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
        private static int Partition(int[]array, int left, int right)
        {
            int ndx = left; // pivot position
            int pivot = array[left];
            for (int i = left+1; i <= right; i++)
            {
                if (array[i] < pivot)
                {
                    ndx++;
                    Swap(array,ndx,i);
                }
            }
            Swap(array, ndx,left);
            return ndx;
        }
        private static void QuickSort(int[] array, int left, int right)
        {
            if(left< right)
            {
                var pivot = Partition(array, left, right);
                QuickSort(array, left, pivot - 1);
                QuickSort(array, pivot + 1, right);
            }
        }
    }
}