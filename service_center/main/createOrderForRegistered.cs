using Microsoft.Data.SqlClient;
using System.Data;

namespace service_center.main
{
    public partial class createOrderForRegistered : Form
    {


        public createOrderForRegistered()
        {
            InitializeComponent();
        }

        DataTable dt = new();
        private void createOrderForRegistered_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new(Helper.dbConnectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("select client_id, client_name,client_doc from clients", conn);
                adapter.Fill(dt);
                dt.Columns[0].ColumnName = "№";
                dt.Columns[1].ColumnName = "Ім'я клієнта";
                dt.Columns[2].ColumnName = "Документ клієнта";
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].Width = 40;
                dataGridView1.Columns[1].Width = 300;
                dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new(Helper.dbConnectionString))
                {
                    conn.Open();
                    if (dataGridView1.SelectedRows.Count != 0 && textBox1.Text != "")
                    {
                        DataGridViewRow selectedRow = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index];
                        int id = (int)selectedRow.Cells[0].Value;

                        string insertSql = $@"insert into appliences(applience_client_id,applience_brief_description) values (@value1,@value2)";

                        using (SqlCommand command = new SqlCommand(insertSql, conn))
                        {
                            command.Parameters.AddWithValue("@value1", id);
                            command.Parameters.AddWithValue("@value2", textBox1.Text);
                            command.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MyMessageBox.Show($"Щось сталося...\n Оберіть клієнта та введіть опис поломки");
            }
            finally
            {
                Close();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FilterDataGridView(string filterValue)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection conn = new(Helper.dbConnectionString))
            {
                SqlDataAdapter adapter = new($@"select client_id, client_name from clients
                                               where client_id like '%{textBox2.Text}%'
                                               or client_name like '%{textBox2.Text}%'
                                               or client_doc like '%{textBox2.Text}%'", conn);
                adapter.Fill(dataTable);
                dataTable.Columns[0].ColumnName = "№";
                dataTable.Columns[1].ColumnName = "Ім'я";
                dataGridView1.DataSource = dataTable;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView1.AutoResizeColumns();
                
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
                dataGridView1.DataSource = dt;
            else
                FilterDataGridView(textBox2.Text);
        }

       
    }
}
