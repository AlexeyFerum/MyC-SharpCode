using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphLibrary
{
    public class GraphNode
    {
        int id;
        public int Id
        {
            get
            {
                return id;
            }
        }
        public List<Tuple<int, int>> To { get; set; }

        public GraphNode(int id, List<Tuple<int, int>> to)
        {
            this.id = id;
            To = to;
        }

        public GraphNode(int id)
        {
            this.id = id;
            To = new List<Tuple<int, int>>();
        }

        public GraphNode(int id, List<GraphNode> list)
        {
            this.id = id;
            To = new List<Tuple<int, int>>();
            foreach (var node in list)
            {
                To.Add(new Tuple<int, int>(node.Id, 1));
            }
        }
    }
}
