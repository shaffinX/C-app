namespace TogetherCulture
{
    partial class SearchControl
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            searchnm = new TextBox();
            searchbyname = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(434, 56);
            label1.Name = "label1";
            label1.Size = new Size(95, 28);
            label1.TabIndex = 0;
            label1.Text = "Search";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(80, 203);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(802, 439);
            dataGridView1.TabIndex = 8;
            // 
            // searchnm
            // 
            searchnm.BackColor = Color.WhiteSmoke;
            searchnm.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchnm.Location = new Point(335, 126);
            searchnm.Name = "searchnm";
            searchnm.PlaceholderText = "Search by Member";
            searchnm.Size = new Size(293, 25);
            searchnm.TabIndex = 2;
            // 
            // searchbyname
            // 
            searchbyname.BackColor = Color.FromArgb(64, 64, 64);
            searchbyname.Cursor = Cursors.Hand;
            searchbyname.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchbyname.ForeColor = Color.Gold;
            searchbyname.Location = new Point(634, 125);
            searchbyname.Name = "searchbyname";
            searchbyname.Size = new Size(83, 26);
            searchbyname.TabIndex = 6;
            searchbyname.Text = "Search";
            searchbyname.UseVisualStyleBackColor = false;
            searchbyname.Click += searchbyname_Click;
            // 
            // SearchControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(dataGridView1);
            Controls.Add(searchbyname);
            Controls.Add(searchnm);
            Controls.Add(label1);
            Name = "SearchControl";
            Size = new Size(983, 717);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private TextBox searchnm;
        private Button searchbyname;
    }
}
