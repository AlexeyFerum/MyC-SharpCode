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
        private List<GNode> Nodes = new List<GNode>(); 

        private int r = 10; 
        private GNode selected = null; 
         
        private int way = 0;
        private int summ = 0;
        private int helper = 0;
        
        [Serializable]
        public class GNode           
        {
            public int x;
            public int y;
            public string inf;   
            public string name;  
            public List<GEdge> Edge = new List<GEdge>(); 
            public bool visit = false;   

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

        public string ReturnNodesString()  
        {
            string result = null;
            for (int i = 0; i < Nodes.Count; i++)
                result += Nodes[i].name + " ";
            return result;
        }

        public string ReturnEdgesString()  
        {
            string result = null;
            for (int i = 0; i < Nodes.Count; i++)
                for (int j = 0; j < Nodes[i].Edge.Count; j++)
                    result += "(" + Nodes[i].Edge[j].first.name.ToString() + ":" + Nodes[i].Edge[j].second.name.ToString() + ")[" + Nodes[i].Edge[j].weight.ToString() + "]";
            return result;
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
                for (int j=0;j<Nodes[i].Edge.Count;j++)
                {
                    if (Nodes[i].Edge[j].first == Nodes[i].Edge[j].second)
                        {
                        g.DrawEllipse(Pens.Black, Nodes[i].x, Nodes[i].y, 30, 30); 
                        }
                    g.DrawLine(Pens.Black, Nodes[i].Edge[j].first.x, Nodes[i].Edge[j].first.y, Nodes[i].Edge[j].second.x, Nodes[i].Edge[j].second.y);
                    g.DrawString(Nodes[i].Edge[j].weight.ToString(), b, Brushes.Black, (Nodes[i].Edge[j].first.x + Nodes[i].Edge[j].second.x) / 2, (Nodes[i].Edge[j].first.y + Nodes[i].Edge[j].second.y) / 2);
                }

            }
            for (int i=0;i<Nodes.Count;i++)
            {
                var p = GetXYByIndex(i);
                if (!isEllipse) 
                {
                    g.FillRectangle(((Nodes[i] == selected)||(Nodes[i].visit)) ? Brushes.Black : Brushes.IndianRed, p.X - r, p.Y - r, 2 * r, 2 * r);
                    g.DrawRectangle(Pens.Black, p.X - r, p.Y - r, 2 * r, 2 * r);
                }
                else  
                {
                    g.FillEllipse((Nodes[i] == selected) ? Brushes.Black : Brushes.IndianRed, p.X - r, p.Y - r, 2 * r, 2 * r);
                    g.DrawEllipse(Pens.Black, p.X - r, p.Y - r, 2 * r, 2 * r);

                }
                g.DrawString(Nodes[i].name, a, Brushes.Beige, p.X-r, p.Y-r);
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
                if ((x - r <= Nodes[i].x) && (Nodes[i].x <= x + r) && (y-r<=Nodes[i].y) && (Nodes[i].y <= y + r))
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

        public void GetWay(int way)
        {
            this.way = way;
        }

        public void FindWay()
        {
            helper = 0;
            summ = 0;
            Visiter();
            FindWay(Nodes[0]);
            
        }
        private void FindWay(GNode b)
        {
            if (summ >= way)
                throw new Exception("Way more than N.");
            if ((b.visit ==true ) && (b == Nodes[0]))
                throw new Exception("Cycle here.");
            else
            {
                b.visit = true;
                helper++;
                for (int i = 0; i < b.Edge.Count; i++)
                {
                    summ += b.Edge[i].weight;
                    if (b.Edge[i].second == Nodes[0])
                    {
                        FindWay(b.Edge[i].second);
                    }
                    else
                    {
                        if (!b.Edge[i].second.visit)
                        {
                            FindWay(b.Edge[i].second);
                        }
                    }
                }
                if (helper == Nodes.Count)
                    throw new Exception("All Nodes visited, no cycle here.");
            }
        }

        public bool isConnected()
        {
            Visiter();    
            bool answer = true;
            for (int o = 0; o < Nodes.Count; o++)
            {
                Obhod(Nodes[o]);   
                for (int j = 0; j < Nodes.Count; j++)
                {
                    if (!Nodes[j].visit)  
                    {
                        answer = false;
                        break;
                    }
                }
                Visiter();
            }
            return answer;
        }
        public void Visiter()  
        {
            for (int i=0;i<Nodes.Count;i++)
            {
                Nodes[i].visit = false;
            }

        }
        private void Obhod(GNode a)   
        {
            if ((a.visit != true))
            {
                a.visit = true;
                for (int i = 0; i < a.Edge.Count; i++)
                {
                    Obhod(a.Edge[i].second);
                }
            }
        }
    }
}