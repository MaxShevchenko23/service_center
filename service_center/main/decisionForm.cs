using service_center.admin_forms;
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
    public partial class decisionForm : Form
    {
        public decisionForm()
        {
            InitializeComponent();
        }

        private void clientHasAccount(object sender, EventArgs e)
        {
            createOrderForRegistered createOrderForRegistered = new createOrderForRegistered();
            createOrderForRegistered.Show();
        }

        private void clientDoesNotHave(object sender, EventArgs e)
        {
            createOrderForNonRegistered newOrder = new();
            newOrder.Show();
        }
    }
}
