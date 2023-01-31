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
            Console.WriteLine();
        }        
    }
    class Program
    {

        static void Main(string[] arg)
        {
            
            //Original List for Sorting
            List<int> original_list = new List<int> { 6, 8, 1, 4, 2, 3, 7, 43, 23, 45, 76, 96, 14 };
            original_list.PrintList();

            //Basic Quick sort for List with int
            Console.Write("QuickSort with List int.\n");
            List<int> sortedList = QuickSortInt(original_list, 0, original_list.Count - 1);
            sortedList.PrintList();

            //Quick sort for Generics


            //Old Quick Sort to complicated
            Console.Write("QuickSort with Comparison.\n");
            Comparison<int> compareInts = delegate (int x, int y) { return x.CompareTo(y); };
            QuickSort(original_list, 0, original_list.Count - 1, compareInts);
            original_list.PrintList();

            
        }
        //Basic Quick sort for List with int 
        public static List<int> QuickSortInt(List<int> list, int left, int right)
        {
            var i = left;
            var j = right;
            var pivot = list[left];
            while (i <= j)
            {
                while (list[i] < pivot)
                {
                    i++;
                }

                while (list[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = list[i];
                    list[i] = list[j];
                    list[j] = temp;
                    i++;
                    j--;
                }
            }

            if (left < j)
                QuickSortInt(list, left, j);
            if (i < right)
                QuickSortInt(list, i, right);
            return list;

        }
        //More complex Quick Sort for Generics 
        public static List<int> QuickSortGen(List<int> list, int left, int right)
        {
            var i = left;
            var j = right;
            var pivot = list[left];
            while (i <= j)
            {
                while (list[i] < pivot)
                {
                    i++;
                }

                while (list[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = list[i];
                    list[i] = list[j];
                    list[j] = temp;
                    i++;
                    j--;
                }
            }

            if (left < j)
                QuickSortGen(list, left, j);
            if (i < right)
                QuickSortGen(list, i, right);
            return list;

        }
        //-------------------------------
        //

        //Old Quick sort to complicated
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