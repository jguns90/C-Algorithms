using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingExamples_DStructures_Algos
{
    public class BubbleSorting
    {
        private static bool more(int value1, int value2)
        {
            return value1 > value2;
        }
        public static void sorting(int[] arr)
        {
            int size = arr.Length;
            int i, j, temp;
            for(i=0; i <(size -1); i++)
            {
                for(j=0; j<size - i - 1; j++)
                {
                    if(more(arr[j], arr[j + 1]))
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Demonstrating Bubble Sorting ");
            for (int z = 0; z < arr.Length; z++)
            {
                Console.Write(arr[z] + " ");
            }
            Console.Write("\n");
        }
    }
}
