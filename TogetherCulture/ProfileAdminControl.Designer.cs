namespace TogetherCulture
{
    partial class ProfileAdminControl
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
            passwordbutt = new Button();
            pass = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(426, 28);
            label4.Name = "label4";
            label4.Size = new Size(89, 28);
            label4.TabIndex = 2;
            label4.Text = "Profile";
            // 
            // passwordbutt
            // 
            passwordbutt.BackColor = Color.FromArgb(64, 64, 64);
            passwordbutt.FlatStyle = FlatStyle.Flat;
            passwordbutt.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordbutt.ForeColor = Color.Gold;
            passwordbutt.Location = new Point(606, 121);
            passwordbutt.Name = "passwordbutt";
            passwordbutt.Size = new Size(75, 23);
            passwordbutt.TabIndex = 6;
            passwordbutt.Text = "Change";
            passwordbutt.UseVisualStyleBackColor = false;
            passwordbutt.Click += passwordbutt_Click;
            // 
            // pass
            // 
            pass.Location = new Point(315, 121);
            pass.Name = "pass";
            pass.PlaceholderText = "Change Password";
            pass.Size = new Size(285, 23);
            pass.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(104, 219);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(784, 84);
            dataGridView1.TabIndex = 7;
            // 
            // ProfileAdminControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(dataGridView1);
            Controls.Add(passwordbutt);
            Controls.Add(pass);
            Controls.Add(label4);
            Name = "ProfileAdminControl";
            Size = new Size(983, 717);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button passwordbutt;
        private TextBox pass;
        private DataGridView dataGridView1;
    }
}
