using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGraph
{
    public class Node
    {
        public string Name { get; set; }
        public List<Edge> Edges { get; set; }
        public bool Was { get; set; } = false;
        public int Distance { get; set; } 
        public int X { get; set; }
        public int Y { get; set; }

        public Node(string name,int x, int y)
        {
            Name = name;
            X = x;
            Y = y;
            Edges = new List<Edge>();
        }

        public bool AddEdge(Node node,int value)
        {
            foreach (Edge item in Edges)
            {
                if (item.B == node)
                    return false;
            }
            Edges.Add(new Edge(this, node, value));
            node.Edges.Add(new Edge(node, this, value));

            return true; 
        }

        public bool RemoveEdge(Node node)
        {
            foreach (Edge item in Edges)
            {
                if(item.B == node)
                {
                    foreach (Edge item2 in item.B.Edges)
                    {
                        if (item2.B == this)
                        {
                            item.B.Edges.Remove(item2);
                            break;
                        }
                    }
                    Edges.Remove(item);
                    return true;
                }
            }

            return false; 
        }

        public override string ToString() => Name;
    }
}
