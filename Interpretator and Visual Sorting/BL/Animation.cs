using System;
using System.Collections.Generic;
using System.Drawing;

namespace BL
{
    public class Animation
    {
        public enum FrameType { array, bar, change, compare, last, leftright }
        public class Frame
        {
            public FrameType type;
            public int[] array;
            public int a, b, time;

            public Frame(FrameType ft, int[] arr, int t)
            {
                type = ft;
                array = new int[arr.Length];
                for (int i = 0; i < array.Length; i++)
                    array[i] = arr[i];
                time = t;
            }

            public Frame(FrameType ft, int[] arr, int a, int b, int t)
            {
                type = ft;
                array = new int[arr.Length];
                for (int i = 0; i < array.Length; i++)
                    array[i] = arr[i];
                this.a = a;
                this.b = b;
                time = t;
            }
        }

        public int w, h;
        public List<Frame> frames = new List<Frame>();
        public Animation(int width, int height)
        {
            w = width;
            h = height;
        }
        
        public void AddArray(int[] arr, int from, int to)
        {
            frames.Add(new Frame(FrameType.array, arr, from, to, 0));
        }

        public void AddBar(int[] arr, int index)
        {
            frames.Add(new Frame(FrameType.bar, arr, index, 0, 0));
        }
 
        public void AddChange(int[] arr, int a, int b)
        {
            frames.Add(new Frame(FrameType.change, arr, a, b, 0));
        }

        public void AddCompare(int[] arr, int a, int b)
        {
            frames.Add(new Frame(FrameType.compare, arr, a, b, 1));
        }
  
        public void AddLast(int[] arr, int previous, int current)
        {
            frames.Add(new Frame(FrameType.last, arr, previous, current, 0));
        }

        public void AddLeftRight(int[] arr, int left, int right)
        {
            frames.Add(new Frame(FrameType.leftright, arr, left, right, 0));
        }

        private void DrawArray(Graphics g, Frame f, int t)
        {
            for (int i = f.a; i < f.b; i++)
            {
                g.FillRectangle(Brushes.Salmon, 40 * (i + 1), 350 - 30 * f.array[i], 40, 30 * f.array[i]);
                g.DrawRectangle(Pens.Black, 40 * (i + 1), 350 - 30 * f.array[i], 40, 30 * f.array[i]);
            }
        }

        private void DrawBar(Graphics g, Frame f, int t)
        {
            g.FillRectangle(Brushes.YellowGreen, 40 * (f.a + 1), 350 - 30 * f.array[f.a], 40, 30 * f.array[f.a]);
            g.DrawRectangle(Pens.Black, 40 * (f.a + 1), 350 - 30 * f.array[f.a], 40, 30 * f.array[f.a]);
        }

        private void DrawChange(Graphics g, Frame f, int t)
        {
            if (f.array[f.a] > f.array[f.b])
                g.FillRectangle(Brushes.White, 40 * (f.a + 1), 350 - 30 * f.array[f.a], 40, 30 * f.array[f.a]);
            else
                g.FillRectangle(Brushes.White, 40 * (f.b + 1), 350 - 30 * f.array[f.b], 40, 30 * f.array[f.b]);
            if (f.a < f.array.Length - 1)
                g.DrawRectangle(Pens.Black, 40 * (f.a + 2), 350 - 30 * f.array[f.a + 1], 40, 30 * f.array[f.a + 1]);
            if (f.b > 0)
                g.DrawRectangle(Pens.Black, 40 * f.b, 350 - 30 * f.array[f.b - 1], 40, 30 * f.array[f.b - 1]);
            g.FillRectangle(Brushes.CornflowerBlue, 40 * (f.a + 1), 350 - 30 * f.array[f.b], 40, 30 * f.array[f.b]);
            g.DrawRectangle(Pens.Black, 40 * (f.a + 1), 350 - 30 * f.array[f.b], 40, 30 * f.array[f.b]);
            g.FillRectangle(Brushes.DarkCyan, 40 * (f.b + 1), 350 - 30 * f.array[f.a], 40, 30 * f.array[f.a]);
            g.DrawRectangle(Pens.Black, 40 * (f.b + 1), 350 - 30 * f.array[f.a], 40, 30 * f.array[f.a]);
        }

