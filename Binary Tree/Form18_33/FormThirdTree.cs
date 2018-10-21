using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LB;

namespace Form18_33
{
    public partial class FormThirdTree : Form
    {
        BinaryTree tree;
        string[] a, b;

        public FormThirdTree()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            textBoxA.Text = "";
            textBoxB.Text = "";
            textBoxC.Text = "";
        }

        private void labelC_Click(object sender, EventArgs e)
        {

        }

        private void labelB_Click(object sender, EventArgs e)
        {

        }

        private void labelA_Click(object sender, EventArgs e)
        {

        }

        private void buttonOpenB_Click(object sender, EventArgs e)
        {
            if (ofdB.ShowDialog() != DialogResult.OK) return;
            b = forBinaryTree.ReadFromFile(ofdB.FileName);

            for (int i = 0; i < b.Length; i++)
            {
                textBoxB.Text += b[i] + "\r\n";
            }

            tree = new BinaryTree();
            for (int i = 0; i < textBoxB.Lines.Length; i++)
            {
                tree.AddElement(textBoxB.Lines[i]);
            }
        }

        private void buttonImplement_Click(object sender, EventArgs e)
        {
            textBoxC.Text = "";
            if (tree == null) return;

            List<string> a = new List<string>();
            for (int i = 0; i < textBoxA.Lines.Length; i++)
            {
                a.Add(textBoxA.Lines[i]);
            }

            List<string> C = new List<string>();
            foreach (string el in a)
            {
                if (!tree.Contains(el))
                    C.Add(el);
            }

            for (int i = 0; i < C.Count; i++)
            {
                textBoxC.AppendText(C[i] + "\r\n");
            }
        }
        
        private void buttonOpenA_Click(object sender, EventArgs e)
        {
            if (ofdA.ShowDialog() != DialogResult.OK) return;
            a = forBinaryTree.ReadFromFile(ofdA.FileName);

            for (int i = 0; i < a.Length; i++) 
            {
                textBoxA.Text += a[i] + "\r\n";
            }
        }

        private void saveCButton_Click(object sender, EventArgs e)
        {
            if (sfdC.ShowDialog() != DialogResult.OK) return;
            var safname = sfdC.FileName;

            FileStream Fs = new FileStream(safname, FileMode.Open);
            StreamWriter sw = new StreamWriter(Fs);
            
            sw.WriteLine(textBoxC.Text);

            sw.Close();
            Fs.Close();
        }
    }
}