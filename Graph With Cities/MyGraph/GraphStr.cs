using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGraph
{
    public class CityGraph
    {
        public List<Node> Nodes { get; set; }
        public void AddNode(string name, int x, int y) => Nodes.Add(new Node(name, x, y));

        public void ClearWas()
        {
            foreach (Node item in Nodes)
            {
                item.Was = false;
                item.Distance = -1;
            }
        }

        private void SetDist(Node node)
        {
            ClearWas();
            node.Distance = 0;
            List<Node> MinNodes = new List<Node>() { node };

            for (int i = 0; i < Nodes.Count; i++)
            {
                Node Min = null;
                for (int j = 0; j < MinNodes.Count; j++)
                {
                    if(MinNodes[j].Distance >= 0 &&(Min == null || MinNodes[j].Distance < Min.Distance))
                    {
                        Min = MinNodes[j];
                    }
                }
                if (Min == null)
                    break;
                MinNodes.Remove(Min);
                foreach (Edge item in Min.Edges)
                {
                    if (item.B.Distance == -1)
                        MinNodes.Add(item.B);
                    if (item.B.Distance > Min.Distance + item.Value||item.B.Distance == -1)
                        item.B.Distance = Min.Distance + item.Value;
                }
            }
        }
        public List<Node> GetNodeWithDistMoreN(Node node, int N)
        {
            SetDist(node);
            List<Node> MoreN = new List<Node>();
            foreach (var item in Nodes)
            {
                if (item.Distance > N)
                    MoreN.Add(item);
            }
            return MoreN;
        }

        public void Remove(Node node)
        {
            foreach (Node item in Nodes)
            {
                node.RemoveEdge(item);
            }
            Nodes.Remove(node);
        }

        public CityGraph() => Nodes = new List<Node>();
    }
}
