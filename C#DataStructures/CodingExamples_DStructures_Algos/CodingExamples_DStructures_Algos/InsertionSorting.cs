using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingExamples_DStructures_Algos
{
    public class InsertionSorting
    {
        private static bool more(int value1, int value2)
        {
            return value1 > value2;
        }
        public static void sorting(int[] arr)
        {
            int size = arr.Length;
            int j, temp;
            for (int i = 1; i <size; i++)
            {
                temp = arr[i];
                for(j =i; j > 0 && more(arr[j-1], temp); j--)
                {
                    arr[j] = arr[j - 1];
                }
                arr[j] = temp;
            }
            Console.WriteLine("Demonstrating Insertion Sorting ");
            for (int z = 0; z < arr.Length; z++)
            {
                Console.Write(arr[z] + " ");
            }
            Console.Write("\n");
        }
    }
}
