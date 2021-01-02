using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingExamples_DStructures_Algos
{
    class Program
    {

        public static void Main(string[] args)
        {
            //Demonstration Array
            int[] Myarray = new int [] { 40, 71112, 318, 118, 77, 88, 11, 1, 2, 3, 10, 4};

            //Bubble Sorting Practice
            BubbleSorting.sorting(Myarray);
            Console.WriteLine(" ");

            InsertionSorting.sorting(Myarray);
        }
    }
}
