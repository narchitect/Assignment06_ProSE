using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Assignment06_ProSE
{
	public class Quicksort
	{
        // 1. make the quicksort algorithm which takes intger List as a parameter

        static int Partition(int[] array, int start_index, int end_index)
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
				while (array[low] <= pivot)
				{
					low++;
				}
				//go to left dirction
				while (array[high] >= pivot)
				{
					high--;
				}

				// if array[index] out of pivot
				// and still indices not corss, Swap both
				if (low <= high)
				{
					Swap(array[low], array[high]);
					low++;
					high--;
				}
            }
            Swap(array[low], array[high]);

			return high;
        }

		private static void Swap(int x, int y)
		{
			int temp;
			temp = x;
			x = y;
			y = temp; 
		}

		public static void quick_sort(int[] array, int left_index, int right_index)
		{
			//length of the list to sort 
			if(left_index < right_index)
			{
				int pivot_position = Partition(array, left_index, right_index);

				//recursion
				quick_sort(array, left_index, pivot_position-1);
				quick_sort(array, pivot_position+1, right_index);
			}
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

