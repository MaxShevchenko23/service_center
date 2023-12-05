using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Diagnostics;
using service_center.main;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace service_center.functional
{


    public partial class Delete : Form
    {

        int employee_id;
        string cmd;


        public Delete(string command, int employee_id = 0)
        {
            InitializeComponent();
            cmd = command;
            this.employee_id = employee_id;

        }

        private async void forEmployee()
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index];
                int id = (int)selectedRow.Cells[0].Value;

                string insertSql = $@"update orders set order_status = 'Відхилено' where order_applience_id = @value1;
                                     insert into declines values(@value1,@value2);";

                using SqlConnection conn = new SqlConnection(Helper.dbConnectionString);
                await conn.OpenAsync();
                using (SqlCommand command = new SqlCommand(insertSql, conn))
                {
                    command.Parameters.AddWithValue("@value1", id);
                    command.Parameters.AddWithValue("@value2", textBox1.Text);
                    command.ExecuteNonQuery();
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ds.Tables[0];
                Employee emp = new(employee_id);
                emp.Show();
                Close();
            }
        }




        DataSet ds = new DataSet();
        public async void Connect(string cmd)
        {
            DataTable dt = new();
            try
            {
                using SqlConnection con = new SqlConnection(Helper.dbConnectionString);
                await con.OpenAsync();
                using SqlDataAdapter adapter = new SqlDataAdapter(cmd, con);
                adapter.Fill(ds);
                dt = ds.Tables[0];
                dt.Columns[0].ColumnName = "№";
                dt.Columns[1].ColumnName = "Опис";
                dt.Columns[2].ColumnName = "Дата подачі";
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Delete_Load(object sender, EventArgs e)
        {
            Connect(cmd);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoResizeColumns();


        }

        private void declineServiceButton(object sender, EventArgs e)
        {
            forEmployee();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
