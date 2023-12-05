using Microsoft.Data.SqlClient;
using service_center.functional;
using service_center.main;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace service_center
{
    public partial class Autorization : Form
    {
        public Autorization()
        {
            InitializeComponent();
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                if (textBox1.Text == "admin" && textBox2.Text == "admin")
                {
                    newAdminForm adminForm = new();
                    adminForm.Show();
                }
                else if (textBox1.Text == "reception" && textBox2.Text == "reception")
                {
                    ReceptionistForm receptionist = new();
                    receptionist.Show();
                }
                else
                {
                    DataTable dt = new DataTable();
                    using (SqlConnection conn = new SqlConnection(Helper.dbConnectionString))
                    {
                        string searchCommand = $@"select account_employee_id,account_employee_position_id from accounts  
                                              where account_login = '{textBox1.Text}' and account_password= '{textBox2.Text}';";
                        using (SqlDataAdapter adapter = new(searchCommand, conn))
                        {
                            adapter.Fill(dt);
                        }
                    }
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Такого користувача не існує! Перевірте правильність вводу");
                    }
                    else if (dt.Rows.Count == 1)
                    {
                        int employee_id = (int)dt.Rows[0][0];
                        Employee emp = new(employee_id);
                        emp.Show();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                newAdminForm adminForm = new();
                adminForm.Show();
            }
            else if (textBox1.Text == "reception" && textBox2.Text == "reception")
            {
                ReceptionistForm receptionist = new();
                receptionist.Show();
            }
            else
            {
                DataTable dt = new DataTable();
                using (SqlConnection conn = new SqlConnection(Helper.dbConnectionString))
                {
                    string searchCommand = $@"select account_employee_id,account_employee_position_id from accounts  
                                              where account_login = '{textBox1.Text}' and account_password= '{textBox2.Text}';";
                    using (SqlDataAdapter adapter = new(searchCommand, conn))
                    {
                        adapter.Fill(dt);
                    }
                }
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Такого користувача не існує! Перевірте правильність вводу");
                }
                else if (dt.Rows.Count == 1)
                {
                    int employee_id = (int)dt.Rows[0][0];
                    Employee emp = new(employee_id);
                    emp.Show();
                }
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            newAdminForm adminForm = new();
            adminForm.Show();
        }
        public void LoadUserForm()
        {
            
        }
        public void LoadEmployeeForm()
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void userEnter(object sender, EventArgs e)
        {

        }



        private void receptionistEnter(object sender, EventArgs e)
        {
            ReceptionistForm recf = new();
            recf.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Autorization_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (textBox1.Text == "admin" && textBox2.Text == "admin")
                {
                    newAdminForm adminForm = new();
                    adminForm.Show();
                }
                else if (textBox1.Text == "reception" && textBox2.Text == "reception")
                {
                    ReceptionistForm receptionist = new();
                    receptionist.Show();
                }
                else if (textBox1.Text == "fortest" && textBox2.Text == "fortest")
                {
                    forTest forTest = new();
                    forTest.Show();
                }
                else
                {
                    DataTable dt = new DataTable();
                    using (SqlConnection conn = new SqlConnection(Helper.dbConnectionString))
                    {
                        string searchCommand = $@"select account_employee_id,account_employee_position_id from accounts  
                                              where account_login = '{textBox1.Text}' and account_password= '{textBox2.Text}';";
                        using (SqlDataAdapter adapter = new(searchCommand, conn))
                        {
                            adapter.Fill(dt);
                        }
                    }
                    if (dt.Rows.Count == 0)
                    {
                        MyMessageBox.Show("Такого користувача не існує! Перевірте правильність вводу");
                    }
                    else if (dt.Rows.Count == 1)
                    {
                        int employee_id = (int)dt.Rows[0][0];
                        Employee emp = new(employee_id);
                        emp.Show();
                    }
                }
            }
        }
    }
}