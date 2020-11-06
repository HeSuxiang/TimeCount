namespace timecount
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.userControl17 = new timecount.UserControl1();
            this.userControl16 = new timecount.UserControl1();
            this.userControl15 = new timecount.UserControl1();
            this.userControl14 = new timecount.UserControl1();
            this.userControl13 = new timecount.UserControl1();
            this.userControl12 = new timecount.UserControl1();
            this.userControl11 = new timecount.UserControl1();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(520, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 55);
            this.button1.TabIndex = 8;
            this.button1.TabStop = false;
            this.button1.Text = "计算 (end)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.userControl11);
            this.groupBox1.Location = new System.Drawing.Point(4, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 94);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "第1次";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.userControl12);
            this.groupBox2.Location = new System.Drawing.Point(233, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 94);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "第2次";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.userControl13);
            this.groupBox3.Location = new System.Drawing.Point(460, 131);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(223, 94);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "第3次";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.userControl14);
            this.groupBox4.Location = new System.Drawing.Point(689, 131);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(232, 94);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "第4次";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.userControl15);
            this.groupBox5.Location = new System.Drawing.Point(927, 131);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(216, 94);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "第5次";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(138, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(876, 57);
            this.label1.TabIndex = 16;
            this.label1.Text = "时间计算";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(520, 416);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 32);
            this.button2.TabIndex = 9;
            this.button2.Text = "重置 (del)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1103, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "about";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 489);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 19;
            this.label3.Text = "output:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(549, 461);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 16);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "悬浮置顶";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.userControl16);
            this.groupBox6.Location = new System.Drawing.Point(362, 245);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(216, 94);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "晚上加班第1次";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.userControl17);
            this.groupBox7.Location = new System.Drawing.Point(584, 245);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(216, 94);
            this.groupBox7.TabIndex = 17;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "晚上加班第2次";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(766, 477);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 12);
            this.label5.TabIndex = 22;
            this.label5.Text = "Tab键和左右键，切换输入框";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(766, 500);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 12);
            this.label6.TabIndex = 23;
            this.label6.Text = "End键计算，Delete重置";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(940, 477);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 12);
            this.label7.TabIndex = 24;
            this.label7.Text = "PageUp键   快速切换到白天输入框";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(940, 498);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 12);
            this.label8.TabIndex = 25;
            this.label8.Text = "PageDown键 快速切换到晚上输入框";
            // 
            // userControl17
            // 
            this.userControl17.Location = new System.Drawing.Point(1, 20);
            this.userControl17.Name = "userControl17";
            this.userControl17.Size = new System.Drawing.Size(212, 57);
            this.userControl17.TabIndex = 7;
            // 
            // userControl16
            // 
            this.userControl16.Location = new System.Drawing.Point(1, 20);
            this.userControl16.Name = "userControl16";
            this.userControl16.Size = new System.Drawing.Size(212, 57);
            this.userControl16.TabIndex = 6;
            // 
            // userControl15
            // 
            this.userControl15.Location = new System.Drawing.Point(1, 20);
            this.userControl15.Name = "userControl15";
            this.userControl15.Size = new System.Drawing.Size(212, 57);
            this.userControl15.TabIndex = 5;
            // 
            // userControl14
            // 
            this.userControl14.Location = new System.Drawing.Point(6, 20);
            this.userControl14.Name = "userControl14";
            this.userControl14.Size = new System.Drawing.Size(220, 57);
            this.userControl14.TabIndex = 4;
            // 
            // userControl13
            // 
            this.userControl13.Location = new System.Drawing.Point(6, 20);
            this.userControl13.Name = "userControl13";
            this.userControl13.Size = new System.Drawing.Size(226, 57);
            this.userControl13.TabIndex = 3;
            // 
            // userControl12
            // 
            this.userControl12.Location = new System.Drawing.Point(6, 20);
            this.userControl12.Name = "userControl12";
            this.userControl12.Size = new System.Drawing.Size(227, 57);
            this.userControl12.TabIndex = 2;
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(6, 20);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(231, 57);
            this.userControl11.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 519);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "时间计算v1.2";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Enter += new System.EventHandler(this.button1_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControl1 userControl11;
        private UserControl1 userControl12;
        private UserControl1 userControl13;
        private UserControl1 userControl14;
        private UserControl1 userControl15;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private UserControl1 userControl16;
        private System.Windows.Forms.GroupBox groupBox7;
        private UserControl1 userControl17;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

