using System;
using static System.Net.Mime.MediaTypeNames;

namespace Assignment06_ProSE
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Testing the orignial QuickSort Method
            List<int> testset1= new List<int> { 1, 6, 2, 4, 3, 7, 9, 16, 11, 10, 5 };
            var result1 = Quicksort.SortArray(testset1);
            foreach (int i in result1)
            {
                Console.WriteLine(i);
            }


            // 2. Testing the generalised QuickSort Method
            List<double> testset2 = new List<double> { 1.2, 3.2, 5.2, 1.5, 8.4 };
            var result2 = Quicksort.SortArray(testset2);
            

            

        }
    }
}

