using Microsoft.Data.SqlClient;
using service_center.main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace service_center.functional.forEmployee
{
    public partial class addingServicesForm : Form
    {
        int order_id;
        int employee_id;
        int timeAmount;
        bool doTime = true;
        void TimeMeasuring()
        {
            timeAmount = 0;
            while (doTime)
            {
                timeAmount++;
                Thread.Sleep(100);
            }
            
        }

        public addingServicesForm(int order_id, int employee_id)
        {

            
            InitializeComponent();
            TimeAndDate();
            this.order_id = order_id;
            this.employee_id = employee_id;
        }

        private void addingServicesForm_Load(object sender, EventArgs e)
        {
            LoadInfoToGridView();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoResizeColumns();
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView2.AutoResizeColumns();
        }
        private void SetWidth(DataGridView dgv, int size)
        {
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                column.Width = size;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

        }
        public async void LoadInfoToGridView()
        {
            
            LoadServicesAsync();
            LoadPartsAsync();
            SetDescription();

        }

        public async void LoadServicesAsync()
        {
            DataTable services = new();

            await Task.Run(() =>
            {
                services = Helper.ReturnWholeTable(@"select * from service_center.dbo.services;");
                services.Columns[0].ColumnName = "№";
                services.Columns[1].ColumnName = "Назва";
                services.Columns[2].ColumnName = "Ціна";
                services.Columns[0].ColumnName = "№";
            });
            dataGridView1.DataSource = services;

        }
        public async void LoadPartsAsync()
        {
            DataTable parts = new();

            await Task.Run(() =>
            {
                parts = Helper.ReturnWholeTable(@"select * from parts;");
                parts.Columns[0].ColumnName = "№";
                parts.Columns[1].ColumnName = "Назва";
                parts.Columns[2].ColumnName = "Виробник";
                parts.Columns[3].ColumnName = "Кількість в наявності";
                parts.Columns[4].ColumnName = "Ціна";
                parts.Columns[5].ColumnName = "Стан";
            });
            dataGridView2.DataSource = parts;

        }

        public async void SetDescription()
        {
            DataTable descr = new();
            await Task.Run(() =>
            {
                using (SqlConnection con = new SqlConnection(Helper.dbConnectionString))
                {
                    con.Open();
                    SqlDataAdapter servicesAdapter = new SqlDataAdapter(@$"select applience_brief_description from toGetDescription 
                                                                    where order_id ={order_id};", con);
                    servicesAdapter.Fill(descr);
                }
            });
            descriptionBox.Text = $"Опис: {descr.Rows[0][0]}";
        }
        private void TimeAndDate()
        {   //timer
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += (sender, e) => timeBox.Text = $"{DateTime.Now} \n{DateTime.Today.DayOfWeek}";

            timer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Call call = new Call("", "");
            call.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DataGridViewRow selected_service = dataGridView1.SelectedRows[0];
            DataGridViewRow selected_part = dataGridView2.SelectedRows[0];

            int service_id = (int)selected_service.Cells[0].Value;
            string service_name = (string)selected_service.Cells[1].Value;

            int part_id = (int)selected_part.Cells[0].Value;
            string part_name = (string)selected_part.Cells[1].Value;
            int part_amount = (int)selected_part.Cells[3].Value;

            acceptingServicesAndPartsForm asap = new(service_id,
                                                     part_id,
                                                     service_name,
                                                     part_name,
                                                     order_id,
                                                     part_amount, employee_id);
            asap.Show();
            Close();
        }
        private void finishOrder(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Helper.dbConnectionString))
            {
                SqlCommand cmd = new(@$"update orders set order_status='Завершено' where order_id={order_id};", con);
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Employee emp = new(employee_id);
                    Close();
                    emp.Show();
                }

            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void descriptionBox_Click(object sender, EventArgs e)
        {

        }

        private void timeBox_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
