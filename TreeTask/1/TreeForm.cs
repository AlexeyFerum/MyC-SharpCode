using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Draw;
using Tools;

namespace _1
{
    public partial class TreeForm : Form
    {
        Tree tree;
        TreeDraw draw;
        Node SelectedNode;

        public TreeForm()
        {
            InitializeComponent();
        }

        private void TreeForm_Load(object sender, EventArgs e)
        {
            tree = new Tree();
            draw = new TreeDraw(Output.Size, tree);
            UpdateImage();
        }

        private void UpdateImage()
        {
            Output.Image = draw.Draw();
        }
        
        private void Output_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                SelectedNode = draw.GetNode(e.X, e.Y);

                if (SelectedNode != null)
                {
                    RemoveBtn.Enabled = !(SelectedNode == tree.Root);
                    AddBtn.Enabled = SelectedNode.Nodes.Count < 2;
                    contextMenuStrip.Show((Control) sender, e.Location);
                }
            }
        }

        private void AddBtn_Click(object sender, EventArgs e) 
        {
            NodeForm node = new NodeForm();
            node.Value = 0;

            try
            {
                if (node.ShowDialog() == DialogResult.OK)
                {
                    SelectedNode.Add(node.Value);
                    UpdateImage();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            SelectedNode.Parent.Nodes.Remove(SelectedNode);
            UpdateImage();
        }

        private void open_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    tree = FileTree.OpenTree(openFileDialog.FileName);
                    draw.tree = tree;
                    UpdateImage();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileTree.SaveTree(saveFileDialog.FileName,tree);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error");
                }
            }
        }
        

        private void SearchTreeBtn_Click(object sender, EventArgs e)
        {
            if (tree.TreeSearch())
            {
                MessageBox.Show("Is a binary search tree");
            }
            else
                MessageBox.Show("Isn't a binary search tree");
        }
    }
}