namespace DachnikVERSUS
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tbPlantsInfo = new System.Windows.Forms.TextBox();
            this.tbMolesInfo = new System.Windows.Forms.TextBox();
            this.bttnStart = new System.Windows.Forms.Button();
            this.bttnStop = new System.Windows.Forms.Button();
            this.Width = new System.Windows.Forms.NumericUpDown();
            this.Height = new System.Windows.Forms.NumericUpDown();
            this.plantCount = new System.Windows.Forms.NumericUpDown();
            this.moleCount = new System.Windows.Forms.NumericUpDown();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelPlants = new System.Windows.Forms.Label();
            this.labelMoles = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moleCount)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 12);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(577, 445);
            this.dgv.TabIndex = 0;
            // 
            // tbPlantsInfo
            // 
            this.tbPlantsInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPlantsInfo.Location = new System.Drawing.Point(597, 102);
            this.tbPlantsInfo.Multiline = true;
            this.tbPlantsInfo.Name = "tbPlantsInfo";
            this.tbPlantsInfo.ReadOnly = true;
            this.tbPlantsInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbPlantsInfo.Size = new System.Drawing.Size(77, 137);
            this.tbPlantsInfo.TabIndex = 1;
            // 
            // tbMolesInfo
            // 
            this.tbMolesInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMolesInfo.Location = new System.Drawing.Point(597, 244);
            this.tbMolesInfo.Multiline = true;
            this.tbMolesInfo.Name = "tbMolesInfo";
            this.tbMolesInfo.ReadOnly = true;
            this.tbMolesInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMolesInfo.Size = new System.Drawing.Size(77, 160);
            this.tbMolesInfo.TabIndex = 1;
            // 
            // bttnStart
            // 
            this.bttnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnStart.Location = new System.Drawing.Point(597, 409);
            this.bttnStart.Name = "bttnStart";
            this.bttnStart.Size = new System.Drawing.Size(76, 23);
            this.bttnStart.TabIndex = 2;
            this.bttnStart.Text = "Start";
            this.bttnStart.UseVisualStyleBackColor = true;
            this.bttnStart.Click += new System.EventHandler(this.bttnStart_Click);
            // 
            // bttnStop
            // 
            this.bttnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnStop.Location = new System.Drawing.Point(597, 434);
            this.bttnStop.Name = "bttnStop";
            this.bttnStop.Size = new System.Drawing.Size(76, 23);
            this.bttnStop.TabIndex = 2;
            this.bttnStop.Text = "Stop";
            this.bttnStop.UseVisualStyleBackColor = true;
            this.bttnStop.Click += new System.EventHandler(this.bttnStop_Click);
            // 
            // Width
            // 
            this.Width.Location = new System.Drawing.Point(634, 12);
            this.Width.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(39, 20);
            this.Width.TabIndex = 3;
            this.Width.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // Height
            // 
            this.Height.Location = new System.Drawing.Point(634, 32);
            this.Height.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(39, 20);
            this.Height.TabIndex = 4;
            this.Height.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // plantCount
            // 
            this.plantCount.Location = new System.Drawing.Point(634, 80);
            this.plantCount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.plantCount.Name = "plantCount";
            this.plantCount.Size = new System.Drawing.Size(39, 20);
            this.plantCount.TabIndex = 6;
            this.plantCount.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // moleCount
            // 
            this.moleCount.Location = new System.Drawing.Point(634, 59);
            this.moleCount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.moleCount.Name = "moleCount";
            this.moleCount.Size = new System.Drawing.Size(39, 20);
            this.moleCount.TabIndex = 5;
            this.moleCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(594, 13);
            this.labelWidth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(38, 13);
            this.labelWidth.TabIndex = 7;
            this.labelWidth.Text = "Width:";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(594, 34);
            this.labelHeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(41, 13);
            this.labelHeight.TabIndex = 8;
            this.labelHeight.Text = "Height:";
            // 
            // labelPlants
            // 
            this.labelPlants.AutoSize = true;
            this.labelPlants.Location = new System.Drawing.Point(594, 81);
            this.labelPlants.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPlants.Name = "labelPlants";
            this.labelPlants.Size = new System.Drawing.Size(39, 13);
            this.labelPlants.TabIndex = 10;
            this.labelPlants.Text = "Plants:";
            // 
            // labelMoles
            // 
            this.labelMoles.AutoSize = true;
            this.labelMoles.Location = new System.Drawing.Point(594, 60);
            this.labelMoles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMoles.Name = "labelMoles";
            this.labelMoles.Size = new System.Drawing.Size(38, 13);
            this.labelMoles.TabIndex = 9;
            this.labelMoles.Text = "Moles:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 469);
            this.Controls.Add(this.labelPlants);
            this.Controls.Add(this.labelMoles);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.plantCount);
            this.Controls.Add(this.moleCount);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.Width);
            this.Controls.Add(this.bttnStop);
            this.Controls.Add(this.bttnStart);
            this.Controls.Add(this.tbMolesInfo);
            this.Controls.Add(this.tbPlantsInfo);
            this.Controls.Add(this.dgv);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "MolesVSCottager";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moleCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox tbPlantsInfo;
        private System.Windows.Forms.TextBox tbMolesInfo;
        private System.Windows.Forms.Button bttnStart;
        private System.Windows.Forms.Button bttnStop;
        private System.Windows.Forms.NumericUpDown Width;
        private System.Windows.Forms.NumericUpDown Height;
        private System.Windows.Forms.NumericUpDown plantCount;
        private System.Windows.Forms.NumericUpDown moleCount;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelPlants;
        private System.Windows.Forms.Label labelMoles;
    }
}

