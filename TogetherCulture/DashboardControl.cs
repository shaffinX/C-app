using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TogetherCulture.Dashboard;
using TogetherCulture.Session;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TogetherCulture
{
    public partial class DashboardControl : UserControl
    {
        public DashboardControl()
        {
            InitializeComponent();
            DashContt alpha = new DashContt();
            DataTable ben = alpha.showBenefit(SessionSingleton.Instance.user_id);

            foreach (DataRow row in ben.Rows)
            {
                util.Text = row["benefits_used"].ToString();
                unutil.Text = row["benefits_unutilized"].ToString();
            }

            DataTable evenPrt = alpha.showEvents(SessionSingleton.Instance.user_id);
            dataGridView1.DataSource = evenPrt;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
