using Microsoft.Data.SqlClient;

namespace service_center.functional
{
    public partial class addingEmployee : Form
    {
        public addingEmployee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new(Helper.dbConnectionString))
            {
                conn.Open();
                string command = "";
                if (Validation.OnlyLetters(nameBox.Text) && Validation.PhoneNumberValidate(phoneBox.Text))
                {
                    try
                    {
                        command = $@"EXEC EmployeeAdd '{nameBox.Text}','{phoneBox.Text}','{PositionChoosing()}', '{loginBox.Text}', '{passwordBox.Text}'";
                        using (SqlCommand cmd = new(command, conn))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        MessageBox.Show(command);

                    }
                    finally
                    {
                        MessageBox.Show("Працівник доданий");
                        Close();
                    }
                }
                else
                    MyMessageBox.Show("Перевірте правильність введених данних");

            }
        }

        private int PositionChoosing()
        {
            if (positionComboBox.SelectedItem.ToString() == "Майстер")
                return 1;
            else if (positionComboBox.SelectedItem.ToString() == "Працівник приймальні")
                return 5;
            else
                return 6;
        }
    }
}
