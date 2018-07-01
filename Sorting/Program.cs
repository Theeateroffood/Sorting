using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Class bleh = new Class();
            List<int> CSV_Lines = bleh.ImportCSV("unsorted_numbers.csv");
            int[] arr = CSV_Lines.ToArray();

            Console.WriteLine("Insertion time : " + bleh.InsertionSort(arr) + " Miliseconds");
            arr = CSV_Lines.ToArray();
            Console.WriteLine("Shellsort time : " + bleh.ShellSort(arr) + " Miliseconds");

            Console.WriteLine("---------------------------------------------------------------");

            Console.WriteLine("Linear Seach 1500 Time : " + bleh.LinearSearch(arr, 1500));
            Console.WriteLine("Linear Seach 3000 Time : " + bleh.LinearSearch(arr, 3000));
            Console.WriteLine("Linear Seach 4500 Time : " + bleh.LinearSearch(arr, 4500));
            Console.WriteLine("Linear Seach 6000 Time : " + bleh.LinearSearch(arr, 6000));
            Console.WriteLine("Linear Seach 7500 Time : " + bleh.LinearSearch(arr, 7500));
            Console.WriteLine("Linear Seach 9000 Time : " + bleh.LinearSearch(arr, 9000));
            Console.WriteLine("Linear Seach 10500 Time : " + bleh.LinearSearch(arr, 10500));
            Console.WriteLine("Linear Seach 12000 Time : " + bleh.LinearSearch(arr, 12000));
            Console.WriteLine("Linear Seach 13500 Time : " + bleh.LinearSearch(arr, 13500));
            Console.WriteLine("Linear Seach 15000 Time : " + bleh.LinearSearch(arr, 15000));
            Console.WriteLine();
            Console.WriteLine("Binary Seach 1500 Time : " + bleh.BinarySearchIterative(arr, 1500));
            Console.WriteLine("Binary Seach 3000 Time : " + bleh.BinarySearchIterative(arr, 3000));
            Console.WriteLine("Binary Seach 4500 Time : " + bleh.BinarySearchIterative(arr, 4500));
            Console.WriteLine("Binary Seach 6000 Time : " + bleh.BinarySearchIterative(arr, 6000));
            Console.WriteLine("Binary Seach 7500 Time : " + bleh.BinarySearchIterative(arr, 7500));
            Console.WriteLine("Binary Seach 9000 Time : " + bleh.BinarySearchIterative(arr, 9000));
            Console.WriteLine("Binary Seach 10500 Time : " + bleh.BinarySearchIterative(arr, 10500));
            Console.WriteLine("Binary Seach 12000 Time : " + bleh.BinarySearchIterative(arr, 12000));
            Console.WriteLine("Binary Seach 13500 Time : " + bleh.BinarySearchIterative(arr, 13500));
            Console.WriteLine("Binary Seach 15000 Time : " + bleh.BinarySearchIterative(arr, 15000));

            Console.ReadLine();
        }
    }
}
