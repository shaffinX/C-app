using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TogetherCulture.Book_Event;
using TogetherCulture.Session;

namespace TogetherCulture
{
    public partial class EventListControl : UserControl
    {
        public EventListControl()
        {
            InitializeComponent();
            DispEvents alpha = new DispEvents();
            DataTable data = alpha.Display();
            LoadEventList(data);
        }
        private void LoadEventList(DataTable data)
        {
            flowLayoutPanelEvents.Controls.Clear();

            foreach (DataRow row in data.Rows)
            {
                GroupBox eventBox = new GroupBox
                {
                    Text = row["event_name"].ToString(),
                    Width = flowLayoutPanelEvents.Width - 30,
                    Height = 120,
                    Padding = new Padding(10),
                    Margin = new Padding(10),
                    Font = new Font("Arial Rounded MT", 10, FontStyle.Bold)
                };

                Label lblDetails = new Label
                {
                    Text = $"Location: {row["location"]} | Date: {row["event_date"]}",
                    AutoSize = true,
                    Location = new Point(10, 20)
                };

                Label lblDescription = new Label
                {
                    Text = row["description"].ToString(),
                    AutoSize = true,
                    MaximumSize = new Size(eventBox.Width - 150, 0), 
                    Location = new Point(10, 50),
                    Font = new Font("Arial", 10, FontStyle.Regular)

                };
                
                Button btnParticipate = new Button
                {
                    Text = "Participate",
                    Size = new Size(100, 30),
                    Location = new Point(eventBox.Width - 120, 20),
                    Tag = row["event_id"]
                };
                btnParticipate.Click += BtnParticipate_Click;

                eventBox.Controls.Add(lblDetails);
                eventBox.Controls.Add(lblDescription);
                eventBox.Controls.Add(btnParticipate);

                flowLayoutPanelEvents.Controls.Add(eventBox);
            }
        }
        private void BtnParticipate_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton != null && clickedButton.Tag is int eventId)
            {
                int uid = SessionSingleton.Instance.user_id;
                Participate beta = new Participate(eventId, uid);
                if (beta.bookevent())
                {
                    MessageBox.Show($"You have participated in Event ID: {eventId}", "Participation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"You have already participated in Event ID: {eventId}", "Participation Rejected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
