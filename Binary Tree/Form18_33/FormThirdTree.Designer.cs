namespace Form18_33
{
    partial class FormThirdTree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThirdTree));
            this.buttonOpenA = new System.Windows.Forms.Button();
            this.ofdA = new System.Windows.Forms.OpenFileDialog();
            this.sfdC = new System.Windows.Forms.SaveFileDialog();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.buttonOpenB = new System.Windows.Forms.Button();
            this.buttonImplement = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.ofdB = new System.Windows.Forms.OpenFileDialog();
            this.saveCButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOpenA
            // 
            this.buttonOpenA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenA.Location = new System.Drawing.Point(690, 8);
            this.buttonOpenA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOpenA.Name = "buttonOpenA";
            this.buttonOpenA.Size = new System.Drawing.Size(96, 36);
            this.buttonOpenA.TabIndex = 0;
            this.buttonOpenA.Text = "Open file A";
            this.buttonOpenA.UseVisualStyleBackColor = true;
            this.buttonOpenA.Click += new System.EventHandler(this.buttonOpenA_Click);
            // 
            // ofdA
            // 
            this.ofdA.FileName = "openFileDialog1";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(8, 42);
            this.textBoxA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxA.Multiline = true;
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(225, 399);
            this.textBoxA.TabIndex = 2;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(235, 42);
            this.textBoxB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxB.Multiline = true;
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(225, 399);
            this.textBoxB.TabIndex = 3;
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(463, 42);
            this.textBoxC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxC.Multiline = true;
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(225, 399);
            this.textBoxC.TabIndex = 4;
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelA.Location = new System.Drawing.Point(131, 398);
            this.labelA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(83, 31);
            this.labelA.TabIndex = 5;
            this.labelA.Text = "File A";
            this.labelA.Click += new System.EventHandler(this.labelA_Click);
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelB.Location = new System.Drawing.Point(369, 398);
            this.labelB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(83, 31);
            this.labelB.TabIndex = 6;
            this.labelB.Text = "File B";
            this.labelB.Click += new System.EventHandler(this.labelB_Click);
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelC.Location = new System.Drawing.Point(594, 398);
            this.labelC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(85, 31);
            this.labelC.TabIndex = 7;
            this.labelC.Text = "File C";
            this.labelC.Click += new System.EventHandler(this.labelC_Click);
            // 
            // buttonOpenB
            // 
            this.buttonOpenB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenB.Location = new System.Drawing.Point(690, 57);
            this.buttonOpenB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOpenB.Name = "buttonOpenB";
            this.buttonOpenB.Size = new System.Drawing.Size(96, 36);
            this.buttonOpenB.TabIndex = 8;
            this.buttonOpenB.Text = "Open file B";
            this.buttonOpenB.UseVisualStyleBackColor = true;
            this.buttonOpenB.Click += new System.EventHandler(this.buttonOpenB_Click);
            // 
            // buttonImplement
            // 
            this.buttonImplement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonImplement.Location = new System.Drawing.Point(690, 115);
            this.buttonImplement.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonImplement.Name = "buttonImplement";
            this.buttonImplement.Size = new System.Drawing.Size(96, 36);
            this.buttonImplement.TabIndex = 9;
            this.buttonImplement.Text = "Implement";
            this.buttonImplement.UseVisualStyleBackColor = true;
            this.buttonImplement.Click += new System.EventHandler(this.buttonImplement_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.Location = new System.Drawing.Point(690, 403);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(96, 36);
            this.buttonClose.TabIndex = 12;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(690, 354);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(96, 36);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // ofdB
            // 
            this.ofdB.FileName = "openFileDialog2";
            // 
            // saveCButton
            // 
            this.saveCButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveCButton.Location = new System.Drawing.Point(690, 176);
            this.saveCButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveCButton.Name = "saveCButton";
            this.saveCButton.Size = new System.Drawing.Size(96, 36);
            this.saveCButton.TabIndex = 13;
            this.saveCButton.Text = "Save file C";
            this.saveCButton.UseVisualStyleBackColor = true;
            this.saveCButton.Click += new System.EventHandler(this.saveCButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.MaximumSize = new System.Drawing.Size(650, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(644, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // FormThirdTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 451);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveCButton);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonImplement);
            this.Controls.Add(this.buttonOpenB);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.buttonOpenA);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormThirdTree";
            this.Text = "Third Tree";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenA;
        private System.Windows.Forms.OpenFileDialog ofdA;
        private System.Windows.Forms.SaveFileDialog sfdC;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Button buttonOpenB;
        private System.Windows.Forms.Button buttonImplement;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.OpenFileDialog ofdB;
        private System.Windows.Forms.Button saveCButton;
        private System.Windows.Forms.Label label1;
    }
}

