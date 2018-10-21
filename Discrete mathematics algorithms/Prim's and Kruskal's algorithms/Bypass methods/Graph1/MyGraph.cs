using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Drawing.Drawing2D;

namespace Graph1
{
    [Serializable]
    public class Graph         
    {
        public List<GNode> Nodes = new List<GNode>();

        public int r = 10; 
        public GNode selected = null; 
        
        [Serializable]
        public class GNode          
        {
            public int x;
            public int y;
            public string inf;   
            public string name;  
            public List<GEdge> Edge = new List<GEdge>(); 
            public bool visit = false;   
            public bool pereferia =false;
            public int componenta = 0;     

            public GNode(int x, int y, string inf, string name)
            {
                this.x = x;
                this.y = y;
                this.name = name;
                this.inf = inf;
            }
        }

        [Serializable]
        public class GEdge           
        {
            public int weight;   
            public int number;     
            public GNode first;  
            public GNode second;  
            public bool inminostov = false;
            public GEdge(GNode first, GNode second)
            {
                this.first = first;
                this.second = second;
            }
        }

        public Graph OpenFile(string filename)
        {
            Graph g;
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream filestream = new FileStream(filename, FileMode.OpenOrCreate))
            {
                g = (Graph)formatter.Deserialize(filestream);
            }
            return g;
        }
        public void SaveFile(string filename, Graph a)  
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, a);
            }
        }

        public void CleanSelected()
        {
            selected = null;
        }

        public void Draw(Graphics g, bool isEllipse)
        {
            Font a = new Font("Times New Roman", 12);
            Font b = new Font("Times New Roman", 8);
            Random rnd = new Random();
            for (int i = 0; i < Nodes.Count; i++)
            {
                for (int j = 0; j < Nodes[i].Edge.Count; j++)
                {
                    if (Nodes[i].Edge[j].first == Nodes[i].Edge[j].second)
                    {
                        g.DrawEllipse(Pens.Black, Nodes[i].x, Nodes[i].y, 30, 30); 
                    }
                    Pen open = new Pen(Brushes.Black, 5);
                    g.DrawLine(Nodes[i].Edge[j].inminostov ? open : Pens.Black, Nodes[i].Edge[j].first.x, Nodes[i].Edge[j].first.y, Nodes[i].Edge[j].second.x, Nodes[i].Edge[j].second.y);
                    g.DrawString(Nodes[i].Edge[j].weight.ToString(), b, Brushes.Black, (Nodes[i].Edge[j].first.x + Nodes[i].Edge[j].second.x) / 2, (Nodes[i].Edge[j].first.y + Nodes[i].Edge[j].second.y) / 2);
                }

            }
            for (int i = 0; i < Nodes.Count; i++)
            {
                var p = GetXYByIndex(i);
                if (!isEllipse)
                {
                    g.FillRectangle(((Nodes[i] == selected) || (Nodes[i].visit)) ? Brushes.Black : Brushes.IndianRed, p.X - r, p.Y - r, 2 * r, 2 * r);
                    g.DrawRectangle(Pens.Black, p.X - r, p.Y - r, 2 * r, 2 * r);
                }
                else 
                {
                    g.FillEllipse((Nodes[i] == selected || (Nodes[i].visit)) ? Brushes.Black : Brushes.IndianRed, p.X - r, p.Y - r, 2 * r, 2 * r);
                    g.DrawEllipse(Pens.Black, p.X - r, p.Y - r, 2 * r, 2 * r);

                }
                if (Nodes[i].pereferia)
                    g.FillEllipse( Brushes.Blue, p.X - r, p.Y - r, 2 * r, 2 * r);
                g.DrawString(Nodes[i].name, a, Brushes.Beige, p.X - r, p.Y - r);
            }
        }

        public void AddNode(string name, string inf, int x, int y) 
        {
            for (int i = 0; i < Nodes.Count; i++)
            {
                if (Nodes[i].name == name)
                    throw new Exception("Node with this name already exist");
                if ((x - 2 * r <= Nodes[i].x) && (Nodes[i].x <= x + 2 * r) && (y - 2 * r <= Nodes[i].y) && (Nodes[i].y <= y + 2 * r))// не наезжают друг на друга
                    throw new Exception("Node already exist at this location");
            }
            GNode n = new GNode(x, y, inf, name);
            Nodes.Add(n);
        }

        public void AddEdge(int f, int s, int val)  
        {
            GEdge e = new GEdge(Nodes[f], Nodes[s]);
            e.weight = val;
            Nodes[f].Edge.Add(e);
        }

        public void AddEdgeClick(bool flag, int x, int y, int val)     
        {
            GNode selected2 = GetGnodeByXY(x, y);
            if (selected2 == null)
                return;
            if (selected == null)
            {
                selected = selected2;
            }
            else
            {
                GEdge e = new GEdge(selected, selected2);
                e.weight = val;
                selected.Edge.Add(e);
                if (!flag)
                {
                    GEdge f = new GEdge(selected2, selected);  
                    f.weight = val;
                    selected2.Edge.Add(f);
                }
                selected = null;
            }
        }

        public void NodeDeleteByXY(int x, int y)                
        {
            GNode a = GetGnodeByXY(x, y);
            if (a == null)
                return;
            else
            {
                for (int i = 0; i < Nodes.Count; i++)
                {
                    for (int j = 0; j < Nodes[i].Edge.Count; j++)
                    {
                        if ((Nodes[i].Edge[j].first == a) || (Nodes[i].Edge[j].second == a))
                        {
                            Nodes[i].Edge.Remove(Nodes[i].Edge[j]);
                            --j;
                        }
                    }

                }
                for (int o = 0; o < a.Edge.Count; o++)
                {
                    a.Edge.Remove(a.Edge[o]);
                    --o;
                }
                Nodes.Remove(a);
            }
        }

        public void EdgeDelete(int x, int y) 
        {
            GNode a = GetGnodeByXY(x, y);
            if (a == null)
            {
                return;
            }
            if (selected == null)
            {
                selected = a;
                return;
            }
            else
            {
                for (int i = 0; i < selected.Edge.Count; i++)
                {
                    if ((selected.Edge[i].first == a) || (selected.Edge[i].second == a))
                    {
                        selected.Edge.Remove(selected.Edge[i]);
                        --i;
                    }
                }
                for (int j = 0; j < a.Edge.Count; j++)
                {
                    if ((a.Edge[j].first == selected) || (a.Edge[j].second == selected))
                    {
                        a.Edge.Remove(a.Edge[j]);
                        --j;
                    }
                }
            }
            selected = null;
        }

        public void NodeMoveByXY(int x, int y)   
        {
            GNode a = GetGnodeByXY(x, y);
            if (a != null)
            {
                selected = a;
                return;
            }
            if (selected != null)
            {
                for (int i = 0; i < Nodes.Count; i++)
                {
                    if ((x - 2 * r <= Nodes[i].x) && (Nodes[i].x <= x + 2 * r) && (y - 2 * r <= Nodes[i].y) && (Nodes[i].y <= y + 2 * r))// не наезжают друг на друга
                        throw new Exception("Node already exist at this location");
                }
                selected.x = x;
                selected.y = y;
                selected = null;
            }
        }

        public void NodeExchange(int x, int y) 
        {
            GNode a = GetGnodeByXY(x, y);
            if (a == null)
            {
                return;
            }
            if (selected == null)
            {
                selected = a;
                return;
            }
            if (selected != null)
            {
                GNode b = new GNode(0, 0, null, null);
                b.x = selected.x;
                b.y = selected.y;
                b.inf = selected.inf;
                selected.x = a.x;
                selected.y = a.y;
                selected.inf = a.inf;
                a.x = b.x;
                a.y = b.y;
                a.inf = b.inf;
                selected = null;
            }
        }

        private GNode GetGnodeByXY(int x, int y)  
        {
            for (int i = 0; i < Nodes.Count; i++)
            {
                if ((x - r <= Nodes[i].x) && (Nodes[i].x <= x + r) && (y - r <= Nodes[i].y) && (Nodes[i].y <= y + r))
                    return Nodes[i];
            }
            return null;
        }

        public Point GetXYByName(string name)      
        {
            GNode n = Nodes[GetNodeIndexByName(name)];
            return new Point(n.x, n.y);
        }

        public Point GetXYByIndex(int index)      
        {
            GNode n = Nodes[index];
            return new Point(n.x, n.y);
        }

        public string GetNodeInformationByIndex(int index)  
        {
            return (Nodes[index].inf);
        }

        public string GetNodeInformationByName(string name)    
        {
            return (Nodes[GetNodeIndexByName(name)].inf);
        }

        public int GetNodeIndexByName(string name)     
        {
            for (int i = 0; i < Nodes.Count; i++)
            {
                if (Nodes[i].name == name)
                    return i;
            }
            throw new Exception("No node");
        }

        public void FindWay(int N)
        {
            Visiter();    
            Obhod(Nodes[0]);   
            for (int j = 0; j < Nodes.Count; j++)
            {
                if (!Nodes[j].visit)  
                {
                    throw new Exception("Cant find way from 1 node to other.");
                }
            }
            Visiter();
            FindWay(Nodes[0], null, 0, N);
        }

        private bool AllVisited()
        {
            bool answer = true;  
            for (int i = 0; i < Nodes.Count; i++)
            {
                if (Nodes[i].visit == false)
                    answer = false;
            }
            return answer;
        }

        private void FindWay(GNode a, GNode previous, int summ, int N)
        {
            a.visit = true;
            Way.Add(a);
            for (int i = 0; i < a.Edge.Count; i++)
            {
                if (a.Edge[i].second == previous)
                    continue;
                if (a.Edge[i].second == Way[0])
                {
                    if (AllVisited())
                    {
                        Result.Add(new List<GNode>(Way));
                    }

                }
                else
                {
                    if (!a.Edge[i].second.visit)
                    {
                        if ((summ + a.Edge[i].weight) <= N)
                            FindWay(a.Edge[i].second, a, summ + a.Edge[i].weight, N);
                    }
                }
            }
            a.visit = false;
            Way.Remove(a);
        }

        List<List<GNode>> Result = new List<List<GNode>>();
        List<Queue<GNode>> Result2 = new List<Queue<GNode>>();
        List<GNode> Way = new List<GNode>();
        List<string> res = new List<string>();
        Queue<GNode> q = new Queue<GNode>();

        public void Reseter()
        {
            Result = new List<List<GNode>>();
            Way = new List<GNode>();
            res = new List<string>();
            q = new Queue<GNode>();
        }
        public string[] ReturnWaysResult()
        {
            if (Result.Count == 0)
                throw new Exception("No ways in this graph");
            string a = null;
            for (int i = 0; i < Result.Count; i++)
            {
                a += (i + 1).ToString() + " way : ";
                for (int j = 0; j < Result[i].Count; j++)
                {
                    if (j == Result[i].Count - 1)
                        a += Result[i][j].name;
                    else
                        a += Result[i][j].name + "->";
                }
                a += "\r\n";
                res.Add(a);
                a = null;
            }
            return res.ToArray();
        }

        public void Visiter() 
        {
            for (int i=0;i<Nodes.Count;i++)
            {
                Nodes[i].visit = false;
            }
        }

        public void ObhodInDepth(GNode a)   
        {
                a.visit = true;
                Way.Add(a);

                if (a.Edge.Count == 0)
                {
                    Result.Add(new List<GNode>(Way));
                }

                for (int i = 0; i < a.Edge.Count; i++)
                {
                    ObhodInDepth(a.Edge[i].second);
                }

                Way.Remove(a);
        }
        
        public string ObhodInBreadth(GNode a)   
        {
            string result = null;
            a.visit = true;
            q.Enqueue(a);
            result += a.name+"->";
            while (q.Count != 0)
            {
                a = q.Dequeue();
                for (int i = 0; i < a.Edge.Count; i++)
                {
                    q.Enqueue(a.Edge[i].second);
                    if (!a.Edge[i].second.visit)
                    {
                        result += a.Edge[i].second.name + "->";
                    }
                    a.Edge[i].second.visit = true;
                }
            }
            result += "finish.";
            return result;
        }

        public void Obhod(GNode a)
        {
            if (a.visit != true)
            {
                a.visit = true;
                for (int i = 0; i < a.Edge.Count; i++)
                {
                    Obhod(a.Edge[i].second);
                }
            }
        }

        public int i;
        public GNode current = null;
        public int FindMinimalCycle()
        {
            i = -1;
            for (int i = 0; i < Nodes.Count; i++)
            {
                current = Nodes[i];
                FindMinimalCycle(Nodes[i], 0);
            }
            if (i == -1)
                throw new Exception("No cycles here");
            return i;
        }

        private void FindMinimalCycle(GNode a, int length)
        {
            a.visit = true;
            for (int k = 0; k < a.Edge.Count; k++)
            {
                if (a.Edge[k].second == current)
                {
                    length += a.Edge[k].weight;
                    if ((i == -1) || (length < i))
                        i = length;
                }
                else
                {
                    if (!a.Edge[k].second.visit)
                    {
                        FindMinimalCycle(a.Edge[k].second, length + a.Edge[k].weight);
                    }
                }
            }
            a.visit = false;
        }

        List<GNode> Used;          
        List<GNode> notUsed;      
        List<GEdge> notUsedE;      
        List<GEdge> orderedEdges;  
        public GNode weuse;        
        Random rnd;                
        public void FillLists()
        {
            rnd = new Random();
            Used = new List<GNode>();
            notUsed = new List<GNode>();
            notUsedE = new List<GEdge>();
            orderedEdges = new List<GEdge>();     
            weuse = new GNode(0, 0, null, null);  
            for (int i = 0; i < Nodes.Count; i++)
            {
                notUsed.Add(Nodes[i]);  
                for (int j = 0; j < Nodes[i].Edge.Count; j++)
                {
                    notUsedE.Add(Nodes[i].Edge[j]);
                    orderedEdges.Add(Nodes[i].Edge[j]);       
                }
            }

            GEdge helper;                                      
            for (int i=0;i< orderedEdges.Count;i++)
            {
                for (int j=0;j< orderedEdges.Count-i-1;j++)
                {
                    if (orderedEdges[j].weight > orderedEdges[j+1].weight)
                    {
                        helper = orderedEdges[j+1];
                        orderedEdges[j+1] = orderedEdges[j];              
                        orderedEdges[j] = helper;
                    }
                }
            }
        }

        public void PrimAlgorithm()
        {
            Used.Add(Nodes[rnd.Next(0, Nodes.Count)]);  
            notUsed.Remove(Used[0]);                   
            weuse = Used[0];
            while (notUsed.Count>0)                    
            {
                int minE = -1;
                for (int i = 0; i<notUsedE.Count; i++)
                {
                    if ((Used.IndexOf(notUsedE[i].first) != -1) && (notUsed.IndexOf(notUsedE[i].second) != -1)
                        || (Used.IndexOf(notUsedE[i].second) != -1) && (notUsed.IndexOf(notUsedE[i].first) != -1))
                    {
                        if (minE != -1)
                        {
                            if (notUsedE[i].weight < notUsedE[minE].weight)
                                minE = i;
                        }
                        else
                            minE = i;
                    }
                }
                if (Used.IndexOf(notUsedE[minE].first) != -1)
                {
                    Used.Add(notUsedE[minE].second);
                    notUsed.Remove(notUsedE[minE].second);
                }
                else
                {
                    Used.Add(notUsedE[minE].first);
                    notUsed.Remove(notUsedE[minE].first);
                }
                notUsedE[minE].inminostov = true;
                notUsedE.RemoveAt(minE);
            }
        }

        public void KruskalAlgorithm() 
        {
            int c = 1;
            for (int i=0;i<orderedEdges.Count;i++)
            {
                if (orderedEdges[i].first.componenta==0)
                {
                    orderedEdges[i].first.componenta = c;
                    c++;
                }
                if (orderedEdges[i].first.componenta!=orderedEdges[i].second.componenta)
                {
                    orderedEdges[i].inminostov = true;
                    orderedEdges[i].second.componenta = orderedEdges[i].first.componenta;
                }
            }
        }
    }
} 