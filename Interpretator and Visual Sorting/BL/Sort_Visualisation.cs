using System;
using System.Drawing;

namespace BL
{

    public static class SortVisualisation
    {
        public static void Bubble(int[] a, Animation anim)
        {
            int tmp, i, j;
            anim.AddArray(a, 0, a.Length - 1);
            for (i = 0; i < a.Length; i++)
            {
                for (j = a.Length - 1; j > i; j--)
                {
                    anim.AddCompare(a, j, j - 1);
                    if (a[j] < a[j - 1])
                    {
                        anim.AddChange(a, j, j - 1);
                        tmp = a[j];
                        a[j] = a[j - 1];
                        a[j - 1] = tmp;
                    }
                    anim.AddArray(a, i, j + 1);
                }
                if (i == a[i] - 1)
                    anim.AddBar(a, i);
            }
        }
        
        public static void Shaker(int[] a, Animation anim)
        {
            int tmp, left = 1, right = a.Length - 1, last = right, lleft = left, lright = right;
            anim.AddLeftRight(a, left, right);
            anim.AddLast(a, last, last);

            while (left < right)
            {
                for (int j = right; j >= left; j--)
                {
                    anim.AddCompare(a, j, j - 1);
                    if (a[j - 1] > a[j])
                    {
                        anim.AddChange(a, j, j - 1);
                        tmp = a[j - 1];
                        a[j - 1] = a[j];
                        a[j] = tmp;

                        anim.AddLast(a, last, j);
                        last = j;
                    }
                    anim.AddLeftRight(a, left, right);
                }

                left = last;
                anim.AddLeftRight(a, left, right);
                for (int i = lleft - 1; i < left; i++)
                    anim.AddBar(a, i);
                lleft = left;

                for (int j = left + 1; j <= right; j++)
                {
                    anim.AddCompare(a, j, j - 1);
                    if (a[j - 1] > a[j])
                    {
                        anim.AddChange(a, j, j - 1);
                        tmp = a[j - 1];
                        a[j - 1] = a[j];
                        a[j] = tmp;
                        
                        anim.AddLast(a, last, j);
                        last = j;
                    }
                    anim.AddLeftRight(a, left, right);
                }

                right = last - 1;
                anim.AddLeftRight(a, left, right);
                for (int i = lright; i > right; i--) 
                    anim.AddBar(a, i);
                lright = right;
            }
            for (int i = lleft - 1; i <= lright; i++)
                anim.AddBar(a, i);
        }
        
        public static void Shuffle(int[] a) 
        {
            Random rnd = new Random();
            int n = a.Length;
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                int value = a[k];
                a[k] = a[n];
                a[n] = value;
            }
        }
        
        public static void DrawArray(Graphics gForm, int[] a)
        {
            for (int i = 1; i <= a.Length; i++)
            {
                gForm.FillRectangle(Brushes.Salmon, 40 * i, 350 - 30 * a[i - 1], 40, 30 * a[i - 1]);
                gForm.DrawRectangle(Pens.Black, 40 * i, 350 - 30 * a[i - 1], 40, 30 * a[i - 1]);
            }
        }
    }
}
