using System;
using System.Drawing;

namespace GraphLibrary
{
    public class GraphEditor 
    { 
        float width;
        float height;
        public GraphEditor(float width = 1000, float height = 1000, float nodeRadius = 20)
        {
            this.width = width;
            this.height = height;
            Radius = nodeRadius;
            CurrGraph = new Graph();
        }

        public Graph CurrGraph { get; set; }
        public float Width
        {
            get
            {
                return width;
            }
        }
        public float Height
        {
            get
            {
                return height;
            }
        }
        public float Radius { get; set; }
        public void AddNode (float x, float y)
        {
            if (x < 0 || x > Width || y < 0 || y > Height)
                throw new ArgumentOutOfRangeException();

            CurrGraph.AddDrawableNode(x, y, Radius);
        }

        public void AddEdge(int from, int to, int weight = 1)
        {
            if (from < 0 || from > CurrGraph.Nodes.Count || to < 0 || to > CurrGraph.Nodes.Count)
                throw new ArgumentOutOfRangeException();

            CurrGraph.AddConnection(from, to, weight);
        }

        public void RemoveEdge(int from, int to)
        {
            if (from < 0 || from > CurrGraph.Nodes.Count || to < 0 || to > CurrGraph.Nodes.Count)
                throw new ArgumentOutOfRangeException();

            CurrGraph.RemoveConnection(from, to);
        }

        public void MoveNode(int id, float newX, float newY)
        {
            if (newX < 0 || newX > Width || newY < 0 || newY > Height)
                throw new ArgumentOutOfRangeException();
            DrawableGraphNode curr = (DrawableGraphNode) CurrGraph.Nodes[id];
            curr.Position = new PointF(newX, newY);
        }

        public void Draw(Graphics field, RectangleF clipRect)
        {
            field.Clear(Color.White);
            foreach (DrawableGraphNode node in CurrGraph.Nodes)
            {
                foreach(var edge in node.To)
                {
                    DrawableGraphNode to = CurrGraph.Nodes[edge.Item1] as DrawableGraphNode;
                    field.DrawLine(Pens.Black, TranslateFromLocal(node.Position, clipRect), 
                                               TranslateFromLocal(to.Position, clipRect));
                    PointF fromDot = TranslateFromLocal(node.Position, clipRect);
                    PointF toDot = TranslateFromLocal(to.Position, clipRect);
                    PointF weightDot = new PointF((fromDot.X + toDot.X) / 2,
                                                  (fromDot.Y + toDot.Y) / 2);
                    field.DrawString(edge.Item2.ToString(),
                                     new Font(new FontFamily(System.Drawing.Text.GenericFontFamilies.Monospace),
                                              node.Radius / 2),
                                     Brushes.SaddleBrown,
                                     weightDot);
                }
            }

            foreach (DrawableGraphNode node in CurrGraph.Nodes)
            {
                PointF dot = TranslateFromLocal(node.Position, clipRect);
                dot = new PointF(dot.X - node.Radius, dot.Y - node.Radius);
                RectangleF rect = new RectangleF(dot,
                                                 new SizeF(node.Radius * 2, node.Radius * 2));
                field.DrawEllipse(Pens.Black, rect);
                field.FillEllipse(new SolidBrush(node.FillingColor), rect);
                field.DrawString(node.Id.ToString(), 
                                 new Font(new FontFamily(System.Drawing.Text.GenericFontFamilies.Monospace), 
                                                         node.Radius / 2), 
                                 Brushes.Black, 
                                 dot.X + node.Radius / 2,
                                 dot.Y + node.Radius / 2);
            }
        }

        public int? TryGetNode(PointF dot, RectangleF clipRect)
        {
            foreach (DrawableGraphNode node in CurrGraph.Nodes)
            {
                PointF centreDot = TranslateFromLocal(node.Position, clipRect);
                PointF currDot = TranslateFromLocal(dot, clipRect);
                if (Math.Pow(currDot.X - centreDot.X, 2) +
                    Math.Pow(currDot.Y - centreDot.Y, 2) <= Math.Pow(node.Radius, 2))
                    return node.Id;
            }
            return null;
        }

        public void ChangeNodeColor(int idNode, Color color)
        {
            if (idNode < 0 || idNode >= CurrGraph.Nodes.Count)
                throw new ArgumentOutOfRangeException();
            DrawableGraphNode node = CurrGraph.Nodes[idNode] as DrawableGraphNode;
            node.FillingColor = color;
        }

        public PointF TranslateToLocal(PointF from, RectangleF clipRect)
        {
            return new PointF(from.X / clipRect.Width * Width, from.Y / clipRect.Height * Height);
        }

        public PointF TranslateFromLocal(PointF from, RectangleF clipRect)
        {
            return new PointF(from.X / Width * clipRect.Width, from.Y / Height * clipRect.Height);
        }
    }
}
