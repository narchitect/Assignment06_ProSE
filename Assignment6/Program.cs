using System;
using System.Collections.Generic;
using System.Linq;


namespace Assignment6
{
    public static class ListExtensions
    {
        public static void PrintList<T>(this List<T> list)
        {
            Console.WriteLine("Sorted List:");
            foreach (T item in list)
            {
                Console.Write(item + " ");
            }
        }
        
    }
    class Program
    {

        static void Main(string[] arg)
        {
            //int[] org_list = { 6, 8, 1, 4, 2, 6, 3, 9, 7 };

            //List<int> sorted_list = new List<int>;
            List<int> original_list = new List<int> { 6, 8, 1, 4, 2, 6, 7 };
            Comparison<int> compareInts = delegate (int x, int y) { return x.CompareTo(y); };
            QuickSort(original_list, 0, original_list.Count - 1, compareInts);

            original_list.PrintList();


        }
        private static void QuickSort(List<int> numbers, int left, int right, Comparison<int> compareInts)
        {
            if (left < right)
            {
                int pivotIndex = Partition(numbers, left, right, compareInts);
                QuickSort(numbers, left, pivotIndex - 1, compareInts);
                QuickSort(numbers, pivotIndex + 1, right, compareInts);
            }
        }
        private static int Partition(List<int> numbers, int left, int right, Comparison<int> compareInts)
        {
            int pivot = numbers[right];
            int i = left - 1;
            for (int j = left; j < right; j++)
            {
                if (compareInts(numbers[j], pivot) <= 0)
                {
                    i++;
                    Swap(numbers, i, j);
                }
            }
            Swap(numbers, i + 1, right);
            return i + 1;
        }
        private static void Swap(List<int> numbers, int i, int j)
        {
            int temp = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = temp;
        }
    }

    
    

}