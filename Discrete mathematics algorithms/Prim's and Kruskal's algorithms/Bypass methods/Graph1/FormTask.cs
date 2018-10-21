using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Graph1
{
    public partial class FormGraph : Form
    {
        public FormGraph()
        {
            InitializeComponent();
           
        }
        Graph a = new Graph();
        Exception ex = new Exception();
        Random rnd = new Random();

        private void buttonFormAddNode_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            try
            {
                a.AddNode(textBoxNodeName.Text, textBoxNodeInformation.Text, rnd.Next(0+20, panel1.Width-20), rnd.Next(0+20, panel1.Height-20)); // 20x20 - one Node Size
                panel1.Invalidate();
                textBoxNodeName.Text = (Convert.ToInt32(textBoxNodeName.Text) + 1).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void buttonFormAddEdge_Click(object sender, EventArgs e)
        {
            try
            {
                a.AddEdge(a.GetNodeIndexByName(textBoxFrom.Text), a.GetNodeIndexByName(textBoxIn.Text), Convert.ToInt32(textBoxWeight.Text));
                textBoxWeight.Text = (Convert.ToInt32(textBoxWeight.Text) + rnd.Next(0, 5)).ToString();
                textBoxFrom.Text = (Convert.ToInt32(textBoxFrom.Text) + 1).ToString();
                textBoxIn.Text = (Convert.ToInt32(textBoxIn.Text) + 1).ToString();
                panel1.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }

        }

        Point last = new Point();
        Point current = new Point();

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (radioButton1.Checked)
                {
                    a.AddNode(textBoxNodeName.Text, textBoxNodeInformation.Text, e.X, e.Y);
                    textBoxNodeName.Text = (Convert.ToInt32(textBoxNodeName.Text) + 1).ToString();
                }
                if (radioButton2.Checked)
                {
                    a.AddEdgeClick(radioButton7.Checked, e.X, e.Y, Convert.ToInt32(textBoxWeight.Text));
                    textBoxWeight.Text = (Convert.ToInt32(textBoxWeight.Text) + rnd.Next(0, 1)).ToString();
                    last = e.Location;
                }
                if (radioButton3.Checked)
                {
                    a.NodeMoveByXY(e.X, e.Y);
                }
                if (radioButton4.Checked)
                {
                    a.NodeDeleteByXY(e.X, e.Y);
                }
                if (radioButton5.Checked)
                {
                    a.NodeExchange(e.X,e.Y);
                }
                if (radioButton6.Checked)
                {
                    a.EdgeDelete(e.X, e.Y);
                }
                
                panel1.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            if (!(last.IsEmpty || current.IsEmpty))
                e.Graphics.DrawLine(Pens.Black, last, current);
            a.Draw(e.Graphics,radioButton10.Checked);
        }

        private void saveGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sfd1.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                a.SaveFile(sfd1.FileName, a);
                MessageBox.Show("Graph successfully saved.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem with Graph saving :" + ex.Message);
            }
            panel1.Invalidate();
        }

        private void openGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofd1.ShowDialog() != DialogResult.OK)
                return;
                a = a.OpenFile(ofd1.FileName);
                panel1.Invalidate();
                MessageBox.Show("Graph successfully opened.");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            a = new Graph();
            textBoxNodeName.Text = 1.ToString();
            textBoxNodeInformation.Text = "value";
            textBoxFrom.Text = 1.ToString();
            textBoxIn.Text = 2.ToString();
            panel1.Invalidate();
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            a.CleanSelected();
            panel1.Invalidate();
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void buttonInDepth_Click(object sender, EventArgs e)
        {
            a.Visiter();
            a.Reseter();
            listBoxResult.Items.Clear();
            if (radioButtonInDepth.Checked)
            {
                a.ObhodInDepth(a.Nodes[0]);
                listBoxResult.Items.AddRange(a.ReturnWaysResult());
            }
            else
            {
                MessageBox.Show(a.ObhodInBreadth(a.Nodes[0]));
            }
            panel1.Invalidate();
        }

        private void buttonCleanGraph_Click(object sender, EventArgs e)
        {
            a.Visiter();
            a.Reseter();
            panel1.Invalidate();
            listBoxResult.Items.Clear();
        }

        private void buttonPrimAlgorithm_Click(object sender, EventArgs e)
        {
            a.FillLists();
            a.PrimAlgorithm();
            panel1.Invalidate();
            MessageBox.Show("Started searching from the node with the number " + a.weuse.name);
        }

        private void buttonKruskulAlgorithm_Click(object sender, EventArgs e)
        {
            a.FillLists();
            a.KruskalAlgorithm();
            panel1.Invalidate();
        }

        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
            a = new Graph();
            listBoxResult.Text = "";
            panel1.Invalidate();
        }
    }
}