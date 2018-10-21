namespace task16._18
{
    partial class task1618
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
            this.panelka = new System.Windows.Forms.Panel();
            this.random = new System.Windows.Forms.Button();
            this.Sortmas = new System.Windows.Forms.Button();
            this.obzor = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.panelka.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelka
            // 
            this.panelka.Controls.Add(this.random);
            this.panelka.Controls.Add(this.Sortmas);
            this.panelka.Controls.Add(this.obzor);
            this.panelka.Location = new System.Drawing.Point(0, 0);
            this.panelka.Name = "panelka";
            this.panelka.Size = new System.Drawing.Size(951, 614);
            this.panelka.TabIndex = 0;
            // 
            // random
            // 
            this.random.Location = new System.Drawing.Point(115, 12);
            this.random.Name = "random";
            this.random.Size = new System.Drawing.Size(112, 36);
            this.random.TabIndex = 2;
            this.random.Text = "Set random array";
            this.random.UseVisualStyleBackColor = true;
            this.random.Click += new System.EventHandler(this.random_Click);
            // 
            // Sortmas
            // 
            this.Sortmas.Location = new System.Drawing.Point(267, 12);
            this.Sortmas.Name = "Sortmas";
            this.Sortmas.Size = new System.Drawing.Size(109, 36);
            this.Sortmas.TabIndex = 1;
            this.Sortmas.Text = "Implement sort";
            this.Sortmas.UseVisualStyleBackColor = true;
            this.Sortmas.Click += new System.EventHandler(this.Sortmas_Click);
            // 
            // obzor
            // 
            this.obzor.Location = new System.Drawing.Point(12, 12);
            this.obzor.Name = "obzor";
            this.obzor.Size = new System.Drawing.Size(75, 23);
            this.obzor.TabIndex = 0;
            this.obzor.Text = "Open";
            this.obzor.UseVisualStyleBackColor = true;
            this.obzor.Click += new System.EventHandler(this.obzor_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // task1618
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 448);
            this.Controls.Add(this.panelka);
            this.Name = "task1618";
            this.Text = "Quick sort";
            this.panelka.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelka;
        private System.Windows.Forms.Button random;
        private System.Windows.Forms.Button Sortmas;
        private System.Windows.Forms.Button obzor;
        private System.Windows.Forms.OpenFileDialog ofd;
    }
}

