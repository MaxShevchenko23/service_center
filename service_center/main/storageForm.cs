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
    public partial class storageForm : Form
    {
        DataTable parts = new();
        DataTable manufacturers = new();
        public storageForm()
        {
            InitializeComponent();
        }

        private void manufacturerCellEdited(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void partsCellEdited(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void manufacturerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new(Helper.dbConnectionString))
            {
                using (SqlCommand cmd = new($@"insert into manufacturers (manufacturer_name) values ('{manufacturerName.Text}');", conn))
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            LoadManufacturers();
        }
        private void LoadManufacturers()
        {
            manufacturers = Helper.ReturnWholeTable(@"select manufacturer_name from manufacturers;");
            manufacturers.Columns[0].ColumnName = "Назва виробника";
            manufacturerGridView.DataSource = manufacturers;

            //идея: при нажатии на ячейку столбца
            //изготовителя (в таблице деталей) показывать контекстное меню с выбором изготовителя. выбранный элемент вносить в таблицу
        }
        private void LoadParts()
        {
            parts = Helper.ReturnWholeTable(@"select * from forStorage;");
            parts.Columns[0].ColumnName = "Назва виробника";
            parts.Columns[1].ColumnName = "Назва деталі";
            parts.Columns[2].ColumnName = "Кількість";
            parts.Columns[3].ColumnName = "Ціна";
            parts.Columns[4].ColumnName = "Стан";

            partsGridView.DataSource = parts;
        }

        private void storageForm_Load(object sender, EventArgs e)
        {
            LoadManufacturers();
            LoadParts();
            partsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            partsGridView.AutoResizeColumns();
            partsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            partsGridView.AutoResizeColumns();
            manufacturerGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            manufacturerGridView.AutoResizeColumns();
            manufacturerGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            manufacturerGridView.AutoResizeColumns();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            newPartForm npf = new();
            npf.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new(Helper.dbConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new($@"update forStorage set part_amount = {textBox1.Text} where manufacturer_name = '{partsGridView.Rows[partsGridView.SelectedRows[0].Index].Cells[0].Value}'", conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                storageForm storage = new();
                Close();
                storage.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void partsGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
