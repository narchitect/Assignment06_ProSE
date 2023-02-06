using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Assignment06_ProSE
{
	public class Quicksort
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

        public static List<T> SortArray<T>(List<T> array)
		{
			List<T> result = array;
			Comparison<T> Comparer = new Comparison<T>(CompareToPivot);
			result.Sort(Comparer);

			foreach (T item in result)
				Console.WriteLine(item);

			return result;
		}
		public static List<int> SortArray(List<int> numbers)
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
	}
}

