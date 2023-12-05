using Microsoft.Data.SqlClient;
using service_center.admin_forms;
using service_center.functional;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;


namespace service_center.main
{
    public partial class newAdminForm : Form
    {
        SqlConnection conn = new(Helper.dbConnectionString);

        public newAdminForm()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = Helper.ReturnWholeTable(@$"select * from forAdminOrders;");
            dt.Columns[0].ColumnName = "№";
            dt.Columns[1].ColumnName = "Опис";
            dt.Columns[2].ColumnName = "Ім'я клієнта";
            dt.Columns[3].ColumnName = "Ім'я майстра";
            dt.Columns[4].ColumnName = "Статус замовлення";
            dt.Columns[5].ColumnName = "Дата принесення";
            dt.Columns[6].ColumnName = "Дата видачі";
            dataGridView1.DataSource = dt;
        }
        private void showEnumForChosen(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Helper.ReturnWholeTable(@$"select enum_order_id as '№ замовлення', applience_brief_description as 'Опис несправності', part_name as 'Назва запчастини', enum_used_part_amount as 'Використано деталей', service_name as 'Назва послуги' from forAdminEnums where enum_order_id = {functionalBox.Text};");
        }


        private void AdminForm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AutoResizeRows();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from orders", conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void whatUserSeeOn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new(Helper.dbConnectionString))
            {
                conn.Open();
                try
                {
                    functionalLabel.Text = "";
                    string cmd = $"select a.applience_brief_description, o.order_status from orders o left join appliences a on o.order_applience_id=a.applience_id left join clients c on a.applience_client_id=c.client_id where c.client_name = '{functionalBox.Text}'";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd, conn))
                    {
                        DataTable dt = new();
                        adapter.Fill(dt);
                        dt.Columns[0].ColumnName = "Опис";
                        dt.Columns[1].ColumnName = "Статус";
                        dataGridView1.DataSource = dt;

                    }
                }
                catch (Exception)
                {
                    MyMessageBox.Show("Введіть корректне значення!");
                }

            }
        }

        private void newClient(object sender, EventArgs e)
        {
            newClient newClient = new();
            newClient.Show();
        }

        private void newApplience(object sender, EventArgs e)
        {
            createOrderForRegistered forRegistered = new();
            forRegistered.Show();
        }

        private void newEmployee(object sender, EventArgs e)
        {

            addingEmployee add = new();
            add.Show();

        }

        private void newPosition(object sender, EventArgs e)
        {

        }



        private void newPart(object sender, EventArgs e)
        {
            storageForm storage = new();
            storage.Show();
        }

        private void newService(object sender, EventArgs e)
        {
            createServiceForm create = new();
            create.Show();
        }

        private void functionalLabel_Click(object sender, EventArgs e)
        {

        }

        private void whatEmployeeSees(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new(Helper.dbConnectionString))
                {
                    conn.Open();
                    string cmd = $"select a.applience_brief_description,order_given_date from orders o  left join appliences a on o.order_applience_id=a.applience_id left join clients c on a.applience_client_id=c.client_id where o.order_status = 'Прийнято' and order_employee_id is null order by order_given_date asc;";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd, conn))
                    {
                        DataTable dt = new();
                        adapter.Fill(dt);
                        dt.Columns[0].ColumnName = "Опис";
                        dt.Columns[1].ColumnName = "Дата подачі";
                        dataGridView1.DataSource = dt;

                    }
                }
            }
            catch
            {
                MessageBox.Show("Введіть коректне значення");
            }
        }


        private void newOrderFormShow(object sender, EventArgs e)
        {
            createOrderForNonRegistered newOrder = new();
            newOrder.Show();
        }

        private void functionalBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
