namespace Task19._3
{
    partial class MainForm
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
            this.drawingArea = new System.Windows.Forms.Panel();
            this.addMoveNodeButton = new System.Windows.Forms.RadioButton();
            this.addEdgeButton = new System.Windows.Forms.RadioButton();
            this.removeEdgeButton = new System.Windows.Forms.RadioButton();
            this.weightNumeric = new System.Windows.Forms.NumericUpDown();
            this.checkButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.buttonAnother = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.drawingArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weightNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // drawingArea
            // 
            this.drawingArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drawingArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawingArea.Controls.Add(this.label1);
            this.drawingArea.Location = new System.Drawing.Point(12, 39);
            this.drawingArea.Name = "drawingArea";
            this.drawingArea.Size = new System.Drawing.Size(681, 389);
            this.drawingArea.TabIndex = 0;
            this.drawingArea.Paint += new System.Windows.Forms.PaintEventHandler(this.drawingArea_Paint);
            this.drawingArea.MouseClick += new System.Windows.Forms.MouseEventHandler(this.drawingArea_MouseClick);
            this.drawingArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawingArea_MouseDown);
            this.drawingArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawingArea_MouseMove);
            this.drawingArea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawingArea_MouseUp);
            // 
            // addMoveNodeButton
            // 
            this.addMoveNodeButton.AutoSize = true;
            this.addMoveNodeButton.Location = new System.Drawing.Point(12, 13);
            this.addMoveNodeButton.Name = "addMoveNodeButton";
            this.addMoveNodeButton.Size = new System.Drawing.Size(105, 17);
            this.addMoveNodeButton.TabIndex = 1;
            this.addMoveNodeButton.TabStop = true;
            this.addMoveNodeButton.Text = "Add/Move Node";
            this.addMoveNodeButton.UseVisualStyleBackColor = true;
            this.addMoveNodeButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // addEdgeButton
            // 
            this.addEdgeButton.AutoSize = true;
            this.addEdgeButton.Location = new System.Drawing.Point(115, 13);
            this.addEdgeButton.Name = "addEdgeButton";
            this.addEdgeButton.Size = new System.Drawing.Size(72, 17);
            this.addEdgeButton.TabIndex = 2;
            this.addEdgeButton.TabStop = true;
            this.addEdgeButton.Text = "Add Edge";
            this.addEdgeButton.UseVisualStyleBackColor = true;
            this.addEdgeButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // removeEdgeButton
            // 
            this.removeEdgeButton.AutoSize = true;
            this.removeEdgeButton.Location = new System.Drawing.Point(191, 13);
            this.removeEdgeButton.Name = "removeEdgeButton";
            this.removeEdgeButton.Size = new System.Drawing.Size(93, 17);
            this.removeEdgeButton.TabIndex = 3;
            this.removeEdgeButton.TabStop = true;
            this.removeEdgeButton.Text = "Remove Edge";
            this.removeEdgeButton.UseVisualStyleBackColor = true;
            this.removeEdgeButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // weightNumeric
            // 
            this.weightNumeric.Location = new System.Drawing.Point(290, 13);
            this.weightNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.weightNumeric.Name = "weightNumeric";
            this.weightNumeric.Size = new System.Drawing.Size(38, 20);
            this.weightNumeric.TabIndex = 5;
            this.weightNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(361, 12);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(119, 20);
            this.checkButton.TabIndex = 6;
            this.checkButton.Text = "Check Connectivity";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(617, 12);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 20);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // buttonAnother
            // 
            this.buttonAnother.Location = new System.Drawing.Point(489, 12);
            this.buttonAnother.Name = "buttonAnother";
            this.buttonAnother.Size = new System.Drawing.Size(119, 20);
            this.buttonAnother.TabIndex = 8;
            this.buttonAnother.Text = "Check Bipartiteness";
            this.buttonAnother.UseVisualStyleBackColor = true;
            this.buttonAnother.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(451, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hover over the node graph to see the coloring";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 440);
            this.Controls.Add(this.buttonAnother);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.weightNumeric);
            this.Controls.Add(this.removeEdgeButton);
            this.Controls.Add(this.addEdgeButton);
            this.Controls.Add(this.addMoveNodeButton);
            this.Controls.Add(this.drawingArea);
            this.Name = "MainForm";
            this.Text = "Graph Task";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.drawingArea.ResumeLayout(false);
            this.drawingArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weightNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel drawingArea;
        private System.Windows.Forms.RadioButton addMoveNodeButton;
        private System.Windows.Forms.RadioButton addEdgeButton;
        private System.Windows.Forms.RadioButton removeEdgeButton;
        private System.Windows.Forms.NumericUpDown weightNumeric;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button buttonAnother;
        private System.Windows.Forms.Label label1;
    }
}

