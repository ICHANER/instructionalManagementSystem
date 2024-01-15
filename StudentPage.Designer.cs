namespace WinFormsApp2_C_
{
    partial class StudentPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentPage));
            groupBox1 = new GroupBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            groupBox3 = new GroupBox();
            comboBox1 = new ComboBox();
            richTextBox1 = new RichTextBox();
            button2 = new Button();
            groupBox2 = new GroupBox();
            groupBox4 = new GroupBox();
            comboBox2 = new ComboBox();
            richTextBox2 = new RichTextBox();
            button4 = new Button();
            button3 = new Button();
            dataGridView2 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Location = new Point(32, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(455, 408);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "课程列表";
            // 
            // button1
            // 
            button1.Location = new Point(160, 246);
            button1.Name = "button1";
            button1.Size = new Size(124, 31);
            button1.TabIndex = 3;
            button1.Text = "查询课程信息";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(443, 219);
            dataGridView1.TabIndex = 2;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(comboBox1);
            groupBox3.Controls.Add(richTextBox1);
            groupBox3.Controls.Add(button2);
            groupBox3.Location = new Point(6, 271);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(443, 131);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "评语";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "2024/1/15 语文", "2024/1/16 数学", "2024/1/19 生物" });
            comboBox1.Location = new Point(6, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(341, 25);
            comboBox1.TabIndex = 6;
            comboBox1.Text = "请选择要评价的课程";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(6, 53);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(341, 72);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // button2
            // 
            button2.Location = new Point(353, 22);
            button2.Name = "button2";
            button2.Size = new Size(84, 103);
            button2.TabIndex = 4;
            button2.Text = "发布评语";
            button2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Location = new Point(493, 30);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(390, 408);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "作业列表";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(comboBox2);
            groupBox4.Controls.Add(richTextBox2);
            groupBox4.Controls.Add(button4);
            groupBox4.Location = new Point(6, 277);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(378, 131);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "评语";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(6, 22);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(295, 25);
            comboBox2.TabIndex = 6;
            comboBox2.Text = "请选择要完成的作业";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(6, 53);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(295, 72);
            richTextBox2.TabIndex = 5;
            richTextBox2.Text = "";
            // 
            // button4
            // 
            button4.Location = new Point(307, 22);
            button4.Name = "button4";
            button4.Size = new Size(65, 103);
            button4.TabIndex = 4;
            button4.Text = "提交作业";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(146, 246);
            button3.Name = "button3";
            button3.Size = new Size(124, 31);
            button3.TabIndex = 6;
            button3.Text = "查询作业信息";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6, 22);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(378, 219);
            dataGridView2.TabIndex = 3;
            // 
            // StudentPage
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "StudentPage";
            Text = "StudentPage";
            Load += StudentPage_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private Button button1;
        private GroupBox groupBox3;
        private ComboBox comboBox1;
        private RichTextBox richTextBox1;
        private Button button2;
        private GroupBox groupBox4;
        private ComboBox comboBox2;
        private RichTextBox richTextBox2;
        private Button button4;
        private Button button3;
        private DataGridView dataGridView2;
    }
}