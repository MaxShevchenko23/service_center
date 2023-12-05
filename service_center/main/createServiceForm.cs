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
    public partial class createServiceForm : Form
    {
        public createServiceForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(SqlConnection conn = new(Helper.dbConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new($@"insert into service_center.dbo.services (service_name, service_price) values ('{textBox1.Text}',{textBox2.Text});",conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            Close();
        }
    }
}
