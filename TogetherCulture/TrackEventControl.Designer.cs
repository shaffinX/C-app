namespace TogetherCulture
{
    partial class TrackEventControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            searchbyevent = new Button();
            searchev = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(90, 212);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(802, 439);
            dataGridView1.TabIndex = 12;
            // 
            // searchbyevent
            // 
            searchbyevent.BackColor = Color.FromArgb(64, 64, 64);
            searchbyevent.Cursor = Cursors.Hand;
            searchbyevent.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchbyevent.ForeColor = Color.Gold;
            searchbyevent.Location = new Point(644, 134);
            searchbyevent.Name = "searchbyevent";
            searchbyevent.Size = new Size(83, 26);
            searchbyevent.TabIndex = 11;
            searchbyevent.Text = "Search";
            searchbyevent.UseVisualStyleBackColor = false;
            searchbyevent.Click += searchbyevent_Click;
            // 
            // searchev
            // 
            searchev.BackColor = Color.WhiteSmoke;
            searchev.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchev.Location = new Point(345, 135);
            searchev.Name = "searchev";
            searchev.PlaceholderText = "Search by Event";
            searchev.Size = new Size(293, 25);
            searchev.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(431, 65);
            label1.Name = "label1";
            label1.Size = new Size(151, 28);
            label1.TabIndex = 9;
            label1.Text = "Track Event";
            // 
            // TrackEventControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(dataGridView1);
            Controls.Add(searchbyevent);
            Controls.Add(searchev);
            Controls.Add(label1);
            Name = "TrackEventControl";
            Size = new Size(983, 717);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button searchbyevent;
        private TextBox searchev;
        private Label label1;
    }
}
