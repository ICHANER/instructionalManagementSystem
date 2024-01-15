using System;
using MySql.Data.MySqlClient;




namespace WinFormsApp2_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //������� 
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

                    // ���� SQL ��ѯ
                    string query = "SELECT Ugroup FROM User WHERE Uid = @username AND Upw = @password";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // �û���֤ͨ��
                                string userGroup = reader["Ugroup"].ToString();

                                // ������ִ�������߼������������û���𡢼���Ȩ�޵�
                                MessageBox.Show("��¼�ɹ����û����" + userGroup);

                                //��ת����
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
                                // �û���֤ʧ��
                                MessageBox.Show("��¼ʧ�ܣ������˺ź�����");
                            }
                        }
                    }



                }
                catch (MySqlException ex)
                {
                    // �������ӻ��ѯ�쳣
                    MessageBox.Show("�������ݿ�ʱ��������" + ex.Message);
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
