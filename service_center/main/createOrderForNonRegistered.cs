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

namespace service_center.admin_forms
{
    public partial class createOrderForNonRegistered : Form
    {
        public createOrderForNonRegistered()
        {
            InitializeComponent();
        }

        private void newOrder_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validation.OnlyLetters(nameBox.Text) && Validation.PhoneNumberValidate(phoneBox.Text) && Validation.PassportID(docBox.Text))
                using (SqlConnection conn = new(Helper.dbConnectionString))
                {
                    conn.Open();
                    string insertSql = $@"EXEC ClientAdd '{nameBox.Text}','{phoneBox.Text}','{docBox.Text}','{descBox.Text}'";
                    using (SqlCommand command = new SqlCommand(insertSql, conn))
                    {
                        command.ExecuteNonQuery();
                    }
                    Close();
                }
            else
                MyMessageBox.Show("Перевірте правильність набору");
        }
    }
}
