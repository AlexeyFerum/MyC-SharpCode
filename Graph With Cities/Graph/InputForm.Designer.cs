namespace Graph
{
    partial class InputForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Input = new System.Windows.Forms.TextBox();
            this.OkBtn = new System.Windows.Forms.Button();
            this.ValueText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(70, 12);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(303, 20);
            this.Input.TabIndex = 0;
            // 
            // OkBtn
            // 
            this.OkBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkBtn.Location = new System.Drawing.Point(298, 38);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 1;
            this.OkBtn.Text = "Ok";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // ValueText
            // 
            this.ValueText.AutoSize = true;
            this.ValueText.Location = new System.Drawing.Point(12, 15);
            this.ValueText.Name = "ValueText";
            this.ValueText.Size = new System.Drawing.Size(10, 13);
            this.ValueText.TabIndex = 2;
            this.ValueText.Text = " ";
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 72);
            this.Controls.Add(this.ValueText);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.Input);
            this.Name = "InputForm";
            this.Load += new System.EventHandler(this.InputForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Label ValueText;
    }
}