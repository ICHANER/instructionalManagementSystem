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
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }
        private string connectionString = "server=47.113.204.102;database=db;uid=db;password=db123456";
        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // SQL 查询语句
                    string query = "SELECT Sno, Sgrade, Sclass, Scombination, Ssex, Scontact FROM Student";
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

        private void button2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // SQL 查询语句
                    string query = "SELECT Tno, Tsex,Tclass, Tschool, Tcombination, Tsubject,Tuniversity,Tmajor ,Tcontact FROM Teacher";
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

        private void button11_Click(object sender, EventArgs e)
        {
            Form2 F2P = new Form2();
            F2P.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // SQL 查询语句
                    string query = "SELECT Cdate, Ctime,Csubject,Cduration, Ccontent,Cfee,Cwage,Ceva FROM Course";
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

        private void button5_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // SQL 查询语句
                    string query = "SELECT Sno, Hcontent,Hdate, Ano, Hanswer FROM Homework";
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
    }
}
