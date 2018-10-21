namespace _1
{
    partial class TreeForm
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
            this.Output = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.open = new System.Windows.Forms.ToolStripMenuItem();
            this.save = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialogTxt = new System.Windows.Forms.SaveFileDialog();
            this.SearchTreeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Output)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(12, 56);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(776, 382);
            this.Output.TabIndex = 0;
            this.Output.TabStop = false;
            this.Output.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Output_MouseDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.open,
            this.save});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.файлToolStripMenuItem.Text = "File";
            // 
            // open
            // 
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(180, 22);
            this.open.Text = "Open";
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // save
            // 
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(180, 22);
            this.save.Text = "Save";
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddBtn,
            this.RemoveBtn});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(127, 48);
            // 
            // AddBtn
            // 
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(126, 22);
            this.AddBtn.Text = "Добавить";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(126, 22);
            this.RemoveBtn.Text = "Удалить";
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "Dat (*.dat)|*.dat|All|*.*";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Dat (*.dat)|*.dat|All|*.*";
            // 
            // saveFileDialogTxt
            // 
            this.saveFileDialogTxt.Filter = "Text|*.txt|All|*.*";
            // 
            // SearchTreeBtn
            // 
            this.SearchTreeBtn.Location = new System.Drawing.Point(12, 27);
            this.SearchTreeBtn.Name = "SearchTreeBtn";
            this.SearchTreeBtn.Size = new System.Drawing.Size(167, 23);
            this.SearchTreeBtn.TabIndex = 3;
            this.SearchTreeBtn.Text = "Check for binary search tree";
            this.SearchTreeBtn.UseVisualStyleBackColor = true;
            this.SearchTreeBtn.Click += new System.EventHandler(this.SearchTreeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(447, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "For adding the node, click right mouse button on the existing node";
            // 
            // TreeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchTreeBtn);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TreeForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TreeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Output)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Output;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem open;
        private System.Windows.Forms.ToolStripMenuItem save;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AddBtn;
        private System.Windows.Forms.ToolStripMenuItem RemoveBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialogTxt;
        private System.Windows.Forms.Button SearchTreeBtn;
        private System.Windows.Forms.Label label1;
    }
}

