using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2_C_
{
    public partial class TeacherPage : Form
    {
        public TeacherPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string file = "";
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;      //该值确定是否可以选择多个文件
            dialog.Title = "请选择文件";     //弹窗的标题
            dialog.InitialDirectory = "D:\\";       //默认打开的文件夹的位置
            dialog.Filter = "Microsoft Excel文件(*.xlsx)|*.xlsx|Microsoft PowerPoint文件(*.pptx)|*.pptx |PDF文件(*.PDF)|*.pdf|所有文件(*.*)|*.*";       //筛选文件

            dialog.ShowHelp = true;     //是否显示“帮助”按钮

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                file = dialog.FileName;
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
