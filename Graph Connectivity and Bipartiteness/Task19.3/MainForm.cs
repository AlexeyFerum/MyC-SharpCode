using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GraphLibrary;

namespace Task19._3
{
    public partial class MainForm : Form
    {
        GraphEditor graphEditor;
        enum Mode { AddMoveNode, AddEdge, RemoveEdge, None };
        Mode currentMode;
        Color lastColor;
        int? lastVisited;
        int? lastClicked;
        int? dragged;

        public MainForm()
        {
            InitializeComponent();
            graphEditor = new GraphEditor();
            currentMode = Mode.AddMoveNode;
            DoubleBuffered = true;
            lastVisited = null;
            lastClicked = null;
            dragged = null;
        }

        private void drawingArea_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            graphEditor.Draw(e.Graphics, e.ClipRectangle);
        }

        private void drawingArea_MouseClick(object sender, MouseEventArgs e)
        {
            PointF dot = new PointF(e.Location.X, e.Location.Y);
            dot = graphEditor.TranslateToLocal(dot, drawingArea.DisplayRectangle);
            int? id = graphEditor.TryGetNode(dot, drawingArea.ClientRectangle);

            switch (currentMode)
            {
                case Mode.AddMoveNode:
                    if (id != null)
                        return;
                    graphEditor.AddNode(dot.X, dot.Y);
                    drawingArea.Invalidate();
                    break;

                case Mode.AddEdge:
                    if (id == null)
                        return;
                    if (lastClicked != null)
                    {
                        graphEditor.AddEdge((int)lastClicked, (int)id, (int)weightNumeric.Value);
                        graphEditor.AddEdge((int)id, (int)lastClicked, (int)weightNumeric.Value);
                        graphEditor.ChangeNodeColor((int)lastClicked, Color.White);
                        lastClicked = null;
                        drawingArea.Invalidate();
                        return;
                    }
                    graphEditor.ChangeNodeColor((int)id, Color.Yellow);
                    lastClicked = id;
                    drawingArea.Invalidate();
                    break;

                case Mode.RemoveEdge:
                    if (id == null)
                        return;
                    if (lastClicked == null)
                    {
                        lastClicked = id;
                        graphEditor.ChangeNodeColor((int)id, Color.Red);
                        drawingArea.Invalidate();
                        return;
                    }
                    graphEditor.RemoveEdge((int)lastClicked, (int)id);
                    graphEditor.ChangeNodeColor((int)lastClicked, Color.White);
                    lastClicked = null;
                    drawingArea.Invalidate();
                    break;
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            drawingArea.Invalidate();
        }

        private void drawingArea_MouseMove(object sender, MouseEventArgs e)
        {
            PointF dot = new PointF(e.Location.X,
                                    e.Location.Y);
            dot = graphEditor.TranslateToLocal(dot, drawingArea.DisplayRectangle);
            if (dragged != null)
            {
                graphEditor.MoveNode((int)dragged, dot.X, dot.Y);
                drawingArea.Invalidate();
                return;
            }

            int? id;
            if ((id = graphEditor.TryGetNode(dot, drawingArea.ClientRectangle)) != null)
            {
                if ((graphEditor.CurrGraph.Nodes[(int)id] as DrawableGraphNode).FillingColor != Color.Blue)
                {
                    lastVisited = id;
                    lastColor = (graphEditor.CurrGraph.Nodes[(int)id] as DrawableGraphNode).FillingColor;
                    if (lastColor != Color.Yellow && lastColor != Color.Red)
                    {
                        graphEditor.ChangeNodeColor((int)id, Color.Blue);
                        drawingArea.Invalidate();
                    }
                    return;
                }
            }
            else
            {
                if (lastVisited != null)
                {
                    graphEditor.ChangeNodeColor((int)lastVisited, lastColor);
                    lastVisited = null;
                    drawingArea.Invalidate();
                }
            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            var button = sender as RadioButton;
            if (button.Checked)
            {
                switch (button.Name)
                {
                    case "addMoveNodeButton":
                        dragged = null;
                        currentMode = Mode.AddMoveNode;
                        break;
                    case "addEdgeButton":
                        lastClicked = null;
                        currentMode = Mode.AddEdge;
                        break;
                    case "removeEdgeButton":
                        lastClicked = null;
                        currentMode = Mode.RemoveEdge;
                        break;
                }
            }
        }

        private void drawingArea_MouseDown(object sender, MouseEventArgs e)
        {
            if (currentMode != Mode.AddMoveNode)
                return; 
            PointF dot = new PointF(e.Location.X,
                                   e.Location.Y);
            dot = graphEditor.TranslateToLocal(dot, drawingArea.DisplayRectangle);
            int? id = graphEditor.TryGetNode(dot, drawingArea.ClientRectangle);
            if (id == null)
                return;
            dragged = id;
            graphEditor.ChangeNodeColor((int)id, Color.Green);
        }

        private void drawingArea_MouseUp(object sender, MouseEventArgs e)
        {
            if (dragged != null)
            {
                graphEditor.ChangeNodeColor((int)dragged, Color.White);
                dragged = null;
            }
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            bool isConnected = graphEditor.CurrGraph.CheckConnectivity();
            if (isConnected)
                MessageBox.Show("Graph is connected");
            else
                MessageBox.Show("Graph is not connected");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            lastClicked = null;
            lastVisited = null;
            graphEditor.CurrGraph = new Graph();
            drawingArea.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isBipartite = graphEditor.CurrGraph.CheckBipartiteness();
            if (isBipartite)
                MessageBox.Show("Graph is bipartite");
            else
                MessageBox.Show("Graph is not bipartite");
        }
    }
}
