using LB;
using System;
using System.Windows.Forms;

namespace FormQueue
{
    public partial class FormQueue : Form
    {
        MyQueue<string> queue = new MyQueue<string>();
        Utils u = new Utils();

        public FormQueue()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            foreach(string element in u.ReadFromFile(openFileDialog1.FileName))
            {
                tbShow.Text += element + " ";
                queue.Enqueue(element);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbShow.Text = "";
            tbElement.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tbShow.Text = "";
            string element = tbElement.Text;
            queue = queue.Solution(queue, element);
            foreach (string el in queue)
                tbShow.Text += el + " ";
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            u.WriteInFile(saveFileDialog1.FileName, queue);
        }
    }
}
