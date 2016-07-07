using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an unsorted array of numbers
            int[] unsorted = { 99, 88, 44, 33, 22, 66, 55, 11, 77 };
            QuickSort(unsorted, 0, unsorted.Length - 1);

            for (int i = 0; i < unsorted.Length-1; i++)
            {
                Console.Write(unsorted[i] + " ");
            }
            Console.ReadLine();
        }

        public static int Partition(int[] array, int start, int end)
        {
            int pivot = array[end];
            //set partition index as start initially
            int partitionIndex = start;

            for (int i = start; i < end; i++)
            {
                if (array[i] <= pivot)
                {
                    //swap if element is lesser than pivot
                    int temp = array[i];
                    array[i] = array[partitionIndex];
                    array[partitionIndex] = temp;
                    partitionIndex++;
                }
            }
            int swapValue = array[partitionIndex];
            array[partitionIndex] = array[end];
            array[end] = swapValue;
            return partitionIndex;
        }

        public static void QuickSort(int[] array, int start, int end)
        {

            if (start < end)
            {
                //make call to partition
                int partitionIndex = Partition(array, start, end);
                QuickSort(array, start, partitionIndex - 1);
                QuickSort(array, partitionIndex + 1, end);
                
            }
        }


    }
  
}