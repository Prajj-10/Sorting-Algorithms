namespace Bubble_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] unsortedList = { 36, 2, 29, 1, 8, 14};
            Console.WriteLine("Unsorted List : " + String.Join(",", unsortedList));
            double[] sortedList = BubbleSort(unsortedList);
            Console.WriteLine("Sorted List : " + String.Join(",",sortedList));


        }
        public static double[] BubbleSort(double[] unsortedList)
        {
            double temp;

            for (int i = 0; i < unsortedList.Length-1; i++)
            {
                for(int j = 0; j < unsortedList.Length -(1+i); j++)
                {
                    if(unsortedList[j] > unsortedList[j + 1])
                    {
                        temp = unsortedList[j+1];
                        unsortedList[j+1] = unsortedList[j];
                        unsortedList[j] = temp;
                    }
                }
            }
            return unsortedList;
        }
    }
}