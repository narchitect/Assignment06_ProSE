using System;

namespace Assignment06_ProSE
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1. Testing the orignial QuickSort Method
            List<int> testset1= new List<int> { 1, 6, 2, 4, 3, 7, 9, 16, 11, 10, 5 };
            var result1 = testset1.SortArray();
            result1.Print();
            


            // 2. Testing the generalised QuickSort Method
            List<double> testset2 = new List<double> { 1.2, 3.2, 5.2, 1.5, 8.4, 2.2, 5.2, 0.3 };
            Comparison<double> comparison = (a, b) => a.CompareTo(b);
            var result2 = testset2.SortArray(0, testset2.Count()-1, comparison);
            result2.Print();

        }
    }
}