        private void DrawCompare(Graphics g, Frame f, int t)
        {
            if (t == 0)
            {
                g.FillRectangle(Brushes.CornflowerBlue, 40 * (f.a + 1), 350 - 30 * f.array[f.a], 40, 30 * f.array[f.a]);
                g.DrawRectangle(Pens.Black, 40 * (f.a + 1), 350 - 30 * f.array[f.a], 40, 30 * f.array[f.a]);
            }
            if (t == 1)
            {
                g.FillRectangle(Brushes.DarkCyan, 40 * (f.b + 1), 350 - 30 * f.array[f.b], 40, 30 * f.array[f.b]);
                g.DrawRectangle(Pens.Black, 40 * (f.b + 1), 350 - 30 * f.array[f.b], 40, 30 * f.array[f.b]);
            }
        }

        private void DrawLast(Graphics g, Frame f, int t)
        {
            g.FillRectangle(Brushes.White, 40 * (f.a + 1), 360, 40, 30);
            using (Font font = new Font("Times New Roman", 20, FontStyle.Bold, GraphicsUnit.Pixel))
                g.DrawString("last", font, Brushes.Black, 40 * (f.b + 1), 360);
        }

        private void DrawLeftRight(Graphics g, Frame f, int t)
        {
            for (int i = f.a; i <= f.b; i++)
            {
                g.FillRectangle(Brushes.Salmon, 40 * (i + 1), 350 - 30 * f.array[i], 40, 30 * f.array[i]);
                g.DrawRectangle(Pens.Black, 40 * (i + 1), 350 - 30 * f.array[i], 40, 30 * f.array[i]);
            }
            g.FillRectangle(Brushes.DeepPink, 40 * (f.a + 1), 350 - 30 * f.array[f.a], 40, 30 * f.array[f.a]);
            g.DrawRectangle(Pens.Black, 40 * (f.a + 1), 350 - 30 * f.array[f.a], 40, 30 * f.array[f.a]);
            g.FillRectangle(Brushes.DarkViolet, 40 * (f.b + 1), 350 - 30 * f.array[f.b], 40, 30 * f.array[f.b]);
            g.DrawRectangle(Pens.Black, 40 * (f.b + 1), 350 - 30 * f.array[f.b], 40, 30 * f.array[f.b]);
        }

        private int frame_i, subframe_i;

        public bool DrawFrame(Graphics gr)
        {
            using (Bitmap bmp = new Bitmap(w, h))
            {
                bmp.MakeTransparent();
                using (Graphics g = Graphics.FromImage(bmp))
                    switch (frames[frame_i].type)
                    {
                        case FrameType.array:
                            DrawArray(g, frames[frame_i], subframe_i);
                            break;
                        case FrameType.bar:
                            DrawBar(g, frames[frame_i], subframe_i);
                            break;
                        case FrameType.change:
                            DrawChange(g, frames[frame_i], subframe_i);
                            break;
                        case FrameType.compare:
                            DrawCompare(g, frames[frame_i], subframe_i);
                            break;
                        case FrameType.last:
                            DrawLast(g, frames[frame_i], subframe_i);
                            break;
                        case FrameType.leftright:
                            DrawLeftRight(g, frames[frame_i], subframe_i);
                            break;
                    }
                gr.DrawImage(bmp, 0, 0);
            }

            subframe_i++;
            if (subframe_i > frames[frame_i].time)
            {
                frame_i++;
                subframe_i = 0;
            }
            return frame_i < frames.Count;
        }

        public void Dispose()
        {
            frames.Clear();
            w = 0;
            h = 0;
            frame_i = 0;
            subframe_i = 0;
        }
    }
}
