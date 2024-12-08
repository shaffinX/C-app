using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TogetherCulture.Search;
using TogetherCulture.TrackEvents;

namespace TogetherCulture
{
    public partial class TrackEventControl : UserControl
    {
        public TrackEventControl()
        {
            InitializeComponent();
        }

        private void searchbyevent_Click(object sender, EventArgs e)
        {
            Track trc = new TrackEvent();
            DataTable alpha = trc.SearchEvent(searchev.Text);
            dataGridView1.DataSource = alpha;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
        }
    }
}
