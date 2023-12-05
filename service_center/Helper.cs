using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace service_center
{
    public static class Helper
    {
        public static string dbConnectionString = @"Data Source=DESKTOP-KKLFTJP;Initial Catalog=service_center;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        public static string FormalInfo = $"Назва організації:\n" + $"ІНН:\n" + $"Адреса:\n" + $"Телефон:\n";
        public static void UnknownErrorMessage()
        {
            MessageBox.Show("Сталася невідома помилка", "Помилка",MessageBoxButtons.OK);
        }
        public static DataTable ReturnWholeTable(string querryString)
        {
            DataTable data = new DataTable();
            using (SqlConnection conn = new SqlConnection(dbConnectionString))
            {
                conn.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(querryString, conn))
                {
                    adapter.Fill(data);
                }
            }
            return data;
        }
        public static bool IsQueryWorks(string queryString)
        {
            try
            {
                if (ReturnWholeTable(queryString).Rows.Count >= 0)
                    return true;
                else
                    return false;
            }
            catch(Exception)
            {
                return false;
            }
            
        }
        public static void RefreshDataGridViews(Form form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is DataGridView)
                {
                    DataGridView dgv = (DataGridView)control;
                    dgv.Refresh();
                }
            }
        }


    }
}
