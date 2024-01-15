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

namespace WinFormsApp2_C_
{
    public partial class StudentPage : Form
    {
        public StudentPage()
        {
            InitializeComponent();
        }

        private string connectionString = "server=47.113.204.102;database=db;uid=db;password=db123456";

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // SQL 查询语句
                    string query = "SELECT Cdate, Ctime,Csubject,Cduration, Ccontent FROM Course where Sno=101";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);

                    // 使用 DataTable 来存储查询结果
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // 设置 dataGridView 的数据源为 DataTable
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    // 异常处理
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void StudentPage_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // SQL 查询语句
                    string query = "SELECT Sno, Hcontent,Hdate, Ano, Hanswer FROM Homework where Sno=101";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);

                    // 使用 DataTable 来存储查询结果
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // 设置 dataGridView 的数据源为 DataTable
                    dataGridView2.DataSource = dt;
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
