using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Assignment06_ProSE
{
	public class Quicksort
	{
		// 1. make the quicksort algorithm which takes intger List as a parameter

		public static int[] SortArray(int[] array, int start_index, int end_index)
		{
			int pivot, temp;
			int low, high;

			low = start_index;
			high = end_index;
			pivot = array[start_index];

			//before indices cross each other
			while (low <= high)
			{
				//go to right direction
				while (array[low] < pivot)
				{
					low++;
				}
				//go to left dirction
				while (array[high] > pivot)
				{
					high--;
				}

				// if array[index] out of pivot
				// and still indices not corss, Swap both
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

	

		

        // 2. Generallize the quicksort with a generic list
        public static void DoSort<T>(List<T> values)
		{

		}

		// 2-2. Generallize the with a generic comparision delegate
		public static void DoSort<T>(Comparison<T> comparision)
		{

		}

		// 3. Print out the elements of the list
		public static void PrintOut<T>(List<T> values)
		{

		}
	}
}

