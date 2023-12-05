using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace service_center.functional.forEmployee
{
    public partial class preCountingForm : Form
    {

        decimal sumParts, sumServices, totalSum;
        public preCountingForm()
        {
            InitializeComponent();
        }

        private void preCountingForm_Load(object sender, EventArgs e)
        {
            parts.DataSource = Helper.ReturnWholeTable(@$"select  manufacturer_name as 'Виробник',part_name as 'Назва', part_price as 'Виробник' from parts p left join manufacturers m on p.part_manufacturer_id = m.manufacturer_id;");
            services.DataSource = Helper.ReturnWholeTable(@$"select service_name as 'Назва',service_price as 'Ціна' from services;");
            parts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            parts.AutoResizeColumns();
            services.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            services.AutoResizeColumns();


            partsToCount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            partsToCount.AutoResizeColumns();
            servicesToCount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            servicesToCount.AutoResizeColumns();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in parts.SelectedRows)
            {
                object[] items = new object[row.Cells.Count];
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    items[i] = row.Cells[i].Value;
                }
                partsToCount.Rows.Add(items);
                Counting();
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in services.SelectedRows)
            {
                object[] items = new object[row.Cells.Count];
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    items[i] = row.Cells[i].Value;
                }
                servicesToCount.Rows.Add(items);
                Counting();
            }
        }
        private void Counting()
        {
            sumParts = 0;
            sumServices = 0;


        }
        private void partsToCount_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                sumParts = 0;
                sumServices = 0;


                for (int i = 0; i < partsToCount.Rows.Count - 1; i++)
                {
                    if (partsToCount.Rows[i].Cells[2] != null)
                    {
                        sumParts += (decimal)partsToCount.Rows[i].Cells[2].Value;
                    }
                }
                for (int i = 0; i < servicesToCount.Rows.Count - 1; i++)
                {
                    if (servicesToCount.Rows[i].Cells[1] != null)
                    {
                        sumServices += (decimal)servicesToCount.Rows[i].Cells[1].Value;
                    }
                }
                label1.Text = @$"Загальна сума =  {sumParts + sumServices}";
            }
            catch (Exception ex)
            {
                MyMessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sumParts = 0;
                sumServices = 0;


                for (int i = 0; i < partsToCount.Rows.Count - 1; i++)
                {
                    if (partsToCount.Rows[i].Cells[2] != null)
                    {
                        sumParts += (decimal)partsToCount.Rows[i].Cells[2].Value;
                    }
                }
                for (int i = 0; i < servicesToCount.Rows.Count - 1; i++)
                {
                    if (servicesToCount.Rows[i].Cells[1] != null)
                    {
                        sumServices += (decimal)servicesToCount.Rows[i].Cells[1].Value;
                    }
                }
                label1.Text = @$"Загальна сума =  {sumParts + sumServices}";
            }
            catch (Exception ex)
            {
                MyMessageBox.Show(ex.Message);
            }
        }

        private void servicesToCount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void servicesToCount_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                sumParts = 0;
                sumServices = 0;


                for (int i = 0; i < partsToCount.Rows.Count - 1; i++)
                {
                    if (partsToCount.Rows[i].Cells[2] != null)
                    {
                        sumParts += (decimal)partsToCount.Rows[i].Cells[2].Value;
                    }
                }
                for (int i = 0; i < servicesToCount.Rows.Count - 1; i++)
                {
                    if (servicesToCount.Rows[i].Cells[1] != null)
                    {
                        sumServices += (decimal)servicesToCount.Rows[i].Cells[1].Value;
                    }
                }
                label1.Text = @$"Загальна сума =  {sumParts + sumServices}";
            }
            catch (Exception ex)
            {
                MyMessageBox.Show(ex.Message);
            }
        }
    }
}
