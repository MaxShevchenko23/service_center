using Microsoft.Data.SqlClient;
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

namespace service_center.main
{
    public partial class examinationForm : Form
    {

        public examinationForm()
        {
            InitializeComponent();

        }

        DataTable dt = new();
        private void examinationForm_Load(object sender, EventArgs e)
        {

            try
            {
                dt = Helper.ReturnWholeTable($@"select order_id, applience_brief_description, client_name, order_status,decline_describtion from finishedOrders 
                                                left join declines on finishedOrders.applience_id = declines.decline_applience_id;");
                dt.Columns[0].ColumnName = "№";
                dt.Columns[1].ColumnName = "Опис";
                dt.Columns[2].ColumnName = "Ім'я";
                dt.Columns[3].ColumnName = "Статус";
                dt.Columns[4].ColumnName = "Причина відмови";
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].Width = 45;
                dataGridView1.Columns[1].Width = 400;
                dataGridView1.Columns[2].Width = 150;
                dataGridView1.Columns[3].Width = 200;
                dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView1.AutoResizeColumns();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int order_id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            string declineReason = "";
            try
            {
                declineReason = (string)dataGridView1.SelectedRows[0].Cells[4].Value;
            }
            catch (Exception)
            {

            }
            finally
            {
                examinationVisualising form = new examinationVisualising(order_id, declineReason);
                form.Show();
            }

        }


        // Assuming you have a DataGridView called dataGridView1 and a TextBox called textBox1

        // Method to filter the DataGridView based on the entered value
        private void FilterDataGridView(string filterValue)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection conn = new(Helper.dbConnectionString))
            {
                SqlDataAdapter adapter = new($@"select order_id, applience_brief_description, client_name, order_status,decline_describtion from finishedOrders
                                                left join declines on finishedOrders.applience_id = declines.decline_applience_id 
                                                where order_id LIKE '%{textBox1.Text}%' or
                                                applience_brief_description LIKE '%{textBox1.Text}%' or client_name LIKE '%{textBox1.Text}%' or order_status LIKE '%{textBox1.Text}%' or decline_describtion LIKE '%{textBox1.Text}%' or client_doc like '%{textBox1.Text}%'", conn);
                adapter.Fill(dataTable);
                dataTable.Columns[0].ColumnName = "№";
                dataTable.Columns[1].ColumnName = "Опис";
                dataTable.Columns[2].ColumnName = "Ім'я";
                dataTable.Columns[3].ColumnName = "Статус";
                dataTable.Columns[4].ColumnName = "Причина відмови";
                dataTable.Columns[5].ColumnName = "Номер документу";

                dataGridView1.DataSource= dataTable;
            }

        }

        // Event handler for the TextBox's TextChanged event
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                dataGridView1.DataSource = dt;
            else
                FilterDataGridView(textBox1.Text);
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
