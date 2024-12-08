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
    public partial class AdminControl : UserControl
    {
        public AdminControl()
        {
            InitializeComponent();
            String f = SessionSingleton.Instance.firstname;
            string l = SessionSingleton.Instance.lastname;
            titleLbl.Text = f + " " + l;
        }

        private void AdminControl_Load(object sender, EventArgs e)
        {

        }

        private void addmem_Click(object sender, EventArgs e)
        {
            screen.Controls.Clear();
            UserControl newControl = (UserControl)Activator.CreateInstance(typeof(AddMemControl));
            newControl.Dock = DockStyle.Fill;
            screen.Controls.Add(newControl);
        }

        private void createev_Click(object sender, EventArgs e)
        {
            screen.Controls.Clear();
            UserControl newControl = (UserControl)Activator.CreateInstance(typeof(CreateEventsControl));
            newControl.Dock = DockStyle.Fill;
            screen.Controls.Add(newControl);
        }

        private void search_Click(object sender, EventArgs e)
        {
            screen.Controls.Clear();
            UserControl newControl = (UserControl)Activator.CreateInstance(typeof(SearchControl));
            newControl.Dock = DockStyle.Fill;
            screen.Controls.Add(newControl);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            screen.Controls.Clear();
            UserControl newControl = (UserControl)Activator.CreateInstance(typeof(AnalyzeControl));
            newControl.Dock = DockStyle.Fill;
            screen.Controls.Add(newControl);

        }

        private void track_Click(object sender, EventArgs e)
        {
            screen.Controls.Clear();
            UserControl newControl = (UserControl)Activator.CreateInstance(typeof(TrackEventControl));
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

        private void label4_Click(object sender, EventArgs e)
        {
            screen.Controls.Clear();
            UserControl newControl = (UserControl)Activator.CreateInstance(typeof(ProfileAdminControl));
            newControl.Dock = DockStyle.Fill;
            screen.Controls.Add(newControl);
        }
    }
}
