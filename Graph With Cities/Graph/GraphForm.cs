using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Drawing;
using MyGraph;
namespace Graph
{
    public partial class GraphForm : Form
    {
        public GraphForm()
        {
            InitializeComponent();
        }

        GraphDraw GraphDraw;
        CityGraph graph;

        private void GraphForm_Load(object sender, EventArgs e)
        {
            graph = new CityGraph();
            GraphDraw = new GraphDraw(Image.Size, graph);
            Oper.SelectedIndex = 0;
            NodeOrEdge.SelectedIndex = 0;
        }

        private void UpdateImage() 
        {
            Image.Image = GraphDraw.Draw();
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileWork file = new FileWork(openFileDialog.FileName);
                    graph = file.Read();
                    GraphDraw.graph = graph;
                    UpdateImage();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileWork file = new FileWork(saveFileDialog.FileName);
                    file.Write(graph);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error");
                }
            }
        }

        Node Selected = null;
        Node Temp = null;

        private void Image_MouseClick(object sender, MouseEventArgs e)
        {
            if(Oper.SelectedIndex == 2)
            {
                Selected = GraphDraw.GetNode(e.X, e.Y);
                SelectedOutput.Text = Selected.Name;
                Search.Enabled = true;
            }
            else if(NodeOrEdge.SelectedIndex == 0)
            {
                if(Oper.SelectedIndex == 0 )
                {
                    if(GraphDraw.Empty(e.X,e.Y))
                    {
                        InputForm input = new InputForm("Name"); 
                        if (input.ShowDialog() == DialogResult.OK)
                        {
                            if (!string.IsNullOrWhiteSpace(input.Str))
                            {
                                graph.AddNode(input.Str, e.X, e.Y);
                                UpdateImage();
                            }
                            else MessageBox.Show("Wrong input");
                        }
                    }
                }
                else 
                {
                    Temp = GraphDraw.GetNode(e.X, e.Y);
                    if(Selected == Temp)
                    {
                        Selected = null;
                        SelectedOutput.Text = "";
                        Search.Enabled = false;
                    }
                    graph.Remove(Temp);
                    UpdateImage();
                    Temp = null;
                }
            }
            else 
            {
                if(Temp == null)
                    Temp = GraphDraw.GetNode(e.X, e.Y);
                else
                {
                    Node SS = GraphDraw.GetNode(e.X, e.Y);
                    if (SS != null)
                    {
                        if (Oper.SelectedIndex == 0)
                        {
                            InputForm input = new InputForm("Length");
                            if (input.ShowDialog() == DialogResult.OK)
                            {
                                if (!string.IsNullOrWhiteSpace(input.Str) && int.TryParse(input.Str, out int result))
                                {
                                    Temp.AddEdge(SS, result);
                                    UpdateImage();
                                }
                                else MessageBox.Show("Wrong Input");
                            }
                        }
                        else
                        {
                            Temp.RemoveEdge(SS);
                            UpdateImage();
                        }

                    }
                    Temp = null;
                }
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                if(Selected!= null)
                {
                    List<Node> Dist = graph.GetNodeWithDistMoreN(Selected, (int)GetN.Value);
                    if(Dist.Count != 0)
                    MessageBox.Show(string.Join(" ",Dist));
                    else
                        MessageBox.Show("The specified N-periphery is missing");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void Add_SelectedIndexChanged(object sender, EventArgs e) => Temp = null;

        private void ND_SelectedIndexChanged(object sender, EventArgs e) => Temp = null;
    }
}
