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

			return result;
		}
		public static List<int> QSLinq(List<int> numbers)
		{
			List<int> result = new List<int>();

			if (numbers.Count <= 1)
				return numbers;

			int pivot = numbers[0];

			List<int> less = (from num in numbers where num < pivot select num).ToList();
			List<int> same = (from num in numbers where num == pivot select num).ToList();
			List<int> greater = (from num in numbers where num > pivot select num).ToList();

			result = QSLinq(less).Concat(QSLinq(same)).Concat(QSLinq(greater)).ToList();

			return result;
		}


		// 3. Print out the elements of the list
		public static void PrintOut<T>(List<T> values)
		{

		}
	}
}

