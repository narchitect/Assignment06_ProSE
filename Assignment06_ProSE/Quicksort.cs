using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Assignment06_ProSE
{
    public static class Quicksort
    {
        public static void Print<T>(this List<T> results)
        {
            foreach (T item in results)
                Console.WriteLine(item);
        }
        public static List<int> SortArray(this List<int> numbers)
        {
            List<int> result = new List<int>();

            if (numbers.Count <= 1)
                return numbers;

            int pivot = numbers[0];

            List<int> less = (from num in numbers where num < pivot select num).ToList();
            List<int> same = (from num in numbers where num == pivot select num).ToList();
            List<int> greater = (from num in numbers where num > pivot select num).ToList();

            result = SortArray(less).Concat(SortArray(same)).Concat(SortArray(greater)).ToList();

            return result;
        }

        public static List<T> SortArray<T>(this List<T> array, int low, int high, Comparison<T> comparison)
        {
            List<T> result = new List<T>();
            if (low < high)
            {
                int pivotIndex = Partition(array, low, high, comparison);

                SortArray(array, low, pivotIndex - 1, comparison);
                SortArray(array, pivotIndex + 1, high, comparison);
            }
            result = array;
            return result;
        }
        private static int Partition<T>(List<T> array, int low, int high, Comparison<T> comparison)
        {
            T pivot = array[high];
            int i = low - 1;

            for (int j = low; j <= high - 1; j++)
            {
                if (comparison(array[j], pivot) <= 0)
                {
                    i++;

                    T temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }

            T temp2 = array[i + 1];
            array[i + 1] = array[high];
            array[high] = temp2;

            return i + 1;
        }
    }
}

