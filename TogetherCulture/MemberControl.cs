using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TogetherCulture.Session;

namespace TogetherCulture
{
    public partial class MemberControl : UserControl
    {
        public MemberControl()
        {
            InitializeComponent();
            String f = SessionSingleton.Instance.firstname;
            string l = SessionSingleton.Instance.lastname;
            greet.Text = "Hello! " + f + " " + l;
            titleLbl.Text = f + " " + l;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            screen.Controls.Clear();
            UserControl newControl = (UserControl)Activator.CreateInstance(typeof(EventListControl));
            newControl.Dock = DockStyle.Fill;
            screen.Controls.Add(newControl);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            screen.Controls.Clear();
            UserControl newControl = (UserControl)Activator.CreateInstance(typeof(ProfileControl));
            newControl.Dock = DockStyle.Fill;
            screen.Controls.Add(newControl);
        }
        private mainDisplay FindMainDisplay()
        {
            Control parent = this.Parent;
            while (parent != null && !(parent is mainDisplay))
            {
                parent = parent.Parent;
            }
            return parent as mainDisplay;
        }
        private void logout_Click(object sender, EventArgs e)
        {
            mainDisplay k = FindMainDisplay();
            k.ini();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            screen.Controls.Clear();
            UserControl newControl = (UserControl)Activator.CreateInstance(typeof(DashboardControl));
            newControl.Dock = DockStyle.Fill;
            screen.Controls.Add(newControl);
        }
    }
}
