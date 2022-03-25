using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_III
{
    public struct SortData
    {
        /// <summary>
        /// Moyenne pour le tri par insertion
        /// </summary>
        public long InsertionMean { get; set; }
        /// <summary>
        /// Écart-type pour le tri par insertion
        /// </summary>
        public long InsertionStd { get; set; }
        /// <summary>
        /// Moyenne pour le tri rapide
        /// </summary>
        public long QuickMean { get; set; }
        /// <summary>
        /// Écart-type pour le tri rapide
        /// </summary>
        public long QuickStd { get; set; }
    }

    public static class SortingPerformance
    {
        public static void DisplayPerformances(List<int> sizes, int count)
        {
            List<SortData> lsd = new List<SortData>();
            lsd = PerformancesTest(sizes,count);

            Console.WriteLine("n ;MeanInsertion ;StdInsertion ;MeanQuick ;StdQuick");
            for(int i = 0; i < sizes.Count; i++)
            {
                //Console.WriteLine(sizes[i] + ";" + lsd[i].InsertionMean );
                Console.WriteLine($"{sizes[i]};{lsd[i].InsertionMean};{lsd[i].InsertionStd}" );
            }
        }

        public static List<SortData> PerformancesTest(List<int> sizes, int count)
        {
            List<SortData> tabList = new List<SortData>();
            for (int i = 0; i < sizes.Count; i++)
            {
                tabList.Add(PerformanceTest(sizes[i], count));
            }

            return tabList;
        }

        public static SortData PerformanceTest(int size, int count)
        {
            long moyenne1 = 0;
            long moyenne2 = 0;
            long ET1 = 0;
            long ET2 = 0;

            for (int i = 0; i < count; i++)
            {
                List<int[]> tabList = ArraysGenerator(size);

                moyenne1 += UseInsertionSort(tabList[0]);
                moyenne2 += UseQuickSort(tabList[1]);


            }
            moyenne1 = moyenne1 / count;
            moyenne2 = moyenne2 / count;

            ET1 = moyenne1 * moyenne1 ;
            ET2 = moyenne2 ;

            SortData resultat = new SortData();
            resultat.InsertionMean = moyenne1;
            resultat.QuickMean = moyenne2;
            resultat.InsertionStd = ET1;
            resultat.QuickStd = ET2;
            return resultat;
        }

        private static List<int[]> ArraysGenerator(int size)
        {
            List<int[]> tabList = new List<int[]>();
            int[] tab1 = new int[size];
            int[] tab2 = new int[size];
            int nb;
            var randomNb = new Random();

            for (int i = 0; i < size; i++)
            {
                nb = randomNb.Next(-1000, 1000);
                tab1[i] = nb;
                tab2[i] = nb;
            }
            tabList.Add(tab1);
            tabList.Add(tab2);
            return tabList;
        }

        public static long UseInsertionSort(int[] array)
        {
            Stopwatch s = Stopwatch.StartNew();
            InsertionSort(array);
            s.Stop();
            long tempsInsertionSort = s.ElapsedMilliseconds;
            return tempsInsertionSort;
        }

        public static long UseQuickSort(int[] array)
        {
            Stopwatch s = Stopwatch.StartNew();
            QuickSort(array, 0, array.Length - 1);
            s.Stop();
            long tempsQuickSort = s.ElapsedMilliseconds;
            return tempsQuickSort;
        }

        private static void InsertionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        int tmp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = tmp;
                    }
                }
            };
        }

        private static void QuickSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(array, left, right);
                QuickSort(array, left, pivot - 1);
                QuickSort(array, pivot + 1, right);
            }
        }

        private static int Partition(int[] array, int left, int right)
        {
            int pivot = array[right];
            int i = left;
            for (int j = left; j < right; j++)
            {
                if (array[j] < pivot)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                }
            }
            int tmp = array[i];
            array[i] = array[right];
            array[right] = tmp;
            return i;
        }
    }
}
