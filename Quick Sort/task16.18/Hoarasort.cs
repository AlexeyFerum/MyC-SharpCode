using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace task16._18
{
    public class Hoarasort
    {
        private static void BubSort(int left, int right, int[] arr, Graphics g)
        {
            for (int c = left; c < right; c++)
            {
                for (int k = right; k >= c + 1; k--)
                {

                    Draw.sravnel(g, k - 1, k, arr);
                    if (arr[k - 1] > arr[k])

                    {
                        Draw.Perelet(g, arr, k - 1, k);
                        int t = arr[k - 1];

                        arr[k - 1] = arr[k];

                        arr[k] = t;

                    }
                    Draw.startmas(arr, g);
                }
            }
        }
        public static void QuickSort(int left, int right, int[] arr, Graphics g)
        {
            if (right - left <= 4)
            {
                BubSort(left, right, arr, g);
                return;
            }

            int i = left; int j = right;
            int r = (left + right) / 2;
            int x = arr[r];

            do
            {
                while (arr[i] < x)
                {
                    Draw.sravnel(g, i, r, arr);
                    i++;
                }

                while (arr[j] > x)
                {
                    Draw.sravnel(g, r, j, arr);
                    j--;
                }

                if (i <= j) 
                {
                    Draw.sravnel(g, i, j, arr);
                    if (i != j)
                    {
                        Draw.Perelet(g, arr, i, j);
                    }
                    int tmp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tmp;
                    i++; j--;
                }
            }
            while (i <= j);

            if (left < j)
            {
                QuickSort(left, j, arr, g);
            }

            if (i < right)
            {
                QuickSort(i, right, arr, g);
            }
        }
    }
}