namespace WindowsFormsApp2
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnQuary = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDelName = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInGender = new System.Windows.Forms.TextBox();
            this.txtInPhone = new System.Windows.Forms.TextBox();
            this.txtInAge = new System.Windows.Forms.TextBox();
            this.txtInName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtInNo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(605, 216);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnQuary
            // 
            this.btnQuary.Location = new System.Drawing.Point(45, 294);
            this.btnQuary.Name = "btnQuary";
            this.btnQuary.Size = new System.Drawing.Size(240, 34);
            this.btnQuary.TabIndex = 1;
            this.btnQuary.Text = "查询";
            this.btnQuary.UseVisualStyleBackColor = true;
            this.btnQuary.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Location = new System.Drawing.Point(410, 294);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(240, 34);
            this.btnStatistics.TabIndex = 2;
            this.btnStatistics.Text = "人数统计";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "姓名";
            // 
            // txtDelName
            // 
            this.txtDelName.Location = new System.Drawing.Point(161, 383);
            this.txtDelName.Name = "txtDelName";
            this.txtDelName.Size = new System.Drawing.Size(227, 28);
            this.txtDelName.TabIndex = 4;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(533, 383);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(117, 33);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F);
            this.label2.Location = new System.Drawing.Point(1020, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "添加";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1022, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "姓名";
            // 
            // txtInGender
            // 
            this.txtInGender.Location = new System.Drawing.Point(1118, 383);
            this.txtInGender.Name = "txtInGender";
            this.txtInGender.Size = new System.Drawing.Size(227, 28);
            this.txtInGender.TabIndex = 8;
            // 
            // txtInPhone
            // 
            this.txtInPhone.Location = new System.Drawing.Point(1118, 299);
            this.txtInPhone.Name = "txtInPhone";
            this.txtInPhone.Size = new System.Drawing.Size(227, 28);
            this.txtInPhone.TabIndex = 9;
            // 
            // txtInAge
            // 
            this.txtInAge.Location = new System.Drawing.Point(1118, 210);
            this.txtInAge.Name = "txtInAge";
            this.txtInAge.Size = new System.Drawing.Size(227, 28);
            this.txtInAge.TabIndex = 10;
            // 
            // txtInName
            // 
            this.txtInName.Location = new System.Drawing.Point(1118, 133);
            this.txtInName.Name = "txtInName";
            this.txtInName.Size = new System.Drawing.Size(227, 28);
            this.txtInName.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1025, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "年龄";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1025, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "手机";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1028, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "性别";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("宋体", 20F);
            this.btnAdd.Location = new System.Drawing.Point(1031, 462);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(314, 81);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1022, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "学号";
            // 
            // txtInNo
            // 
            this.txtInNo.Location = new System.Drawing.Point(1118, 59);
            this.txtInNo.Name = "txtInNo";
            this.txtInNo.Size = new System.Drawing.Size(227, 28);
            this.txtInNo.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1699, 969);
            this.Controls.Add(this.txtInNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtInName);
            this.Controls.Add(this.txtInAge);
            this.Controls.Add(this.txtInPhone);
            this.Controls.Add(this.txtInGender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.txtDelName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.btnQuary);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnQuary;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDelName;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInGender;
        private System.Windows.Forms.TextBox txtInPhone;
        private System.Windows.Forms.TextBox txtInAge;
        private System.Windows.Forms.TextBox txtInName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtInNo;
    }
}

