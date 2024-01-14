namespace WinFormsApp2_C_
{
    partial class TeacherPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherPage));
            button1 = new Button();
            groupBox1 = new GroupBox();
            label6 = new Label();
            comboBox5 = new ComboBox();
            label3 = new Label();
            comboBox4 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            groupBox2 = new GroupBox();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            richTextBox1 = new RichTextBox();
            comboBox2 = new ComboBox();
            groupBox3 = new GroupBox();
            label4 = new Label();
            button4 = new Button();
            comboBox1 = new ComboBox();
            button3 = new Button();
            label5 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker3 = new DateTimePicker();
            label8 = new Label();
            label9 = new Label();
            button5 = new Button();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(42, 242);
            button1.Name = "button1";
            button1.Size = new Size(144, 39);
            button1.TabIndex = 0;
            button1.Text = "添加课程";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(dateTimePicker3);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(comboBox5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBox4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(216, 304);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "添加课程";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 199);
            label6.Name = "label6";
            label6.Size = new Size(32, 17);
            label6.TabIndex = 9;
            label6.Text = "时长";
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "0.5小时", "1.5小时", "1小时", "2.5小时", "2小时", "3小时" });
            comboBox5.Location = new Point(59, 195);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(127, 25);
            comboBox5.Sorted = true;
            comboBox5.TabIndex = 8;
            comboBox5.Text = "请选择时长";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 158);
            label3.Name = "label3";
            label3.Size = new Size(32, 17);
            label3.TabIndex = 7;
            label3.Text = "学科";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "数学", "物理", "化学", "生物", "英语", "语文", "地理", "政治", "历史" });
            comboBox4.Location = new Point(59, 155);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(127, 25);
            comboBox4.TabIndex = 6;
            comboBox4.Text = "请选择学科";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 73);
            label2.Name = "label2";
            label2.Size = new Size(32, 17);
            label2.TabIndex = 4;
            label2.Text = "日期";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 35);
            label1.Name = "label1";
            label1.Size = new Size(32, 17);
            label1.TabIndex = 2;
            label1.Text = "姓名";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(59, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(127, 23);
            textBox1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(32, 239);
            button2.Name = "button2";
            button2.Size = new Size(144, 39);
            button2.TabIndex = 0;
            button2.Text = "发布作业";
            button2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(richTextBox1);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Location = new Point(264, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(209, 304);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "发布作业";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 176);
            label7.Name = "label7";
            label7.Size = new Size(56, 17);
            label7.TabIndex = 10;
            label7.Text = "截止日期";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(75, 172);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(116, 23);
            dateTimePicker1.TabIndex = 5;
            dateTimePicker1.Value = new DateTime(2024, 1, 8, 0, 0, 0, 0);
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(13, 61);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(184, 103);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "在此处添加作业内容";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(32, 27);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(154, 25);
            comboBox2.TabIndex = 5;
            comboBox2.Text = "请选择课程";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(comboBox1);
            groupBox3.Controls.Add(button3);
            groupBox3.Location = new Point(511, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(209, 164);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "上传课件";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 71);
            label4.Name = "label4";
            label4.Size = new Size(80, 17);
            label4.TabIndex = 6;
            label4.Text = "尚未选择文件";
            // 
            // button4
            // 
            button4.Location = new Point(111, 67);
            button4.Name = "button4";
            button4.Size = new Size(70, 26);
            button4.TabIndex = 5;
            button4.Text = "选择文件";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(22, 31);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(163, 25);
            comboBox1.TabIndex = 4;
            comboBox1.Text = "请选择课程";
            // 
            // button3
            // 
            button3.Location = new Point(32, 97);
            button3.Name = "button3";
            button3.Size = new Size(144, 39);
            button3.TabIndex = 0;
            button3.Text = "上传课件";
            button3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(79, -13);
            label5.Name = "label5";
            label5.Size = new Size(0, 17);
            label5.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Location = new Point(59, 113);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(127, 23);
            dateTimePicker2.TabIndex = 5;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(59, 73);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(127, 23);
            dateTimePicker3.TabIndex = 11;
            dateTimePicker3.Value = new DateTime(2024, 1, 8, 0, 0, 0, 0);
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 116);
            label8.Name = "label8";
            label8.Size = new Size(32, 17);
            label8.TabIndex = 12;
            label8.Text = "时间";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 16);
            label9.Name = "label9";
            label9.Size = new Size(80, 17);
            label9.TabIndex = 7;
            label9.Text = "尚未选择文件";
            // 
            // button5
            // 
            button5.Location = new Point(103, 12);
            button5.Name = "button5";
            button5.Size = new Size(70, 26);
            button5.TabIndex = 7;
            button5.Text = "选择文件";
            button5.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(button5);
            groupBox4.Location = new Point(13, 193);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(184, 42);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.Transparent;
            groupBox5.Controls.Add(button8);
            groupBox5.Controls.Add(button7);
            groupBox5.Controls.Add(button6);
            groupBox5.Location = new Point(511, 184);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(209, 132);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "信息查询";
            // 
            // button6
            // 
            button6.Location = new Point(22, 23);
            button6.Name = "button6";
            button6.Size = new Size(96, 28);
            button6.TabIndex = 0;
            button6.Text = "查询所有学生";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(22, 57);
            button7.Name = "button7";
            button7.Size = new Size(96, 28);
            button7.TabIndex = 1;
            button7.Text = "工资查询";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(22, 91);
            button8.Name = "button8";
            button8.Size = new Size(96, 28);
            button8.TabIndex = 2;
            button8.Text = "修改账户密码";
            button8.UseVisualStyleBackColor = true;
            // 
            // TeacherPage
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(732, 399);
            Controls.Add(groupBox5);
            Controls.Add(label5);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            DoubleBuffered = true;
            Name = "TeacherPage";
            Text = "TeacherPage";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private GroupBox groupBox1;
        private Button button2;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button button3;
        private Label label1;
        private TextBox textBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label2;
        private ComboBox comboBox4;
        private Label label3;
        private ComboBox comboBox5;
        private Button button4;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private RichTextBox richTextBox1;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker2;
        private Label label8;
        private GroupBox groupBox4;
        private Label label9;
        private Button button5;
        private GroupBox groupBox5;
        private Button button6;
        private Button button8;
        private Button button7;
    }
}