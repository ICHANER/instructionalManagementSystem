namespace WinFormsApp2_C_
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            textBox4 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            comboBox2 = new ComboBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // textBox4
            // 
            textBox4.Location = new Point(166, 107);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(89, 23);
            textBox4.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(135, 110);
            label5.Name = "label5";
            label5.Size = new Size(32, 17);
            label5.TabIndex = 20;
            label5.Text = "学校";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 110);
            label4.Name = "label4";
            label4.Size = new Size(32, 17);
            label4.TabIndex = 19;
            label4.Text = "性别";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "男", "女" });
            comboBox1.Location = new Point(81, 107);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(38, 25);
            comboBox1.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 154);
            label3.Name = "label3";
            label3.Size = new Size(44, 17);
            label3.TabIndex = 17;
            label3.Text = "手机号";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(81, 151);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(174, 23);
            textBox3.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 73);
            label2.Name = "label2";
            label2.Size = new Size(32, 17);
            label2.TabIndex = 15;
            label2.Text = "密码";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 34);
            label1.Name = "label1";
            label1.Size = new Size(44, 17);
            label1.TabIndex = 14;
            label1.Text = "用户名";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(81, 69);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(174, 23);
            textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(81, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(174, 23);
            textBox1.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(81, 215);
            button1.Name = "button1";
            button1.Size = new Size(114, 34);
            button1.TabIndex = 11;
            button1.Text = "添加";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "男", "女" });
            comboBox2.Location = new Point(81, 184);
            comboBox2.Name = "comboBox2";
            comboBox2.RightToLeft = RightToLeft.No;
            comboBox2.Size = new Size(174, 25);
            comboBox2.TabIndex = 22;
            comboBox2.Text = "默认’教师‘";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 187);
            label6.Name = "label6";
            label6.Size = new Size(56, 17);
            label6.TabIndex = 23;
            label6.Text = "用户组别";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 261);
            Controls.Add(label6);
            Controls.Add(comboBox2);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "添加用户";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox4;
        private Label label5;
        private Label label4;
        private ComboBox comboBox1;
        private Label label3;
        private TextBox textBox3;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private ComboBox comboBox2;
        private Label label6;
    }
}