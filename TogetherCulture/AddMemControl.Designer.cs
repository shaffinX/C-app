namespace TogetherCulture
{
    partial class AddMemControl
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
            userid = new TextBox();
            susp = new Button();
            comboBox1 = new ComboBox();
            button2 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(86, 193);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(806, 439);
            dataGridView1.TabIndex = 0;
            // 
            // userid
            // 
            userid.Location = new Point(347, 88);
            userid.Name = "userid";
            userid.PlaceholderText = "userID";
            userid.Size = new Size(285, 23);
            userid.TabIndex = 1;
            // 
            // susp
            // 
            susp.BackColor = Color.FromArgb(64, 64, 64);
            susp.FlatStyle = FlatStyle.Flat;
            susp.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            susp.ForeColor = Color.Gold;
            susp.Location = new Point(638, 88);
            susp.Name = "susp";
            susp.Size = new Size(75, 23);
            susp.TabIndex = 2;
            susp.Text = "Suspend";
            susp.UseVisualStyleBackColor = false;
            susp.Click += susp_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Community Member", "Key Access Member", "Creative Workspace Member" });
            comboBox1.Location = new Point(347, 117);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(285, 24);
            comboBox1.TabIndex = 3;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(64, 64, 64);
            button2.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(442, 146);
            button2.Name = "button2";
            button2.Size = new Size(95, 28);
            button2.TabIndex = 4;
            button2.Text = "Approve";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(372, 46);
            label1.Name = "label1";
            label1.Size = new Size(234, 22);
            label1.TabIndex = 5;
            label1.Text = "Add or Update Members";
            // 
            // AddMemControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Controls.Add(susp);
            Controls.Add(userid);
            Controls.Add(dataGridView1);
            Name = "AddMemControl";
            Size = new Size(983, 717);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox userid;
        private Button susp;
        private ComboBox comboBox1;
        private Button button2;
        private Label label1;
    }
}
