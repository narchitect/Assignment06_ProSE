using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Assignment06_ProSE
{
	public static class Quicksort
	{
		private static int CompareToPivot<T>(T num, T pivot) 
        {
			if (Comparer<T>.Default.Compare(num, pivot) > 0) 
				return 1;
			else if (Comparer<T>.Default.Compare(num, pivot) == 0)
				return 0;
            else
				return -1;
        }

  //      public static List<T> SortArray<T>(this List<T> array)
		//{
		//	List<T> result = array;
		//	Comparison<T> Comparer = new Comparison<T>(CompareToPivot);
            
		//	result.Sort(Comparer);

			

		//	return result;
		//}
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

		public static void Print<T>(this List<T> results)
		{
            foreach (T item in results)
                Console.WriteLine(item);
        }


        public static List<T> SortArray<T>(this List<T> array, int start_index, int end_index)
        {
            T pivot, temp;
            int low, high;

            low = start_index;
            high = end_index;
            pivot = array[start_index];

            while (low <= high)
            {

                while (CompareToPivot(array[low] , pivot) < 0)
                {
                    low++;
                }

                while (CompareToPivot(array[high], pivot ) > 0)  
                {
                    high--;
                }

                if (low <= high)
                {
                    temp = array[low];
                    array[low] = array[high];
                    array[high] = temp;
                    low++;
                    high--;
                }
            }

            if (start_index < high)
                SortArray(array, start_index, high);
            if (low < end_index)
                SortArray(array, low, end_index);
            return array;
        }
    }
}

