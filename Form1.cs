using System;
using MySql.Data.MySqlClient;




namespace WinFormsApp2_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //窗体居中 
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        string connectionString = "server=47.113.204.102;database=db;uid=db;password=db123456";
        private void button1_Click(object sender, EventArgs e)
        {
            //TeacherPage Ft = new TeacherPage();
            //Ft.Show();

            string username = textBox1.Text;
            string password = textBox2.Text;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // 创建 SQL 查询
                    string query = "SELECT Ugroup FROM User WHERE Uid = @username AND Upw = @password";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // 用户验证通过
                                string userGroup = reader["Ugroup"].ToString();

                                // 在这里执行您的逻辑，例如设置用户组别、加载权限等
                                MessageBox.Show("登录成功，用户组别：" + userGroup);

                                //跳转窗口
                                if (userGroup == "admin")
                                {
                                    AdminPage AP = new AdminPage();
                                    AP.Show();
                                    //this.Visible = false;
                                }
                                else if (userGroup == "student")
                                {
                                    StudentPage SP = new StudentPage();
                                    SP.Show();
                                    //this.Visible = false;
                                }
                                else if (userGroup == "teacher")
                                {
                                    TeacherPage TP = new TeacherPage();
                                    TP.Show();
                                    //this.Visible = false;
                                }


                            }
                            else
                            {
                                // 用户验证失败
                                MessageBox.Show("登录失败，请检查账号和密码");
                            }
                        }
                    }



                }
                catch (MySqlException ex)
                {
                    // 处理连接或查询异常
                    MessageBox.Show("连接数据库时发生错误：" + ex.Message);
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            reg RP = new reg();
            RP.Show();
        }
    }
}
