namespace FormSecondProg
{
    partial class FormSecondProg
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
            this.buttonReadFromFile = new System.Windows.Forms.Button();
            this.ReadTextBox = new System.Windows.Forms.TextBox();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.buttonImplement = new System.Windows.Forms.Button();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // buttonReadFromFile
            // 
            this.buttonReadFromFile.Location = new System.Drawing.Point(8, 8);
            this.buttonReadFromFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonReadFromFile.Name = "buttonReadFromFile";
            this.buttonReadFromFile.Size = new System.Drawing.Size(98, 56);
            this.buttonReadFromFile.TabIndex = 0;
            this.buttonReadFromFile.Text = "Choose file for reading";
            this.buttonReadFromFile.UseVisualStyleBackColor = true;
            this.buttonReadFromFile.Click += new System.EventHandler(this.buttonReadFromFile_Click);
            // 
            // ReadTextBox
            // 
            this.ReadTextBox.Location = new System.Drawing.Point(10, 75);
            this.ReadTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ReadTextBox.Multiline = true;
            this.ReadTextBox.Name = "ReadTextBox";
            this.ReadTextBox.Size = new System.Drawing.Size(334, 334);
            this.ReadTextBox.TabIndex = 1;
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(359, 75);
            this.ResultTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(161, 334);
            this.ResultTextBox.TabIndex = 2;
            // 
            // buttonImplement
            // 
            this.buttonImplement.Location = new System.Drawing.Point(110, 8);
            this.buttonImplement.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonImplement.Name = "buttonImplement";
            this.buttonImplement.Size = new System.Drawing.Size(205, 56);
            this.buttonImplement.TabIndex = 3;
            this.buttonImplement.Text = "Implement program";
            this.buttonImplement.UseVisualStyleBackColor = true;
            this.buttonImplement.Click += new System.EventHandler(this.buttonImplement_Click);
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.Location = new System.Drawing.Point(319, 8);
            this.buttonSaveFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(98, 56);
            this.buttonSaveFile.TabIndex = 4;
            this.buttonSaveFile.Text = "Create file for saving";
            this.buttonSaveFile.UseVisualStyleBackColor = true;
            this.buttonSaveFile.Click += new System.EventHandler(this.buttonSaveFile_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(421, 8);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(98, 56);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormSecondProg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 415);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSaveFile);
            this.Controls.Add(this.buttonImplement);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.ReadTextBox);
            this.Controls.Add(this.buttonReadFromFile);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormSecondProg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReadFromFile;
        private System.Windows.Forms.TextBox ReadTextBox;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Button buttonImplement;
        private System.Windows.Forms.Button buttonSaveFile;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

