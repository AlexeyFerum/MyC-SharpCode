namespace Graph1
{
    partial class FormGraph
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonFormAddNode = new System.Windows.Forms.Button();
            this.buttonFormAddEdge = new System.Windows.Forms.Button();
            this.textBoxNodeName = new System.Windows.Forms.TextBox();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.textBoxIn = new System.Windows.Forms.TextBox();
            this.labelInformation = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelIn = new System.Windows.Forms.Label();
            this.textBoxNodeInformation = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonPrimAlgorithm = new System.Windows.Forms.Button();
            this.buttonKruskalAlgorithm = new System.Windows.Forms.Button();
            this.buttonCleanGraph = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButtonInBreadth = new System.Windows.Forms.RadioButton();
            this.radioButtonInDepth = new System.Windows.Forms.RadioButton();
            this.buttonInDepth = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.labelWeight = new System.Windows.Forms.Label();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.sfd1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.buttonDelete = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1902, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveGraphToolStripMenuItem,
            this.openGraphToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(144, 29);
            this.toolStripMenuItem1.Text = "Action with File";
            // 
            // saveGraphToolStripMenuItem
            // 
            this.saveGraphToolStripMenuItem.Name = "saveGraphToolStripMenuItem";
            this.saveGraphToolStripMenuItem.Size = new System.Drawing.Size(192, 30);
            this.saveGraphToolStripMenuItem.Text = "Save graph";
            this.saveGraphToolStripMenuItem.Click += new System.EventHandler(this.saveGraphToolStripMenuItem_Click);
            // 
            // openGraphToolStripMenuItem
            // 
            this.openGraphToolStripMenuItem.Name = "openGraphToolStripMenuItem";
            this.openGraphToolStripMenuItem.Size = new System.Drawing.Size(192, 30);
            this.openGraphToolStripMenuItem.Text = "Open graph";
            this.openGraphToolStripMenuItem.Click += new System.EventHandler(this.openGraphToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(51, 29);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // buttonFormAddNode
            // 
            this.buttonFormAddNode.Location = new System.Drawing.Point(14, 110);
            this.buttonFormAddNode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonFormAddNode.Name = "buttonFormAddNode";
            this.buttonFormAddNode.Size = new System.Drawing.Size(188, 35);
            this.buttonFormAddNode.TabIndex = 2;
            this.buttonFormAddNode.Text = "Add Node";
            this.buttonFormAddNode.UseVisualStyleBackColor = true;
            this.buttonFormAddNode.Click += new System.EventHandler(this.buttonFormAddNode_Click);
            // 
            // buttonFormAddEdge
            // 
            this.buttonFormAddEdge.Location = new System.Drawing.Point(210, 110);
            this.buttonFormAddEdge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonFormAddEdge.Name = "buttonFormAddEdge";
            this.buttonFormAddEdge.Size = new System.Drawing.Size(198, 35);
            this.buttonFormAddEdge.TabIndex = 3;
            this.buttonFormAddEdge.Text = "Add Edge";
            this.buttonFormAddEdge.UseVisualStyleBackColor = true;
            this.buttonFormAddEdge.Click += new System.EventHandler(this.buttonFormAddEdge_Click);
            // 
            // textBoxNodeName
            // 
            this.textBoxNodeName.Location = new System.Drawing.Point(9, 74);
            this.textBoxNodeName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNodeName.Name = "textBoxNodeName";
            this.textBoxNodeName.Size = new System.Drawing.Size(97, 26);
            this.textBoxNodeName.TabIndex = 5;
            this.textBoxNodeName.Text = "1";
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Location = new System.Drawing.Point(201, 74);
            this.textBoxFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(72, 26);
            this.textBoxFrom.TabIndex = 6;
            this.textBoxFrom.Text = "1";
            // 
            // textBoxIn
            // 
            this.textBoxIn.Location = new System.Drawing.Point(282, 74);
            this.textBoxIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxIn.Name = "textBoxIn";
            this.textBoxIn.Size = new System.Drawing.Size(61, 26);
            this.textBoxIn.TabIndex = 8;
            this.textBoxIn.Text = "2";
            // 
            // labelInformation
            // 
            this.labelInformation.AutoSize = true;
            this.labelInformation.Location = new System.Drawing.Point(111, 50);
            this.labelInformation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(98, 20);
            this.labelInformation.TabIndex = 11;
            this.labelInformation.Text = "Information :\r\n";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(217, 50);
            this.labelFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(54, 20);
            this.labelFrom.TabIndex = 12;
            this.labelFrom.Text = "From :";
            // 
            // labelIn
            // 
            this.labelIn.AutoSize = true;
            this.labelIn.Location = new System.Drawing.Point(281, 48);
            this.labelIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIn.Name = "labelIn";
            this.labelIn.Size = new System.Drawing.Size(31, 20);
            this.labelIn.TabIndex = 13;
            this.labelIn.Text = "In :";
            // 
            // textBoxNodeInformation
            // 
            this.textBoxNodeInformation.Location = new System.Drawing.Point(114, 73);
            this.textBoxNodeInformation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNodeInformation.Name = "textBoxNodeInformation";
            this.textBoxNodeInformation.Size = new System.Drawing.Size(73, 26);
            this.textBoxNodeInformation.TabIndex = 14;
            this.textBoxNodeInformation.Text = "value";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(21, 50);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(59, 20);
            this.labelName.TabIndex = 15;
            this.labelName.Text = "Name :";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonPrimAlgorithm);
            this.panel1.Controls.Add(this.buttonKruskalAlgorithm);
            this.panel1.Controls.Add(this.buttonCleanGraph);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.buttonInDepth);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Location = new System.Drawing.Point(15, 155);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1526, 899);
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // buttonPrimAlgorithm
            // 
            this.buttonPrimAlgorithm.Location = new System.Drawing.Point(1136, 282);
            this.buttonPrimAlgorithm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPrimAlgorithm.Name = "buttonPrimAlgorithm";
            this.buttonPrimAlgorithm.Size = new System.Drawing.Size(376, 62);
            this.buttonPrimAlgorithm.TabIndex = 26;
            this.buttonPrimAlgorithm.Text = "Prim Algorithm";
            this.buttonPrimAlgorithm.UseVisualStyleBackColor = true;
            this.buttonPrimAlgorithm.Click += new System.EventHandler(this.buttonPrimAlgorithm_Click);
            // 
            // buttonKruskalAlgorithm
            // 
            this.buttonKruskalAlgorithm.Location = new System.Drawing.Point(1136, 352);
            this.buttonKruskalAlgorithm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonKruskalAlgorithm.Name = "buttonKruskalAlgorithm";
            this.buttonKruskalAlgorithm.Size = new System.Drawing.Size(376, 60);
            this.buttonKruskalAlgorithm.TabIndex = 27;
            this.buttonKruskalAlgorithm.Text = "Kruskal Algorithm";
            this.buttonKruskalAlgorithm.UseVisualStyleBackColor = true;
            this.buttonKruskalAlgorithm.Click += new System.EventHandler(this.buttonKruskulAlgorithm_Click);
            // 
            // buttonCleanGraph
            // 
            this.buttonCleanGraph.Location = new System.Drawing.Point(1136, 220);
            this.buttonCleanGraph.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCleanGraph.Name = "buttonCleanGraph";
            this.buttonCleanGraph.Size = new System.Drawing.Size(376, 52);
            this.buttonCleanGraph.TabIndex = 27;
            this.buttonCleanGraph.Text = "Clean\r\n";
            this.buttonCleanGraph.UseVisualStyleBackColor = true;
            this.buttonCleanGraph.Click += new System.EventHandler(this.buttonCleanGraph_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButtonInBreadth);
            this.groupBox4.Controls.Add(this.radioButtonInDepth);
            this.groupBox4.Location = new System.Drawing.Point(1136, 17);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(376, 69);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            // 
            // radioButtonInBreadth
            // 
            this.radioButtonInBreadth.AutoSize = true;
            this.radioButtonInBreadth.Location = new System.Drawing.Point(202, 25);
            this.radioButtonInBreadth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonInBreadth.Name = "radioButtonInBreadth";
            this.radioButtonInBreadth.Size = new System.Drawing.Size(109, 24);
            this.radioButtonInBreadth.TabIndex = 1;
            this.radioButtonInBreadth.Text = "In Breadth";
            this.radioButtonInBreadth.UseVisualStyleBackColor = true;
            // 
            // radioButtonInDepth
            // 
            this.radioButtonInDepth.AutoSize = true;
            this.radioButtonInDepth.Checked = true;
            this.radioButtonInDepth.Location = new System.Drawing.Point(26, 25);
            this.radioButtonInDepth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonInDepth.Name = "radioButtonInDepth";
            this.radioButtonInDepth.Size = new System.Drawing.Size(96, 24);
            this.radioButtonInDepth.TabIndex = 0;
            this.radioButtonInDepth.TabStop = true;
            this.radioButtonInDepth.Text = "In Depth";
            this.radioButtonInDepth.UseVisualStyleBackColor = true;
            // 
            // buttonInDepth
            // 
            this.buttonInDepth.Location = new System.Drawing.Point(1136, 95);
            this.buttonInDepth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonInDepth.Name = "buttonInDepth";
            this.buttonInDepth.Size = new System.Drawing.Size(376, 115);
            this.buttonInDepth.TabIndex = 26;
            this.buttonInDepth.Text = "Go through the nodes of the graph";
            this.buttonInDepth.UseVisualStyleBackColor = true;
            this.buttonInDepth.Click += new System.EventHandler(this.buttonInDepth_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton9);
            this.groupBox3.Controls.Add(this.radioButton10);
            this.groupBox3.Location = new System.Drawing.Point(3, -2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(237, 52);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(6, 18);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(115, 24);
            this.radioButton9.TabIndex = 20;
            this.radioButton9.Text = "Rectangles";
            this.radioButton9.UseVisualStyleBackColor = true;
            this.radioButton9.CheckedChanged += new System.EventHandler(this.radioButton9_CheckedChanged);
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Checked = true;
            this.radioButton10.Location = new System.Drawing.Point(126, 18);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(88, 24);
            this.radioButton10.TabIndex = 20;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "Ellipses";
            this.radioButton10.UseVisualStyleBackColor = true;
            this.radioButton10.CheckedChanged += new System.EventHandler(this.radioButton10_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(795, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(816, 49);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(678, 17);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(123, 24);
            this.radioButton6.TabIndex = 20;
            this.radioButton6.Text = "Delete Edge";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(549, 17);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(123, 24);
            this.radioButton4.TabIndex = 19;
            this.radioButton4.Text = "Delete Node";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(357, 17);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(190, 24);
            this.radioButton5.TabIndex = 20;
            this.radioButton5.Text = "Exchange Information";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(237, 17);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(114, 24);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Move Node";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(128, 17);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(105, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Add Edge";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(16, 17);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(105, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Add Node";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(353, 74);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(46, 26);
            this.textBoxWeight.TabIndex = 17;
            this.textBoxWeight.Text = "2";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(345, 48);
            this.labelWeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(67, 20);
            this.labelWeight.TabIndex = 18;
            this.labelWeight.Text = "Weight :";
            // 
            // ofd1
            // 
            this.ofd1.FileName = "openFileDialog1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton8);
            this.groupBox2.Controls.Add(this.radioButton7);
            this.groupBox2.Location = new System.Drawing.Point(434, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 46);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(26, 17);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(154, 24);
            this.radioButton8.TabIndex = 20;
            this.radioButton8.Text = "Undirected Edge";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Checked = true;
            this.radioButton7.Location = new System.Drawing.Point(189, 17);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(132, 24);
            this.radioButton7.TabIndex = 20;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Directer Edge";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.ItemHeight = 20;
            this.listBoxResult.Location = new System.Drawing.Point(1550, 156);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(340, 764);
            this.listBoxResult.TabIndex = 25;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(1618, 98);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(257, 50);
            this.buttonDelete.TabIndex = 28;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click_1);
            // 
            // FormGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 944);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxNodeInformation);
            this.Controls.Add(this.labelIn);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.labelInformation);
            this.Controls.Add(this.textBoxIn);
            this.Controls.Add(this.textBoxFrom);
            this.Controls.Add(this.textBoxNodeName);
            this.Controls.Add(this.buttonFormAddEdge);
            this.Controls.Add(this.buttonFormAddNode);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(2146, 1290);
            this.MinimumSize = new System.Drawing.Size(1918, 1000);
            this.Name = "FormGraph";
            this.Text = "Task Graph";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button buttonFormAddNode;
        private System.Windows.Forms.Button buttonFormAddEdge;
        private System.Windows.Forms.TextBox textBoxNodeName;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.TextBox textBoxIn;
        private System.Windows.Forms.Label labelInformation;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelIn;
        private System.Windows.Forms.TextBox textBoxNodeInformation;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ToolStripMenuItem saveGraphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openGraphToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.SaveFileDialog sfd1;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.Button buttonInDepth;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButtonInBreadth;
        private System.Windows.Forms.RadioButton radioButtonInDepth;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button buttonCleanGraph;
        private System.Windows.Forms.Button buttonPrimAlgorithm;
        private System.Windows.Forms.Button buttonKruskalAlgorithm;
        private System.Windows.Forms.Button buttonDelete;
    }
}

