using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BL;

namespace _17_4
{
    public partial class ExpessionForm : Form
    {
        Parser parser;
        Graphics g;
        bool drawing = false;

        public ExpessionForm()
        {
            InitializeComponent();
            drawSpace.Width = this.Width;
            drawSpace.Height = this.Height;
            g = drawSpace.CreateGraphics();
            parser = new Parser(drawSpace.Width, drawSpace.Height);
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            try
            {
                string s = tb_input.Text;
                parser.Parse(ref s);
                lbl_result.Text = "= " + parser.Result();
                Draw();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                parser.Clear();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_input.Clear();
            lbl_result.Text = "= ?";
            g.Clear(Color.White);
            parser.Clear();
        }
        
        public void Draw()
        {
            if (parser != null)
            {
                parser.Draw(drawSpace.Width, drawSpace.Height);
                if (parser.bitmap != null)
                    g.DrawImage(parser.bitmap, 0, 0);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Draw();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (parser != null)
                drawing = parser.FindCoordinates(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (parser != null)
                if (drawing)
                    parser.Shift(e.X, e.Y);
                else
                {
                    parser.DeSelect();
                    if (parser.FindCoordinates(e.X, e.Y))
                        parser.RecolorSelected();
                }
            Draw();
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;
        }

        private void ExpressionForm_SizeChanged(object sender, EventArgs e)
        {
            if (parser != null)
            {
                parser.bitmap = new Bitmap(drawSpace.Width, drawSpace.Height);
                g = drawSpace.CreateGraphics();
                Draw();
            }
        }
    }
}
