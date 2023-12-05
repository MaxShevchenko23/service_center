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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace service_center.admin_forms
{
    public partial class newClient : Form
    {
        public newClient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validation.OnlyLetters(nameBox.Text) && Validation.PhoneNumberValidate(phoneBox.Text) && Validation.PassportID(docBox.Text))
            {
                using (SqlConnection conn = new(@"Data Source=DESKTOP-KKLFTJP;Initial Catalog=service_center;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"))
                {
                    conn.Open();
                    string insertSql = "insert into clients(client_name,client_phone_number,client_doc) values(@value1,@value2,@value3)";
                    using (SqlCommand command = new SqlCommand(insertSql, conn))
                    {
                        command.Parameters.AddWithValue("@value1", nameBox.Text);
                        command.Parameters.AddWithValue("@value2", phoneBox.Text);
                        command.Parameters.AddWithValue("@value3", docBox.Text);
                        command.ExecuteNonQuery();
                    }
                }
            }
            else
                MyMessageBox.Show("Перевірте правильність введених данних");
        }

        private void newClient_Load(object sender, EventArgs e)
        {

        }
    }
}
