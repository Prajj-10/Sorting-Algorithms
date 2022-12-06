namespace Insertion_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] unsortedListBest = { 4, 6, 7, 8, 10};
            double[] unsortedListAverage = { 10, 4, 8, 6, 7};
            double[] unsortedListWorst = { 10, 8, 7, 6, 4 };

            Console.WriteLine("Unsorted List : " + String.Join(", ", unsortedListWorst));
            double[] sortedList = InsertionSort(unsortedListWorst);
            Console.WriteLine("Sorted List : " + String.Join(",", sortedList));


        }
        private static double[] InsertionSort(double[] unsortedList)
        {
            int i = 1;
            int j = i;
            double temp = 0;

            while(i < unsortedList.Length)
            {
                j = i;

                while(j > 0 && unsortedList[j -1] > unsortedList[j])
                {
                    temp = unsortedList[j];
                    unsortedList[j] = unsortedList[j - 1];
                    unsortedList[j - 1] = temp;
                    j--;    
                }
                i++;
            }
            return unsortedList;
        }
    }
}