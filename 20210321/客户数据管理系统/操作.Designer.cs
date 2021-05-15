
namespace 客户数据管理系统
{
    partial class 操作
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtInName = new System.Windows.Forms.TextBox();
            this.btnInquire = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnInquireAll = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDelName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInPhone = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名";
            // 
            // txtInName
            // 
            this.txtInName.Location = new System.Drawing.Point(181, 35);
            this.txtInName.Name = "txtInName";
            this.txtInName.Size = new System.Drawing.Size(140, 25);
            this.txtInName.TabIndex = 2;
            // 
            // btnInquire
            // 
            this.btnInquire.Font = new System.Drawing.Font("宋体", 16F);
            this.btnInquire.Location = new System.Drawing.Point(371, 38);
            this.btnInquire.Name = "btnInquire";
            this.btnInquire.Size = new System.Drawing.Size(92, 57);
            this.btnInquire.TabIndex = 4;
            this.btnInquire.Text = "查询";
            this.btnInquire.UseVisualStyleBackColor = true;
            this.btnInquire.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("宋体", 14F);
            this.btnChange.Location = new System.Drawing.Point(633, 35);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(40, 153);
            this.btnChange.TabIndex = 5;
            this.btnChange.Text = "修改密码";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(50, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(480, 138);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnInquireAll
            // 
            this.btnInquireAll.Location = new System.Drawing.Point(50, 290);
            this.btnInquireAll.Name = "btnInquireAll";
            this.btnInquireAll.Size = new System.Drawing.Size(139, 56);
            this.btnInquireAll.TabIndex = 7;
            this.btnInquireAll.Text = "查询全部";
            this.btnInquireAll.UseVisualStyleBackColor = true;
            this.btnInquireAll.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(390, 290);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 56);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "增加客户";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDelName
            // 
            this.txtDelName.Location = new System.Drawing.Point(50, 400);
            this.txtDelName.Name = "txtDelName";
            this.txtDelName.Size = new System.Drawing.Size(181, 25);
            this.txtDelName.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "客户名称";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(371, 383);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(102, 55);
            this.btnDel.TabIndex = 11;
            this.btnDel.Text = "删除客户";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 15F);
            this.button1.Location = new System.Drawing.Point(633, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 101);
            this.button1.TabIndex = 12;
            this.button1.Text = "返回";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "手机号";
            // 
            // txtInPhone
            // 
            this.txtInPhone.Location = new System.Drawing.Point(181, 74);
            this.txtInPhone.Name = "txtInPhone";
            this.txtInPhone.Size = new System.Drawing.Size(140, 25);
            this.txtInPhone.TabIndex = 3;
            // 
            // 操作
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDelName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnInquireAll);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnInquire);
            this.Controls.Add(this.txtInPhone);
            this.Controls.Add(this.txtInName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "操作";
            this.Text = "操作";
            this.Load += new System.EventHandler(this.操作_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInName;
        private System.Windows.Forms.Button btnInquire;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnInquireAll;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtDelName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInPhone;
    }
}