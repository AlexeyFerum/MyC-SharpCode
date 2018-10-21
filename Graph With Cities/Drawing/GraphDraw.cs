using MyGraph;
using System;
using System.Drawing;

namespace Drawing
{
    public class GraphDraw 
    {
        Bitmap Bitmap { get; set; }
        Graphics G;
        public int Height { get; set; }
        public int Width { get; set; }

        public Size size
        {
            get => new Size(Width, Height);
            set
            {
                Width = value.Width;
                Height = value.Height;
            }
        }

        public CityGraph graph { get; set; }
        private int R = 30; 

        private void DrawNode(Node node) 
        {
            node.Was = true;
            for (int i = 0; i < node.Edges.Count; i++)
                if (!node.Edges[i].B.Was)
                {
                    G.DrawLine(Pens.Black, node.X, node.Y, node.Edges[i].B.X, node.Edges[i].B.Y);
                    SizeF s = G.MeasureString(node.Edges[i].Value.ToString(), new Font("Microsoft Sans Serif", 15));
                    G.DrawString(node.Edges[i].Value.ToString(), new Font("Microsoft Sans Serif", 15), Brushes.Peru,
                        (node.X + node.Edges[i].B.X) / 2 -s.Width/2, (node.Y + node.Edges[i].B.Y) / 2-s.Height/2);
                }

            G.FillEllipse(Brushes.LightGreen, node.X - R, node.Y - R, 2 * R, 2 * R);
            G.DrawEllipse(Pens.DarkGreen, node.X - R, node.Y - R, 2 * R, 2 * R);
            float t = 0;
            string text = node.Name.ToString();

            do
            {
                t += (float)0.2;
            }
            while (G.MeasureString(text, new Font("Microsoft Sans Serif", t)).Width < R * 3 / 2);

            StringFormat sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            G.DrawString(text, new Font("Microsoft Sans Serif", t), Brushes.Black, new Rectangle(node.X - R, node.Y - R, 2 * R, 2 * R), sf);
        }

        public GraphDraw(Size size, CityGraph graph)
        {
            this.size = size;
            this.graph = graph;
        }

        public GraphDraw(int height, int width, CityGraph graph)
        {
            Height = height;
            Width = width;
            this.graph = graph;
        }

        public Bitmap Draw()
        {
            Bitmap = new Bitmap(Width, Height);
            G = Graphics.FromImage(Bitmap);
            graph.ClearWas();
            foreach (Node item in graph.Nodes)
                DrawNode(item);

            return Bitmap;
        }

        public bool Empty(int X, int Y) 
        {
            foreach (Node item in graph.Nodes)
            {
                if (Math.Pow(item.X - X, 2) + Math.Pow(item.Y - Y, 2) < 4 * R)
                    return false;
            }

            return true;
        }
        
        public Node GetNode(int X, int Y)
        {
            foreach (Node item in graph.Nodes)
            {
                if (Math.Pow(item.X - X, 2) + Math.Pow(item.Y - Y, 2) < R * R)
                    return item;
            }

            return null;
        }
    }
}