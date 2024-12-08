namespace TogetherCulture
{
    partial class DashboardControl
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
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            util = new Label();
            unutil = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(394, 41);
            label4.Name = "label4";
            label4.Size = new Size(142, 28);
            label4.TabIndex = 1;
            label4.Text = "DashBoard";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(152, 131);
            label1.Name = "label1";
            label1.Size = new Size(141, 18);
            label1.TabIndex = 2;
            label1.Text = "Benefits Utilized:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(654, 131);
            label2.Name = "label2";
            label2.Size = new Size(168, 18);
            label2.TabIndex = 3;
            label2.Text = "Benefits Un-Utilized:";
            // 
            // util
            // 
            util.AutoSize = true;
            util.Location = new Point(152, 164);
            util.Name = "util";
            util.Size = new Size(38, 15);
            util.TabIndex = 4;
            util.Text = "label3";
            // 
            // unutil
            // 
            unutil.AutoSize = true;
            unutil.Location = new Point(654, 164);
            unutil.Name = "unutil";
            unutil.Size = new Size(38, 15);
            unutil.TabIndex = 5;
            unutil.Text = "label3";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(152, 260);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(670, 339);
            dataGridView1.TabIndex = 6;
            // 
            // DashboardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(dataGridView1);
            Controls.Add(unutil);
            Controls.Add(util);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label4);
            Name = "DashboardControl";
            Size = new Size(983, 717);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label1;
        private Label label2;
        private Label util;
        private Label unutil;
        private DataGridView dataGridView1;
    }
}
