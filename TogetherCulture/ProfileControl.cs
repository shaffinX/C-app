using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TogetherCulture.Profile;
using TogetherCulture.Session;

namespace TogetherCulture
{
    public partial class ProfileControl : UserControl
    {
        public ProfileControl()
        {
            InitializeComponent();
            int uid = SessionSingleton.Instance.user_id;
            ProfileView data = new ProfileView();
            dataGridView1.DataSource = data.profileinfo(uid);
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
        }

        private void ProfileControl_Load(object sender, EventArgs e)
        {

        }

        private void passwordbutt_Click(object sender, EventArgs e)
        {
            if (pass.Text != "")
            {
                if (pass.Text.Length >= 8)
                {
                    UpdateUser passw = new PassUpd();
                    int uid = SessionSingleton.Instance.user_id;
                    if (passw.changePass(uid, pass.Text))
                    {
                        MessageBox.Show("Password Changed Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Server Error");
                    }
                }
                else
                {
                    MessageBox.Show("Password Must be atleast 8 characters long");
                }
            }
            else
            {
                MessageBox.Show("Please Enter a password");
            }
        }

        private void changeinter_Click(object sender, EventArgs e)
        {
            if (inter.Text != "")
            {
                UpdateUser abc = new InterUpd();
                int uid = SessionSingleton.Instance.user_id;
                if (abc.changeInterest(uid, inter.Text))
                {
                    MessageBox.Show("Interests Changed Successfully");
                }
                else
                {
                    MessageBox.Show("Server Error");
                }
            }
            else
            {
                MessageBox.Show("Please Enter in the field");
            }
        }
    }
}
