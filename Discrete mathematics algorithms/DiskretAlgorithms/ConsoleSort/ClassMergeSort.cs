using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSort
{
    public class ClassMergeSort
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
            Console.WriteLine("Массив до сортировки:");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            int[] ans = ClassMergeSort.Merge_Sort(arr, ref count);
            Console.WriteLine(Environment.NewLine + "Массив после сортировки:");
            for (int i = 0; i < ans.Length; i++)
                Console.Write(ans[i] + " ");
            Console.WriteLine(Environment.NewLine + "Число сравнений " + count);
        }

        public static int[] Merge_Sort(int[] arr, ref int count)
        {
            if (arr.Length == 1)
                return arr;
            int mid_point = arr.Length / 2;
            return Merge_Lists(Merge_Sort(arr.Take(mid_point).ToArray(), ref count), Merge_Sort(arr.Skip(mid_point).ToArray(), ref count), ref count);
        }

        public static int[] Merge_Lists(int[] mass1, int[] mass2, ref int count)
        {
            int a = 0, b = 0;
            int[] merged = new int[mass1.Length + mass2.Length];
            for (int i = 0; i < mass1.Length + mass2.Length; i++)
            {
                if (b < mass2.Length && a < mass1.Length)
                    if (mass1[a] > mass2[b])
                    {
                        merged[i] = mass2[b++];
                        count++;
                    }
                    else
                    {
                        merged[i] = mass1[a++];
                        count++;
                    }
                else
                    if (b < mass2.Length)
                    merged[i] = mass2[b++];
                else
                    merged[i] = mass1[a++];
            }
            return merged;
        }
    }
}
