using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph
{
    public partial class InputForm : Form 
    {
        public InputForm(string text)
        {
            this.text = text;
            InitializeComponent();
        }

        string text;
        public string Str { get; set; }

        private void InputForm_Load(object sender, EventArgs e)
        {
            ValueText.Text = text;
            if (Str != null)
                Input.Text = Str;
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            Str = Input.Text;
        }
    }
}
