using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Sorting
{
    public class Class
    {
        public List<int> ImportCSV(string CSVPath)
        {
            List<int> CSV_Lines = new List<int>();
            string line;

            StreamReader CSV = new StreamReader(CSVPath);
            while ((line = CSV.ReadLine()) != null)
            {
                try
                {
                    CSV_Lines.Add(Convert.ToInt32(line));
                }
                catch (Exception) { }
            }

            return CSV_Lines;
        }

        public void PrintList(Array CSV_Lines)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            foreach (var i in CSV_Lines)
            {

                Console.WriteLine(i);
            }
            watch.Stop();

            Console.WriteLine(watch.ElapsedMilliseconds);
        }

        public int InsertionSort(int[] array)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();


            int j;
            int temp;

            for (int i = 1; i < array.Length; i++)
            {
                j = i;
                while (j > 0 && array[j] < array[j - 1])
                {
                    temp = array[j];
                    array[j] = array[j - 1];
                    array[j - 1] = temp;
                    j--;
                }
            }

            watch.Stop();

            return unchecked((int)watch.ElapsedMilliseconds);
        }

        public int LinearSearch(int[] list, int item)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            int value = -1;
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] == item)
                {
                    value = i;
                    break;
                }
            }
            watch.Stop();

            return unchecked((int)watch.ElapsedMilliseconds);
            }

        public int ShellSort(int[] array)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            int n = array.Length;
            int gap = n / 2;
            int temp;

            while (gap > 0)
            {
                for (int i = 0; i + gap < n; i++)
                {
                    int j = i + gap;
                    temp = array[j];

                    while (j - gap >= 0 && temp < array[j - gap])
                    {
                        array[j] = array[j - gap];
                        j = j - gap;
                    }

                    array[j] = temp;
                }

                gap = gap / 2;
            }

            watch.Stop();
            
            return unchecked((int)watch.ElapsedMilliseconds);

        }

        public int BinarySearchIterative(int[] inputArray, int key)
        {

            var watch = System.Diagnostics.Stopwatch.StartNew();

            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (key == inputArray[mid])
                {
                    return ++mid;
                }
                else if (key < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            watch.Stop();

            return unchecked((int)watch.ElapsedMilliseconds);
        }
    }
}
