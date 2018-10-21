using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSort
{
    public class ClassQuickSort
    {
        public static int[] MakeArray(int count, char type)
        {
            int[] arr;
            switch (type)
            {
                case 'B':
                    arr = new int[count];
                    for (int i = 0; i < count; i++)
                    {
                        arr[i] = i;
                    }
                    return arr;

                case 'W':
                    arr = new int[count];
                    for (int i = 0, j = count - 1; i < count; i++, j--)
                    {
                        arr[i] = j;
                    }
                    return arr;

                case 'A':
                    arr = new int[count];
                    Random r = new Random();
                    for (int i = 0; i < count; i++)
                    {
                        arr[i] = r.Next(0, count);
                        if (i > 0)
                            for (int j = 0; j < i; j++)
                                if (arr[i] == arr[j])
                                {
                                    i--;
                                    break;
                                }
                    }
                    return arr;
            }
            return null;
        }

        public static void Sort(int[] arr)
        {
            int count = 0;
            Console.WriteLine("Array before sort:");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Quicksort(arr, 0, arr.Length - 1, ref count);
            Console.WriteLine(Environment.NewLine + "Array after sort:");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine(Environment.NewLine + "Number of comparisons " + count);
        }

        public static void Quicksort(int[] array, int start, int end, ref int count)
        {
            if (start >= end)
            {
                return;
            }
            int pivot = PivotList(array, start, end, ref count);
            count++;
            Quicksort(array, start, pivot - 1, ref count);
            Quicksort(array, pivot + 1, end, ref count);
        }

        public static int PivotList(int[] array, int start, int end, ref int count)
        {
            int marker = start;
            for (int i = start; i <= end; i++)
            {
                if (array[i] <= array[end])
                {
                    int temp = array[marker]; 
                    array[marker] = array[i];
                    array[i] = temp;
                    marker += 1;
                }
            }
            return marker - 1;
        }
    }
}
