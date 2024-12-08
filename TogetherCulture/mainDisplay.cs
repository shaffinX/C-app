using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TogetherCulture
{
    public partial class mainDisplay : Form
    {
        public mainDisplay()
        {
            InitializeComponent();
            containerPanel.Controls.Clear();
            ini();
        }
        public void ini()
        {
            UserControl newControl = (UserControl)Activator.CreateInstance(typeof(LoginControl));
            containerPanel.Controls.Clear();
            newControl.Dock = DockStyle.Fill;
            containerPanel.Controls.Add(newControl);

        }
        private void mainDisplay_Load(object sender, EventArgs e)
        {

        }

        public void LoadUserControl(UserControl newControl)
        {
            containerPanel.Controls.Clear();
            newControl.Dock = DockStyle.Fill;
            containerPanel.Controls.Add(newControl);
        }
    }
}
