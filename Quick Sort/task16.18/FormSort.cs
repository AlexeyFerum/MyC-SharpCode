using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace task16._18
{
    public partial class task1618 : Form
    {
        public task1618()
        {
            InitializeComponent();
        }
        int[] arr;
       
        private void obzor_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() != DialogResult.OK)
                return;
            string f = ofd.FileName;
            arr = Read.Readme(f);
            Graphics g = panelka.CreateGraphics();
            Draw.startmas(arr, g);
        }

        private void random_Click(object sender, EventArgs e)
        {
            arr = Read.Rand();
            Graphics g = panelka.CreateGraphics();
            Draw.startmas(arr, g);
        }

        private void Sortmas_Click(object sender, EventArgs e)
        {
            Graphics g = panelka.CreateGraphics();
            int i = 0;
            int j = arr.Length - 1;
            Hoarasort.QuickSort(i, j, arr, g);

        }
    }
}


