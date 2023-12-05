using Microsoft.Data.SqlClient;
using service_center.functional;
using service_center.functional.forEmployee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace service_center.main
{
    public partial class Employee : Form
    {
        int employee_id;
        public Employee(int employee_id)
        {
            InitializeComponent();
            this.employee_id = employee_id;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadDelete();
        }

        public void LoadDelete()
        {
            try
            {
                Delete del = new(@"select o.order_applience_id,a.applience_brief_description, o.order_given_date 
                                   from orders o left join appliences a on o.order_applience_id=a.applience_id 
                                   left join clients c on a.applience_client_id=c.client_id 
                                   where o.order_status = 'Прийнято' and order_employee_id is null;",
                                   employee_id: employee_id);
                del.Show();
                Close();
            }
            catch
            {
                Helper.UnknownErrorMessage();
            }
            finally
            {

            }
        }
        public void LoadCall()
        {
            DataTable dt = new();
            try
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index];
                int applience_id = (int)selectedRow.Cells[0].Value;

                using (SqlConnection conn = new(Helper.dbConnectionString))
                {
                    using (SqlDataAdapter adapter = new(@$"select client_name,client_phone_number from toGetPhoneNumber where order_applience_id = {applience_id}", conn))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MyMessageBox.Show(ex.Message);
            }
            finally
            {
                Call call = new(name: dt.Rows[0][0].ToString(), phoneNumber: dt.Rows[0][1].ToString());
                call.Show();
            }
        }
        public void LoadPayForm()
        {
          
        }

        private async void AddToWork(object sender, EventArgs e)
        {
            string insertSql = $@"update orders
                                    set order_employee_id = @value1 where order_applience_id = @value2;";

            using (SqlConnection con = new(Helper.dbConnectionString))
            {
                await con.OpenAsync();
                using (SqlCommand command = new SqlCommand(insertSql, con))
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index];
                    int id = (int)selectedRow.Cells[0].Value;

                    command.Parameters.AddWithValue("@value1", employee_id);
                    command.Parameters.AddWithValue("@value2", id);
                    command.ExecuteNonQuery();
                }
                dataGridView2.DataSource = null;
                string cmd = $@"select order_applience_id,applience_brief_description,order_given_date from forEmployeesUsing where order_employee_id = {employee_id}";
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd, con))
                {
                    DataSet data = new DataSet();
                    adapter.Fill(data);
                    dataGridView2.DataSource = data.Tables[0];

                }
                LoadOrdersOnWaiting();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadCall();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            LoadOrdersOnWaiting();
            LoadOrdersInProccess();
            SetWidth(dataGridView1);
            SetWidth(dataGridView2);
            Text = $"Працівник №{employee_id}";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoResizeColumns();
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView2.AutoResizeColumns();
        }
        private void LoadOrdersOnWaiting()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new(Helper.dbConnectionString))
            {
                string cmd = $"select order_applience_id,applience_brief_description,order_given_date from forEmployeesUsing where order_employee_id is null and order_status = 'Прийнято';";
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd, conn))
                {
                    adapter.Fill(dt);
                }
            }
            dt.Columns[0].ColumnName = "Номер техніки";
            dt.Columns[1].ColumnName = "Опис поломки";
            dt.Columns[2].ColumnName = "Дата подачі";
            dataGridView1.DataSource = dt;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }
        private void LoadOrdersInProccess()
        {
            DataTable dt = new();
            string cmd = $@"select order_applience_id,applience_brief_description,order_given_date from forEmployeesUsing where order_employee_id = {employee_id}
                           and order_status = 'Прийнято'";
            using (SqlConnection con = new(Helper.dbConnectionString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd, con))
                {

                    adapter.Fill(dt);
                }
            }
            dt.Columns[0].ColumnName = "Номер техніки";
            dt.Columns[1].ColumnName = "Опис поломки";
            dt.Columns[2].ColumnName = "Дата подачі";

            dataGridView2.DataSource = dt;
            dataGridView2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;



        }

        private void SetWidth(DataGridView dgv)
        {
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                column.Width = 150;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
        private void StartWorking(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView2.Rows[dataGridView2.SelectedRows[0].Index];
            int id = (int)selectedRow.Cells[0].Value;
            addingServicesForm asf = new(id - 1, employee_id);
            asf.Show();
            Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            preCountingForm form = new();
            form.Show();
        }
    }
}
