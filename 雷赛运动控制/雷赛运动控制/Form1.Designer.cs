namespace 雷赛运动控制
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
            this.OrgBtn = new System.Windows.Forms.Button();
            this.CheckBtn = new System.Windows.Forms.Button();
            this.StartBtn = new System.Windows.Forms.Button();
            this.StopBtn = new System.Windows.Forms.Button();
            this.EmgStopBtn = new System.Windows.Forms.Button();
            this.DisBox0 = new System.Windows.Forms.TextBox();
            this.DisBox1 = new System.Windows.Forms.TextBox();
            this.DisBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PosBox0 = new System.Windows.Forms.TextBox();
            this.PosBox1 = new System.Windows.Forms.TextBox();
            this.PosBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OrgBtn
            // 
            this.OrgBtn.Location = new System.Drawing.Point(419, 41);
            this.OrgBtn.Name = "OrgBtn";
            this.OrgBtn.Size = new System.Drawing.Size(96, 51);
            this.OrgBtn.TabIndex = 0;
            this.OrgBtn.Text = "回零";
            this.OrgBtn.UseVisualStyleBackColor = true;
            this.OrgBtn.Click += new System.EventHandler(this.OrgBtn_Click);
            // 
            // CheckBtn
            // 
            this.CheckBtn.Location = new System.Drawing.Point(419, 119);
            this.CheckBtn.Name = "CheckBtn";
            this.CheckBtn.Size = new System.Drawing.Size(96, 46);
            this.CheckBtn.TabIndex = 0;
            this.CheckBtn.Text = "检测io";
            this.CheckBtn.UseVisualStyleBackColor = true;
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(419, 185);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(96, 46);
            this.StartBtn.TabIndex = 0;
            this.StartBtn.Text = "运动";
            this.StartBtn.UseVisualStyleBackColor = true;
            // 
            // StopBtn
            // 
            this.StopBtn.Location = new System.Drawing.Point(419, 251);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(96, 46);
            this.StopBtn.TabIndex = 0;
            this.StopBtn.Text = "停止";
            this.StopBtn.UseVisualStyleBackColor = true;
            // 
            // EmgStopBtn
            // 
            this.EmgStopBtn.BackColor = System.Drawing.Color.Red;
            this.EmgStopBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EmgStopBtn.Location = new System.Drawing.Point(23, 23);
            this.EmgStopBtn.Name = "EmgStopBtn";
            this.EmgStopBtn.Size = new System.Drawing.Size(142, 176);
            this.EmgStopBtn.TabIndex = 1;
            this.EmgStopBtn.Text = "紧急停止";
            this.EmgStopBtn.UseVisualStyleBackColor = false;
            this.EmgStopBtn.Click += new System.EventHandler(this.EmgStopBtn_Click);
            // 
            // DisBox0
            // 
            this.DisBox0.Location = new System.Drawing.Point(307, 199);
            this.DisBox0.Name = "DisBox0";
            this.DisBox0.Size = new System.Drawing.Size(100, 21);
            this.DisBox0.TabIndex = 2;
            // 
            // DisBox1
            // 
            this.DisBox1.Location = new System.Drawing.Point(307, 244);
            this.DisBox1.Name = "DisBox1";
            this.DisBox1.Size = new System.Drawing.Size(100, 21);
            this.DisBox1.TabIndex = 2;
            // 
            // DisBox3
            // 
            this.DisBox3.Location = new System.Drawing.Point(307, 279);
            this.DisBox3.Name = "DisBox3";
            this.DisBox3.Size = new System.Drawing.Size(100, 21);
            this.DisBox3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "0轴运动距离";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "1轴运动距离";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "3轴运动距离";
            // 
            // PosBox0
            // 
            this.PosBox0.Location = new System.Drawing.Point(307, 57);
            this.PosBox0.Name = "PosBox0";
            this.PosBox0.Size = new System.Drawing.Size(100, 21);
            this.PosBox0.TabIndex = 2;
            // 
            // PosBox1
            // 
            this.PosBox1.Location = new System.Drawing.Point(307, 102);
            this.PosBox1.Name = "PosBox1";
            this.PosBox1.Size = new System.Drawing.Size(100, 21);
            this.PosBox1.TabIndex = 2;
            // 
            // PosBox3
            // 
            this.PosBox3.Location = new System.Drawing.Point(307, 137);
            this.PosBox3.Name = "PosBox3";
            this.PosBox3.Size = new System.Drawing.Size(100, 21);
            this.PosBox3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "0轴位置";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "1轴位置";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "3轴位置";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 326);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PosBox3);
            this.Controls.Add(this.DisBox3);
            this.Controls.Add(this.PosBox1);
            this.Controls.Add(this.DisBox1);
            this.Controls.Add(this.PosBox0);
            this.Controls.Add(this.DisBox0);
            this.Controls.Add(this.EmgStopBtn);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.CheckBtn);
            this.Controls.Add(this.OrgBtn);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OrgBtn;
        private System.Windows.Forms.Button CheckBtn;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.Button EmgStopBtn;
        private System.Windows.Forms.TextBox DisBox0;
        private System.Windows.Forms.TextBox DisBox1;
        private System.Windows.Forms.TextBox DisBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PosBox0;
        private System.Windows.Forms.TextBox PosBox1;
        private System.Windows.Forms.TextBox PosBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

