using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace service_center.functional
{
    public partial class examinationVisualising : Form
    {
        int order_id;
        string declineReason,agent;


        public examinationVisualising(int order_id,string declineReason = "")
        {
            InitializeComponent();
            this.order_id = order_id;
            this.declineReason = declineReason;
        }

        private void examinationVisualising_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            WriteChanges(Helper.FormalInfo);

            DataTable dt = new();
            using (SqlConnection conn = new(Helper.dbConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new($@"update forComposingTheReceipt set order_handed_date=CONVERT(date, GETDATE()) 
                                              where order_id={order_id};", conn))
                {
                    cmd.ExecuteNonQuery();
                }
                using (SqlDataAdapter adapter = new($@"select 
                                                      client_name,
                                                      order_id,
                                                      applience_brief_description,
                                                      employee_name,
                                                      service_name,
                                                      service_price,
                                                      part_name,
                                                      part_price,
                                                      enum_used_part_amount,
                                                      service_price+part_price*enum_used_part_amount as 'total sum',
                                                      order_given_date,
                                                      order_handed_date
                                                      from forComposingTheReceipt where order_id={order_id};", conn))
                {
                    adapter.Fill(dt);
                }
            }

            try
            {
                WriteChanges($@"Замовлення #{dt.Rows[0][1]}"
                                + $"\nОпис замовлення: {dt.Rows[0][2]}"
                                + $"\nКлієнт: {dt.Rows[0][0]}"
                                + $"\nМайстер: {dt.Rows[0][3]}");
                if (declineReason != "")
                    WriteChanges($"\nПричина відмови: {declineReason}");
            }
            catch (Exception ex)
            {
                MyMessageBox.Show(ex.Message);
            }
            if(dt.Rows.Count == 1)
            {
                WriteChanges($"\n\t\tПерелік послуг");
                foreach (DataRow dr in dt.Rows)
                {
                    WriteChanges($"\nПослуга:  {dr[4]} \t X \t {dr[5]}" +
                                 $"\nВикористана деталь : {dr[6]} X {dr[8]} {dr[7]}");
                }
            }
           
            decimal totalSum = 0;
            foreach (DataRow dr in dt.Rows)
            {
                totalSum += (decimal)dr[9];
            }
            WriteChanges($"\nДата подачі: {dt.Rows[0][10]}");
            WriteChanges($"\nДата видачі: {dt.Rows[0][11]}");
            WriteChanges($"\nСума до сплати: {totalSum} грн.");
        }

        //private void WriteChanges(string agent)
        //{

        //    try
        //    {
        //        string path = @$"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\receipt";
        //        using (StreamWriter writer = new StreamWriter(path, true))
        //        {
        //            writer.WriteLine(agent);
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void WriteChanges(string agent)
        {
            try
            {
                this.agent += agent;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show(this.agent);
        }
    }
}
