namespace Graph
{
    partial class GraphForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Oper = new System.Windows.Forms.ComboBox();
            this.NodeOrEdge = new System.Windows.Forms.ComboBox();
            this.Image = new System.Windows.Forms.PictureBox();
            this.Search = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectedOutput = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GetN = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Image)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GetN)).BeginInit();
            this.SuspendLayout();
            // 
            // Oper
            // 
            this.Oper.DisplayMember = "0";
            this.Oper.FormattingEnabled = true;
            this.Oper.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.Oper.Items.AddRange(new object[] {
            "Add",
            "Delete",
            "Choose city"});
            this.Oper.Location = new System.Drawing.Point(12, 45);
            this.Oper.Name = "Oper";
            this.Oper.Size = new System.Drawing.Size(121, 21);
            this.Oper.TabIndex = 0;
            this.Oper.SelectedIndexChanged += new System.EventHandler(this.Add_SelectedIndexChanged);
            // 
            // NodeOrEdge
            // 
            this.NodeOrEdge.DisplayMember = "0";
            this.NodeOrEdge.FormattingEnabled = true;
            this.NodeOrEdge.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.NodeOrEdge.Items.AddRange(new object[] {
            "City",
            "Road"});
            this.NodeOrEdge.Location = new System.Drawing.Point(12, 72);
            this.NodeOrEdge.Name = "NodeOrEdge";
            this.NodeOrEdge.Size = new System.Drawing.Size(121, 21);
            this.NodeOrEdge.TabIndex = 1;
            this.NodeOrEdge.SelectedIndexChanged += new System.EventHandler(this.ND_SelectedIndexChanged);
            // 
            // Image
            // 
            this.Image.Location = new System.Drawing.Point(139, 45);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(912, 543);
            this.Image.TabIndex = 2;
            this.Image.TabStop = false;
            this.Image.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Image_MouseClick);
            // 
            // Search
            // 
            this.Search.Enabled = false;
            this.Search.Location = new System.Drawing.Point(12, 160);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(121, 28);
            this.Search.TabIndex = 5;
            this.Search.Text = "Find N-periphery";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "Граф (*.dat)|*.dat|Все файлы|*.*";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Граф (*.dat)|*.dat|Все файлы|*.*";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1063, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenBtn,
            this.SaveBtn});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.файлToolStripMenuItem.Text = "File";
            // 
            // OpenBtn
            // 
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(103, 22);
            this.OpenBtn.Text = "Open";
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(103, 22);
            this.SaveBtn.Text = "Save";
            this.SaveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Choose:";
            // 
            // SelectedOutput
            // 
            this.SelectedOutput.AutoSize = true;
            this.SelectedOutput.Location = new System.Drawing.Point(60, 107);
            this.SelectedOutput.Name = "SelectedOutput";
            this.SelectedOutput.Size = new System.Drawing.Size(10, 13);
            this.SelectedOutput.TabIndex = 8;
            this.SelectedOutput.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "N =";
            // 
            // GetN
            // 
            this.GetN.Location = new System.Drawing.Point(42, 134);
            this.GetN.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.GetN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.GetN.Name = "GetN";
            this.GetN.Size = new System.Drawing.Size(91, 20);
            this.GetN.TabIndex = 10;
            this.GetN.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // GraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 600);
            this.Controls.Add(this.GetN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SelectedOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Image);
            this.Controls.Add(this.NodeOrEdge);
            this.Controls.Add(this.Oper);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GraphForm";
            this.Text = "Graph";
            this.Load += new System.EventHandler(this.GraphForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Image)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GetN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Oper;
        private System.Windows.Forms.ComboBox NodeOrEdge;
        private System.Windows.Forms.PictureBox Image;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenBtn;
        private System.Windows.Forms.ToolStripMenuItem SaveBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SelectedOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown GetN;
    }
}

