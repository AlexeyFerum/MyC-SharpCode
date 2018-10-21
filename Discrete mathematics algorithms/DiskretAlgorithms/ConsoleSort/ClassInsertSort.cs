using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSort
{
    public class ClassInsertSort
    {
        public int[] arr;
        public ClassInsertSort(int count, char type)
        {
            switch (type)
            {
                case 'B':
                    arr = new int[count];
                    for (int i = 0; i < count; i++)
                    {
                        arr[i] = i;
                    }
                    break;

                case 'W':
                    arr = new int[count];
                    for (int i = 0, j = count - 1; i < count; i++, j--)
                    {
                        arr[i] = j;
                    }
                    break;

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
                    break;

            }
        }
        public void Sort()
        {
            Console.WriteLine("Array before sort:");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            int count = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        count++;
                        int tmp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = tmp;
                    }
                    else { count++; break; }
                }
            }
            Console.WriteLine(Environment.NewLine + "Array after sort:");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine("Number of comparisons: " + count);
        }
    }
}
