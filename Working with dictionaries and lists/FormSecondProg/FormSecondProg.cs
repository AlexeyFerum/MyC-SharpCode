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
using LBSecond;

namespace FormSecondProg
{
    public partial class FormSecondProg : Form
    {
        string Text;
        List<string> Words = new List<string>();

        public FormSecondProg()
        {
            InitializeComponent();
        }

        private void buttonReadFromFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
                Text = MyFile.ReadFromFile(openFileDialog1.FileName);

            ReadTextBox.Text = Text.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResultTextBox.Clear();
            ReadTextBox.Clear();
        }
        private void buttonImplement_Click(object sender, EventArgs e)
        {
            Words = Main.toList(Text);
            Words = Sorting.ConsonantOrVowel(Words);

            foreach (string word in Words)
            {
                ResultTextBox.Text += word + "\r\n";
            }
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
            MyFile.WriteInFile(saveFileDialog1.FileName, Words);
        }
    }
}
