using Microsoft.Data.SqlClient;
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
    public partial class newPartForm : Form
    {
        public newPartForm()
        {
            InitializeComponent();
        }

        private void newPartForm_Load(object sender, EventArgs e)
        {

            DataTable dt = Helper.ReturnWholeTable("select * from manufacturers;");
            dt.Columns[0].ColumnName = "№";
            dt.Columns[1].ColumnName = "Назва виробника";
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AutoResizeRows();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string condition = "";
                if (radioButton1.Checked)
                {
                    condition = "Новий";
                }
                else if (radioButton2.Checked)
                {
                    condition = "Уживаний";
                }
                else
                {
                    throw new Exception("Виберіть стан деталі");
                }

                DataTable manufacturer = Helper.ReturnWholeTable($@"select manufacturer_id from manufacturers where manufacturer_name = '{textBox4.Text}';");

                using (SqlConnection conn = new(Helper.dbConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new($@"insert into parts (part_name,part_manufacturer_id,part_amount,part_price,part_condition) values ('{textBox1.Text}',{textBox4.Text},{textBox2.Text},{textBox3.Text},'{condition}');", conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MyMessageBox.Show(ex.Message);
            }
            finally
            {
                Close();
                newAdminForm adminForm = new();
                adminForm.Show();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
