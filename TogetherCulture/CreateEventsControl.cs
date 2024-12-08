using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TogetherCulture.Events;

namespace TogetherCulture
{
    public partial class CreateEventsControl : UserControl
    {
        public CreateEventsControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ename.Text != "" && elocat.Text != "" && desc.Text != "" && dateTimePicker1.Checked != false)
            {
                string date = dateTimePicker1.Value.Date.ToString();
                string time = dateTimePicker1.Value.TimeOfDay.ToString();
                Event a = new CreateEvent();
                if (a.create(ename.Text, elocat.Text, desc.Text, date, time)) {
                    MessageBox.Show("Event Created Successfully!");
                }
                else
                {
                    MessageBox.Show("Error In Creating Event");
                }
            }
            else
            {
                MessageBox.Show("Enter all details");
            }
        }
    }
}
