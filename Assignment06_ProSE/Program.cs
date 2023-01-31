using System;

namespace Assignment06_ProSE
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = { 1, 6, 2, 4, 3, 7, 9, 10, 11, 12, 13 };
            test = Quicksort.SortArray(test,0,test.Length-1);

            foreach(int i in test)
            {
                Console.WriteLine(i);   
            }
        }
    }
}

