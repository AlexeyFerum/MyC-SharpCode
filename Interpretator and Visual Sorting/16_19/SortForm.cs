using System;
using System.Drawing;
using System.Windows.Forms;
using BL;

namespace _16_19
{
    public partial class SortForm : Form
    {
        Graphics gForm;
        int[] array = new int[10];
        int[] backup = new int[10];
        Animation animation = null;

        public SortForm()
        {
            InitializeComponent();
            for (int i = 0; i < array.Length; i++)
                array[i] = i + 1;
        }
        
        private void btn_NewArray_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
                timer1.Stop();
            animation = null;
            using (gForm = pictureBox1.CreateGraphics())
            {
                gForm.Clear(Color.White);
                SortVisualisation.Shuffle(array);
                for (int i = 0; i < array.Length; i++)
                    backup[i] = array[i];
                SortVisualisation.DrawArray(gForm, array);
            }
        }
        
        private void btn_Again_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
                timer1.Stop();
            animation = null;
            using (gForm = pictureBox1.CreateGraphics())
            {
                gForm.Clear(Color.White);
                for (int i = 0; i < array.Length; i++)
                    array[i] = backup[i];
                SortVisualisation.DrawArray(gForm, array);
            }
        }

        private void btn_Launch_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled && animation != null)
                timer1.Start();
        }
        
        private void btn_Stop_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
                timer1.Stop();
        }
        
        private void btn_Sort_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled && animation == null)
            {
                animation = new Animation(pictureBox1.Width, pictureBox1.Height);
                if (rb_Bubble.Checked)
                {
                    SortVisualisation.Bubble(array, animation);
                    timer1.Start();
                }
                if (rb_Shaker.Checked)
                {
                    SortVisualisation.Shaker(array, animation);
                    timer1.Start();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            using (gForm = pictureBox1.CreateGraphics())
                if (!animation.DrawFrame(gForm))
                {
                    timer1.Stop();
                    animation.Dispose();
                }
        }
    }
}