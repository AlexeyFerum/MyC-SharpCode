using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphLibrary
{
    public class DrawableGraphNode : GraphNode
    {
        public DrawableGraphNode(int id, float x, float y, float radius) : base(id)
        {
            Position = new PointF(x, y);
            Radius = radius;
            FillingColor = Color.White;
        }

        public PointF Position { get; set; }
        public float Radius { get; set; }
        public Color FillingColor { get; set; }
    }
}
