using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphLibrary
{
    public class Graph
    {
        public Graph()
        {
            currentId = 0;
            Nodes = new List<GraphNode>();
        }

        public void AddNode()
        {
            GraphNode node = new GraphNode(currentId++);
            Nodes.Add(node);
        }
       
        public void AddDrawableNode(float x, float y, float radius)
        {
            Nodes.Add(new DrawableGraphNode(currentId++, x, y, radius));
        }

        public void AddConnection(int idFrom, int idTo, int weight = 1)
        {
            if (idFrom >= currentId || idTo >= currentId)
                throw new ArgumentOutOfRangeException();

            if (idFrom == idTo)
                return;
            Nodes[idFrom].To.Add(new Tuple<int, int>(idTo, weight));
        }

        public void RemoveConnection(int idFrom, int idTo)
        {
            Nodes[idFrom].To.RemoveAll(edge => edge.Item1 == idTo);
        }
        
        public bool CheckConnectivity()
        {
            if (Nodes.Count == 0)
                return false;

            List<bool> visited = new List<bool>();
            for (int i = 0; i < Nodes.Count; i++)
                visited.Add(false);

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(0);
            while (queue.Count != 0)
            {
                int id = queue.Dequeue();
                if (visited[id])
                    continue;
                visited[id] = true;
                foreach(var node in Nodes[id].To)
                {
                    queue.Enqueue(node.Item1);
                }
            }

            if (Nodes.Exists(x => !visited[x.Id]))
                return false;
            return true;
        }

        public void ChangeNodeColor(int idNode, Color color)
        {
            if (idNode < 0 || idNode >= Nodes.Count)
                throw new ArgumentOutOfRangeException();
            DrawableGraphNode node = Nodes[idNode] as DrawableGraphNode;
            node.FillingColor = color;
        }

        /*
          Check for graph bipartiteness.
          If graph can be colored with two colors, then it's bipartite.
          If graph is not connected, it's not assumed to be bipartite.
        */
        public bool CheckBipartiteness()
        {
            if (currentId == 0)
                return false;

            // list which stores 'color' of each node, 0 means no color 
            List<int> colors = new List<int>();
            for (int i = 0; i < Nodes.Count; i++)
                colors.Add(0);

            // breadth-first search 
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(0);
            ChangeNodeColor(0, Color.Green);
            colors[0] = 1;
            while (queue.Count != 0)
            {
                int currentNode = queue.Dequeue();
                foreach (var edge in Nodes[currentNode].To) //To - Обозначает вершины, смежные с данной (Ребра)
                {
                    int adjacentNode = edge.Item1; // соседний Node
                    if (colors[adjacentNode] == 0)
                    {
                        // 3 because one Node can be colored in two colors (1 or 2). 
                        // So if the current color is 1 we need to get 2 and if the current color is 2 we need 1 
                        // 2 - Red, 1 - Blue
                        if (colors[currentNode] == 2)
                        {
                            ChangeNodeColor(adjacentNode, Color.Green);
                            colors[adjacentNode] = 3 - colors[currentNode];
                        }
                        else
                        {
                            if (colors[currentNode] == 1)
                            {
                                ChangeNodeColor(adjacentNode, Color.Orange);
                                colors[adjacentNode] = 3 - colors[currentNode];
                            }
                            else
                            {
                                if (colors[currentNode] == 0)
                                {
                                    ChangeNodeColor(currentNode, Color.Orange);
                                }
                            }
                        }
                        queue.Enqueue(adjacentNode);
                    }
                    if (colors[adjacentNode] == colors[currentNode])
                        return false;
                }
            }
            if (Nodes.Exists(x => colors[x.Id] == 0))//если существуют узлы, в которых мы не были (проверка на связность)
                return false;
            return true;
        }
        
        public List<GraphNode> Nodes { get; set; }
        int currentId;
    }
}
