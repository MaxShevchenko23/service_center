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

namespace service_center.functional.forEmployee
{

    public partial class acceptingServicesAndPartsForm : Form
    {

        int service_id;
        int part_id;
        int part_amount;
        string service_name;
        string part_name;
        int order_id;
        int employee_id;
        public acceptingServicesAndPartsForm(int service_id, int part_id,
                                             string service_name, string part_name,
                                             int order_id,
                                             int part_amount, int employee_id)
        {
            this.service_id = service_id;
            this.part_id = part_id;
            this.service_name = service_name;
            this.part_name = part_name;
            this.part_amount = part_amount;
            this.order_id = order_id;
            this.employee_id = employee_id;
            InitializeComponent();
        }

        private void acceptingServicesAndPartsForm_Load(object sender, EventArgs e)
        {
            serviceLabel.Text = @$"Послуга: {service_name}";
            partLabel.Text = @$"Деталь: {part_name}";
            label2.Text = $@"Залишилося : {part_amount}";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(textBox1.Text, out int a) || textBox1.Text == "")
                {
                    throw new Exception("Введіть числове значення");          
                }
                if (a > part_amount)
                {
                    throw new Exception("Кількість використаних деталей більша ніж у наявності");
                }
            }
            catch(Exception ex)
            {
                MyMessageBox.Show(ex.Message);
                textBox1.ForeColor = Color.Red;
            }
            finally
            {
                try
                {
                    using (SqlConnection conn = new(Helper.dbConnectionString))
                    {
                        conn.Open();
                        SqlCommand cmd = new(@$"insert into enums(enum_order_id,enum_service_id, enum_used_part_id,enum_used_part_amount) values (@value1,@value2,@value3,@value4)");
                        cmd.Connection = conn;
                        cmd.Parameters.AddWithValue("@value1", order_id);
                        cmd.Parameters.AddWithValue("@value2", service_id);
                        cmd.Parameters.AddWithValue("@value3", part_id);
                        cmd.Parameters.AddWithValue("@value4", Convert.ToInt16(textBox1.Text));
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MyMessageBox.Show(ex.Message);
                }
                finally
                {
                    int countHowManyLeft = part_amount - Convert.ToInt32(textBox1.Text);
                    using (SqlConnection conn = new(Helper.dbConnectionString))
                    {
                        conn.Open();
                        SqlCommand cmd = new(@$"update parts set part_amount = {countHowManyLeft} where part_id={part_id}", conn);
                        cmd.ExecuteNonQuery();
                    }
                    addingServicesForm asf = new(order_id, employee_id);
                    asf.Show();
                    Close();
                }
            }
        }
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (!int.TryParse(textBox1.Text, out _))
        //        {
        //            throw new FormatException();
        //        }
        //        else if ()
        //        {

        //        }

        //    }
        //    catch (FormatException)
        //    {
        //        MyMessageBox.Show("Введіть кількість використаних запчастин");
        //        textBox1.ForeColor = Color.Red;
        //    }
        //    finally
        //    {
        //        try
        //        {
        //            using (SqlConnection conn = new(Helper.dbConnectionString))
        //            {
        //                conn.Open();
        //                SqlCommand cmd = new(@$"insert into enums(enum_order_id,enum_service_id, enum_used_part_id,enum_used_part_amount) values (@value1,@value2,@value3,@value4)");
        //                cmd.Connection = conn;
        //                cmd.Parameters.AddWithValue("@value1", order_id - 1);
        //                cmd.Parameters.AddWithValue("@value2", service_id);
        //                cmd.Parameters.AddWithValue("@value3", part_id);
        //                cmd.Parameters.AddWithValue("@value4", Convert.ToInt16(textBox1.Text));
        //                cmd.ExecuteNonQuery();
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MyMessageBox.Show(ex.Message);
        //        }
        //        finally
        //        {
        //            if (Convert.ToInt32(textBox1.Text) > part_amount)
        //            {
        //                MyMessageBox.Show("Перевірте кількість введених деталей!");
        //                textBox1.ForeColor = Color.Red;
        //            }
        //            else
        //            {
        //                int countHowManyLeft = part_amount - Convert.ToInt32(textBox1.Text);
        //                using (SqlConnection conn = new(Helper.dbConnectionString))
        //                {
        //                    conn.Open();
        //                    SqlCommand cmd = new(@$"update parts set part_amount = {countHowManyLeft} where part_id={part_id}", conn);
        //                    cmd.ExecuteNonQuery();
        //                }
        //                addingServicesForm asf = new(order_id, employee_id);
        //                asf.Show();
        //                Close();
        //            }
        //        }
        //    }
        //}
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Black;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
