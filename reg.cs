using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp2_C_
{
    public partial class reg : Form
    {
        public reg()
        {
            InitializeComponent();
        }

        private string connectionString = "server=47.113.204.102;database=db;uid=db;password=db123456";
        private void button1_Click(object sender, EventArgs e)
        {
            // 从文本框和下拉框获取用户输入
            string uid = textBox1.Text;
            string password = textBox2.Text;
            string phone = textBox3.Text;
            string school = textBox4.Text;
            string gender = comboBox1.SelectedItem.ToString();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // 插入到Student表
                    string studentSql = "INSERT INTO Student (Ssex, Sschool, Scontact) VALUES (@Gender, @School, @Phone); SELECT LAST_INSERT_ID();";
                    MySqlCommand studentCmd = new MySqlCommand(studentSql, conn);
                    studentCmd.Parameters.AddWithValue("@Gender", gender);
                    studentCmd.Parameters.AddWithValue("@School", school);
                    studentCmd.Parameters.AddWithValue("@Phone", phone);

                    int uno = Convert.ToInt32(studentCmd.ExecuteScalar());

                    // 插入到User表
                    string userSql = "INSERT INTO User (Uid, Upw, Ugroup) VALUES (@Uid, @Password, 'student');";
                    MySqlCommand userCmd = new MySqlCommand(userSql, conn);
                    userCmd.Parameters.AddWithValue("@Uid", uid);
                    userCmd.Parameters.AddWithValue("@Password", password); // 实际应用中应加密密码
                    //userCmd.Parameters.AddWithValue("@Uno", uno);

                    userCmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // 异常处理
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }





        }
    }
}
