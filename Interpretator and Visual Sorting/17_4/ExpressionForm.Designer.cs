namespace _17_4
{
    partial class ExpessionForm
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
            this.lbl_result = new System.Windows.Forms.Label();
            this.tb_input = new System.Windows.Forms.TextBox();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.drawSpace = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_result.Location = new System.Drawing.Point(255, 13);
            this.lbl_result.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(31, 20);
            this.lbl_result.TabIndex = 1;
            this.lbl_result.Text = "= ?";
            // 
            // tb_input
            // 
            this.tb_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_input.Location = new System.Drawing.Point(10, 9);
            this.tb_input.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_input.Name = "tb_input";
            this.tb_input.Size = new System.Drawing.Size(242, 26);
            this.tb_input.TabIndex = 2;
            this.tb_input.Text = "(2+((4/2)*(7-6)))";
            // 
            // btn_calculate
            // 
            this.btn_calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_calculate.Location = new System.Drawing.Point(456, 9);
            this.btn_calculate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(94, 24);
            this.btn_calculate.TabIndex = 3;
            this.btn_calculate.Text = "Count";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_clear.Location = new System.Drawing.Point(555, 9);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(80, 24);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // drawSpace
            // 
            this.drawSpace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drawSpace.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.drawSpace.Location = new System.Drawing.Point(1, 84);
            this.drawSpace.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.drawSpace.Name = "drawSpace";
            this.drawSpace.Size = new System.Drawing.Size(654, 351);
            this.drawSpace.TabIndex = 5;
            this.drawSpace.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.drawSpace.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.drawSpace.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.drawSpace.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 49);
            this.label1.MaximumSize = new System.Drawing.Size(350, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "<expression>  ::= <numeral> | (<expression><sign><expression>)    <sign>  ::= + |" +
    " – | * ";
            // 
            // ExpessionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 436);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drawSpace);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.tb_input);
            this.Controls.Add(this.lbl_result);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ExpessionForm";
            this.Text = "Interpretator";
            this.SizeChanged += new System.EventHandler(this.ExpressionForm_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.TextBox tb_input;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Panel drawSpace;
        private System.Windows.Forms.Label label1;
    }
}

