namespace WinFormsApp2_C_
{
    partial class AdminPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(123, 287);
            button1.Name = "button1";
            button1.Size = new Size(111, 28);
            button1.TabIndex = 1;
            button1.Text = "列出学生信息";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(240, 287);
            button2.Name = "button2";
            button2.Size = new Size(111, 28);
            button2.TabIndex = 2;
            button2.Text = "列出教师信息";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(357, 287);
            button3.Name = "button3";
            button3.Size = new Size(111, 28);
            button3.TabIndex = 3;
            button3.Text = "列出课程信息";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(783, 276);
            dataGridView1.TabIndex = 4;
            // 
            // button4
            // 
            button4.Location = new Point(123, 321);
            button4.Name = "button4";
            button4.Size = new Size(228, 30);
            button4.TabIndex = 0;
            button4.Text = "修改账户密码";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(474, 287);
            button5.Name = "button5";
            button5.Size = new Size(111, 28);
            button5.TabIndex = 5;
            button5.Text = "列出作业信息";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(591, 287);
            button6.Name = "button6";
            button6.Size = new Size(111, 28);
            button6.TabIndex = 6;
            button6.Text = "列出附件信息";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(474, 321);
            button7.Name = "button7";
            button7.Size = new Size(111, 30);
            button7.TabIndex = 7;
            button7.Text = "添加作业";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(474, 357);
            button8.Name = "button8";
            button8.Size = new Size(111, 30);
            button8.TabIndex = 8;
            button8.Text = "删除作业";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(591, 321);
            button9.Name = "button9";
            button9.Size = new Size(111, 30);
            button9.TabIndex = 9;
            button9.Text = "添加附件";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(591, 357);
            button10.Name = "button10";
            button10.Size = new Size(111, 30);
            button10.TabIndex = 10;
            button10.Text = "删除附件";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Location = new Point(123, 357);
            button11.Name = "button11";
            button11.Size = new Size(228, 30);
            button11.TabIndex = 11;
            button11.Text = "添加账户";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.Location = new Point(357, 321);
            button12.Name = "button12";
            button12.Size = new Size(111, 30);
            button12.TabIndex = 12;
            button12.Text = "添加课程";
            button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            button13.Location = new Point(357, 357);
            button13.Name = "button13";
            button13.Size = new Size(111, 30);
            button13.TabIndex = 13;
            button13.Text = "删除课程";
            button13.UseVisualStyleBackColor = true;
            // 
            // AdminPage
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 399);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminPage";
            Text = "AdminPage";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
    }
}