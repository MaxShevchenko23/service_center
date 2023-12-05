using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace service_center.functional
{
    public partial class Call : Form
    {
        string name;
        string PhoneNumber;
        public Call(string name, string phoneNumber)
        {
            InitializeComponent();
            this.name = name;
            PhoneNumber = phoneNumber;
        }

        private void Call_Load(object sender, EventArgs e)
        {
            nameLabel.Text = name;
            phoneNumberLabel.Text = PhoneNumber;
        }
    }
}
