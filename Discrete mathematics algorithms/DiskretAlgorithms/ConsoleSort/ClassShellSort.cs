using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSort
{
    public class ClassShellSort
    {
        public int[] arr;
        public ClassShellSort(int count, char type)
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
            for (int v = 0; v < arr.Length; v++)
                Console.Write(arr[v] + " ");

            int i, j, step, tmp, count = 0;
            int n = arr.Length;
            for (step = n / 3; step > 0; step /= 2)
            {
                for (i = step; i < n; i++)
                {
                    tmp = arr[i];
                    for (j = i; j >= step; j -= step)
                    {
                        if (tmp < arr[j - step])
                        {
                            arr[j] = arr[j - step];
                            count++;
                        }
                        else
                        {
                            count++;
                            break;
                        }
                    }
                    arr[j] = tmp;
                }
            }
            Console.WriteLine(Environment.NewLine + "Array after sort:");
            for (int v = 0; v < arr.Length; v++)
                Console.Write(arr[v] + " ");
            Console.WriteLine("Number of comparisons: " + count);
        }
    }
}
