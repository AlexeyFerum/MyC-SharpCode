using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGraph
{
    public class Edge 
    {
        public Node A { get; set; } 
        public Node B { get; set; } 
        public int Value { get; set; } 

        public Edge(Node a, Node b, int value)
        {
            A = a;
            B = b;
            Value = value;
        }
    }
}
