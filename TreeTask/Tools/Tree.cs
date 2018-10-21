using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{

    public class Node
    {
        public Node Parent { get; set; }
        public int Value { get; set; }
        public List<Node> Nodes { get; set; }

        public int GetLevelCount()
        {
            if (Nodes.Count == 0)
                return 1;
            else
            {
                int max = 0;
                for (int i = 0; i < Nodes.Count; i++)
                    max = Math.Max(max, Nodes[i].GetLevelCount());
                return max + 1;
            }
        }

        public Node(int value = 0, Node parent = null) 
        {
            Value = value;
            Parent = parent;
            Nodes = new List<Node>();
        }

        public void Add(int value) 
        {
            Nodes.Add(new Node(value, this));
        }

        public bool SearchTree(out int min, out int max) 
        {
            if (Nodes.Count == 0) 
            {
                min = Value; max = Value;

                return true;
            }

            if (Nodes.Count == 1)
            {
                bool t = Nodes[0].SearchTree(out int minT, out int maxT);
                if (t)
                {
                    if (Nodes[0].Value > Value && minT > Value || Nodes[0].Value < Value && maxT < Value)
                    {
                        min = Math.Min(Value, minT);
                        max = Math.Max(Value, maxT);

                        return true;
                    }
                }
                min = 0; max = 0;

                return false;
            }

            bool L = Nodes[0].SearchTree(out int minL, out int maxL);
            bool R = Nodes[1].SearchTree(out int minR, out int maxR);

            if (L && R)
            {
                if (Nodes[0].Value < Value && maxL < Value && Nodes[1].Value > Value && minR > Value)
                {
                    min = minL;
                    max = maxR;

                    return true;
                }
            }

            min = 0;
            max = 0;

            return false;
        }
    }

    public class Tree
    {
        public Node Root { get; set; } 

        public int GetLevelCount() => Root.GetLevelCount();

        public Tree()
        {
            Root = new Node();
        }

        public bool TreeSearch()
        {
            return Root.SearchTree(out int min, out int max);
        }
    }
}