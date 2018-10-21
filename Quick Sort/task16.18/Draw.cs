using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;

namespace task16._18
{
    class Draw
    {
        public static void startmas(int[] arr, Graphics g)
        {
            g.Clear(Color.FromArgb(185, 230, 240));
            for (int i = 0; i < arr.Length; i++)
            {
                g.DrawEllipse(Pens.Black, (i + 1) * 60, 130, 30, 30);
                g.DrawString(arr[i].ToString(), new Font("Times", 15), Brushes.Black, (i + 1) * 60 + 3, 135);
            }
        }

        public static void sravnel(Graphics g, int n, int m, int[] arr)
        {
            g.Clear(Color.FromArgb(185, 230, 240));
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == m)
                {
                    g.FillEllipse(Brushes.Red, (i + 1) * 60, 130, 30, 30);
                    g.DrawEllipse(Pens.Black, (i + 1) * 60, 130, 30, 30);
                    g.DrawString(arr[i].ToString(), new Font("Times", 15), Brushes.Black, (i + 1) * 60 + 3, 135);
                }
                if (i == n)
                {
                    g.FillEllipse(Brushes.Red, (i + 1) * 60, 130, 30, 30);
                    g.DrawEllipse(Pens.Black, (i + 1) * 60, 130, 30, 30);
                    g.DrawString(arr[i].ToString(), new Font("Times", 15), Brushes.Black, (i + 1) * 60 + 3, 135);
                }
                else
                {
                    g.DrawEllipse(Pens.Black, (i + 1) * 60, 130, 30, 30);
                    g.DrawString(arr[i].ToString(), new Font("Times", 15), Brushes.Black, (i + 1) * 60 + 3, 135);
                }

            }
            Thread.Sleep(300);
        }

        public static void Perelet(Graphics g, int[] arr, int n, int m)
        {
            int xn, xm, yn, ym;
            int s = (Math.Abs((m + 1) * 60 - (n + 1) * 60)) / 20;
            for (int i = 0; i < 20; i++)
            {
                g.Clear(Color.FromArgb(185, 230, 240));
                xn = (n + 1) * 60 + i * s;
                xm = (m + 1) * 60 - i * s;
                if (i < 11)
                {
                    yn = 130 - i * 7;
                    ym = 130 + i * 7;
                }
                else
                {
                    yn = 60 + (i - 10) * 7;
                    ym = 200 - (i - 10) * 7;
                }
                for (int j = 0; j < arr.Length; j++)
                {
                    if (j == n)
                    {
                        g.FillEllipse(Brushes.Red, xn, yn, 30, 30);
                        g.DrawEllipse(Pens.Black, xn, yn, 30, 30);
                        g.DrawString(arr[j].ToString(), new Font("Times", 15), Brushes.Black, xn + 3, yn + 5);
                    }
                    else
                    if (j == m)
                    {
                        g.FillEllipse(Brushes.Red, xm, ym, 30, 30);
                        g.DrawEllipse(Pens.Black, xm, ym, 30, 30);
                        g.DrawString(arr[j].ToString(), new Font("Times", 15), Brushes.Black, xm + 3, ym + 5);
                    }
                    else
                    {
                        g.DrawEllipse(Pens.Black, (j + 1) * 60, 130, 30, 30);
                        g.DrawString(arr[j].ToString(), new Font("Times", 15), Brushes.Black, (j + 1) * 60 + 3, 135);
                    }

                }

                Thread.Sleep(200);
            }
        }
    }
}
