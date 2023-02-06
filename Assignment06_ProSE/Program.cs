using System;

namespace Assignment06_ProSE
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> test = new List<int> { 1, 6, 2, 4, 3, 7, 9, 10, 11, 12, 13 };
            //test = Quicksort.SortArray(test);

            List<double> test2 = new List<double> { 1.2, 3.2, 5.2, 1.5, 8.4 };
            test2= Quicksort.SortArray(test2);

            foreach(int i in test2)
            {
                Console.WriteLine(i);   
            }
        }
    }
}

