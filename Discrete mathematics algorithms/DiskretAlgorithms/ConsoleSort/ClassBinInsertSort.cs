using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSort
{
    public class ClassBinInsertSort
    {
        public int[] arr;
        public ClassBinInsertSort(int count, char type)
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
            int count = 0;
            int n = arr.Length;
            Console.WriteLine("Array before sort:");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");

            int[] ans = new int[arr.Length];
            ans[0] = arr[0];
            for (int i = 1; i < n; i++)
            {
                int left = 0;
                int right = i - 1;
                while(right > left)
                {
                    int mid = left + (right- left) / 2;
                    count++;
                    if (arr[i] < ans[mid]) right = mid - 1;
                    else left = mid + 1;
                }
                if(arr[i] < ans[left])
                {
                    count++;
                    left--;
                }
                for(int k = i; k > left + 1; k--)
                {
                    ans[k] = ans[k - 1];
                }
                ans[left + 1] = arr[i];
            }
            Console.WriteLine(Environment.NewLine + "Array after sort");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(ans[i] + " ");
            Console.WriteLine("Number of comparisons: " + count);
        }
    }
}
