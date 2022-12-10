using System.Linq;

namespace Selection_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] unsortedList = { 10,4,8,6,7};
            Console.WriteLine("Unsorted List :" + String.Join(", ", unsortedList));
            double[] sortedList = SelectionSort(unsortedList);
            Console.WriteLine("Sorted List : " + String.Join(", ",sortedList)); 
            
        }
        private static double[] SelectionSort(double[] unsortedList)
        {
            int Minimum_Index = 0;
            double Minimum_Value_Found = 0;
            for (int MainIndex =0; MainIndex<unsortedList.Length;MainIndex++)
            {
                Minimum_Index = MainIndex;
                for(int Remaining_Index = MainIndex + 1; Remaining_Index < unsortedList.Length; Remaining_Index++)
                {
                    if(unsortedList[Remaining_Index] < unsortedList[Minimum_Index])
                    {
                        Minimum_Index = Remaining_Index;
                    }
                }
                Minimum_Value_Found = unsortedList[Minimum_Index];
                unsortedList[Minimum_Index] = unsortedList[MainIndex];
                unsortedList[MainIndex] = Minimum_Value_Found;
            }
            return unsortedList;
           
            
        }
    }
}