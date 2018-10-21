namespace _16_19
{
    partial class SortForm
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
            this.rb_Bubble = new System.Windows.Forms.RadioButton();
            this.rb_Shaker = new System.Windows.Forms.RadioButton();
            this.btn_NewArray = new System.Windows.Forms.Button();
            this.btn_Again = new System.Windows.Forms.Button();
            this.btn_Sort = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_Stop = new System.Windows.Forms.Button();
            this.btn_Launch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rb_Bubble
            // 
            this.rb_Bubble.AutoSize = true;
            this.rb_Bubble.Checked = true;
            this.rb_Bubble.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_Bubble.Location = new System.Drawing.Point(492, 15);
            this.rb_Bubble.Name = "rb_Bubble";
            this.rb_Bubble.Size = new System.Drawing.Size(98, 21);
            this.rb_Bubble.TabIndex = 2;
            this.rb_Bubble.TabStop = true;
            this.rb_Bubble.Text = "Bubble sort";
            this.rb_Bubble.UseVisualStyleBackColor = true;
            // 
            // rb_Shaker
            // 
            this.rb_Shaker.AutoSize = true;
            this.rb_Shaker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_Shaker.Location = new System.Drawing.Point(492, 42);
            this.rb_Shaker.Name = "rb_Shaker";
            this.rb_Shaker.Size = new System.Drawing.Size(99, 21);
            this.rb_Shaker.TabIndex = 3;
            this.rb_Shaker.Text = "Shaker sort";
            this.rb_Shaker.UseVisualStyleBackColor = true;
            // 
            // btn_NewArray
            // 
            this.btn_NewArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_NewArray.Location = new System.Drawing.Point(492, 83);
            this.btn_NewArray.Name = "btn_NewArray";
            this.btn_NewArray.Size = new System.Drawing.Size(113, 23);
            this.btn_NewArray.TabIndex = 4;
            this.btn_NewArray.Text = "New array";
            this.btn_NewArray.UseVisualStyleBackColor = true;
            this.btn_NewArray.Click += new System.EventHandler(this.btn_NewArray_Click);
            // 
            // btn_Again
            // 
            this.btn_Again.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Again.Location = new System.Drawing.Point(492, 141);
            this.btn_Again.Name = "btn_Again";
            this.btn_Again.Size = new System.Drawing.Size(75, 23);
            this.btn_Again.TabIndex = 5;
            this.btn_Again.Text = "Start agin";
            this.btn_Again.UseVisualStyleBackColor = true;
            this.btn_Again.Click += new System.EventHandler(this.btn_Again_Click);
            // 
            // btn_Sort
            // 
            this.btn_Sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Sort.Location = new System.Drawing.Point(492, 112);
            this.btn_Sort.Name = "btn_Sort";
            this.btn_Sort.Size = new System.Drawing.Size(154, 23);
            this.btn_Sort.TabIndex = 6;
            this.btn_Sort.Text = "Start sorting";
            this.btn_Sort.UseVisualStyleBackColor = true;
            this.btn_Sort.Click += new System.EventHandler(this.btn_Sort_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(478, 451);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 350;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Stop.Location = new System.Drawing.Point(71, 417);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(53, 23);
            this.btn_Stop.TabIndex = 8;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // btn_Launch
            // 
            this.btn_Launch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Launch.Location = new System.Drawing.Point(12, 417);
            this.btn_Launch.Name = "btn_Launch";
            this.btn_Launch.Size = new System.Drawing.Size(53, 23);
            this.btn_Launch.TabIndex = 9;
            this.btn_Launch.Text = "Start";
            this.btn_Launch.UseVisualStyleBackColor = true;
            this.btn_Launch.Click += new System.EventHandler(this.btn_Launch_Click);
            // 
            // SortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 452);
            this.Controls.Add(this.btn_Launch);
            this.Controls.Add(this.btn_Sort);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Again);
            this.Controls.Add(this.btn_NewArray);
            this.Controls.Add(this.rb_Shaker);
            this.Controls.Add(this.rb_Bubble);
            this.Name = "SortForm";
            this.Text = "Sorts";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_Bubble;
        private System.Windows.Forms.RadioButton rb_Shaker;
        private System.Windows.Forms.Button btn_NewArray;
        private System.Windows.Forms.Button btn_Again;
        private System.Windows.Forms.Button btn_Sort;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Button btn_Launch;
    }
}

