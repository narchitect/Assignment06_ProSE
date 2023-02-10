using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using static System.Formats.Asn1.AsnWriter;


namespace Assignment6
{
    public static class ListExtensions 
    {
        public delegate int Comparison<T>(T x, T y);
        public static void PrintList<T>(this List<T> list)
        {
            Console.WriteLine("Sorted List:");
            foreach (T item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        public static void PrintUnsortedList<T>(this List<T> list)
        {
            Console.WriteLine("Unsorted List:");
            foreach (T item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        //public static List<T> QuickSortGen2<T>(this List<T> list, int left, int right)
        //{
        //    var i = left;
        //    var j = right;
        //    var pivot = list[left];
        //    var pivot1 = list[right];
        //    var pivot2 = j.CompareTo(pivot);


        //    while (i.CompareTo(j) <= 0)
        //    {
                
        //        while (list[i].CompareTo(pivot) < 0)
        //        {
        //            i++;
        //        }
                
        //        while (list[j] > pivot)
        //        {
        //            j--;
        //        }
        //        if (i.CompareTo(j) <= 0)
        //        {
        //            var temp = list[i];
        //            list[i] = list[j];
        //            list[j] = temp;
        //            i++;
        //            j--;
        //        }
        //    }

        //    if (left < j)
        //        QuickSortGen2(list, left, j);
        //    if (i < right)
        //        QuickSortGen2(list, i, right);
        //    return list;

        //}
        public static List<T> QuickSortCom<T>(this List<T> list)
        {

            if (list.Count <= 1)
                return list;

            var _pivot = list[0];

            List<T> _less = (from _item in list where _item.CompareTo(_pivot) < 0  select _item).ToList();
            List<T> _same = (from _item in list where _item.CompareTo(_pivot) == 0 select _item).ToList();
            List<T> _greater = (from _item in list where _item.CompareTo(_pivot) > 0 select _item).ToList();

            return (QuickSortCom(_less).Concat(_same.Concat(QuickSortCom(_greater)))).ToList();

        }
    }
    class Program
    {
        public delegate int Comparison<T>(T x, T y);
        
        
        static void Main(string[] arg)
        {
            
            
            //Original List for Sorting
            List<int> original_list = new List<int> { 6, 8, 1, 4, 2, 3, 7, 43, 23, 45, 76, 96, 14 };
            original_list.PrintUnsortedList();

            //Basic Quick sort for List with int
            Console.Write("QuickSort with List int.\n");
            List<int> sortedList = QuickSortInt(original_list, 0, original_list.Count - 1);
            sortedList.PrintList();

            //Quick sort with LINQ
            Console.Write("QuickSort with List and Linq.\n");
            List<int> sortedList2 = QuickSortLin(original_list);
            sortedList2.PrintList();

            //Quick sort for Generics
            Console.Write("QuickSort with List and Gen.\n");
            List<double> originalListDou = new List<double> { 15.8, 6.4, 3.4, 20.6, 1.2 };
            originalListDou.PrintUnsortedList();
            List<double> sortedListDou = QuickSortGen(originalListDou, 0, originalListDou.Count-1);
            sortedListDou.PrintList();

            //Cuick Sort for Generic with Comparison
            Console.Write("QuickSort with Comparison.\n");
            List<double> originalListComp = new List<double> { 15.8, 6.4, 3.4, 20.6, 1.2 };
            originalListComp.PrintUnsortedList();
            List<double> sortedListComp = new List<double> { };
            //List<double> sortedListComp = QuickSortGen2(originalListComp, 0, originalListComp.Count - 1);
            sortedListComp.QuickSortCom();
            sortedListComp.PrintList();



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
        //More complex Quick Sort with LINQ
        public static List<int> QuickSortLin(List<int> list)
        {
            
            if (list.Count <= 1)
                return list;

            int _pivot = list[0];

            List<int> _less = (from _item in list where _item < _pivot select _item).ToList();
            List<int> _same = (from _item in list where _item == _pivot select _item).ToList();
            List<int> _greater = (from _item in list where _item > _pivot select _item).ToList();

            return (QuickSortLin(_less).Concat(_same.Concat(QuickSortLin(_greater)))).ToList();

        }
        //More complex Quick Sort for Generics 
        public static List<double> QuickSortGen(List<double> list, int left, int right)
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
                    var temp = list[i];
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
        //More complex Quick Sort for Generics 

        //-------------------------------
        //
        


    }

    
    

}