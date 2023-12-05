using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;

namespace service_center.main
{
    public partial class ReceptionistForm : Form
    {
        public ReceptionistForm()
        {
            InitializeComponent();
            TimeAndDate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decisionForm df = new();
            df.Show();
        }

        private void ReceptionistForm_Load(object sender, EventArgs e)
        {

        }
        private void TimeAndDate()
        {   //timer
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += (sender, e) => timeBox.Text = $"{DateTime.Now} \n{DateTime.Today.DayOfWeek}";

            timer.Start();
        }

        private void handOutOrder(object sender, EventArgs e)
        {
            examinationForm form = new();
            form.Show();
        }
    }
}
