using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TogetherCulture.AddMem;
using TogetherCulture.Events;
namespace TogetherCulture
{
    public partial class AddMemControl : UserControl
    {
        public AddMemControl()
        {
            InitializeComponent();
            DisplayAddMem alpha = new DisplayAddMem();
            dataGridView1.DataSource = alpha.Data();
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (userid != null && comboBox1.Text!="")
            {

                int userID = Convert.ToInt32(userid.Text);
                string mem = comboBox1.Text;
                Member tm = new Approve();
                if (tm.approve(userID, mem))
                {
                    MessageBox.Show("User Updated");
                    InitializeComponent();
                }
                else
                {
                    MessageBox.Show("ERROR");
                }
            }
            else
            {
                MessageBox.Show("enter details");
            }
        }

        private void susp_Click(object sender, EventArgs e)
        {

            if (userid != null && comboBox1.Text != "")
            {

                int userID = Convert.ToInt32(userid.Text);
                Member tm = new Suspend();
                if (tm.suspend(userID))
                {
                    MessageBox.Show("Suspended!");
                    InitializeComponent();
                }
                else
                {
                    MessageBox.Show("ERROR");
                }
            }
            else
            {
                MessageBox.Show("enter details");
            }
        }
    }
}
