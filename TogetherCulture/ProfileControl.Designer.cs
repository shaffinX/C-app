namespace TogetherCulture
{
    partial class ProfileControl
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
            dataGridView1 = new DataGridView();
            passwordbutt = new Button();
            pass = new TextBox();
            changeinter = new Button();
            inter = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(418, 43);
            label4.Name = "label4";
            label4.Size = new Size(89, 28);
            label4.TabIndex = 1;
            label4.Text = "Profile";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(86, 145);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(784, 84);
            dataGridView1.TabIndex = 2;
            // 
            // passwordbutt
            // 
            passwordbutt.BackColor = Color.FromArgb(64, 64, 64);
            passwordbutt.FlatStyle = FlatStyle.Flat;
            passwordbutt.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordbutt.ForeColor = Color.Gold;
            passwordbutt.Location = new Point(592, 349);
            passwordbutt.Name = "passwordbutt";
            passwordbutt.Size = new Size(75, 23);
            passwordbutt.TabIndex = 4;
            passwordbutt.Text = "Change";
            passwordbutt.UseVisualStyleBackColor = false;
            passwordbutt.Click += passwordbutt_Click;
            // 
            // pass
            // 
            pass.Location = new Point(301, 349);
            pass.Name = "pass";
            pass.PlaceholderText = "Change Password";
            pass.Size = new Size(285, 23);
            pass.TabIndex = 3;
            // 
            // changeinter
            // 
            changeinter.BackColor = Color.FromArgb(64, 64, 64);
            changeinter.FlatStyle = FlatStyle.Flat;
            changeinter.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            changeinter.ForeColor = Color.Gold;
            changeinter.Location = new Point(592, 401);
            changeinter.Name = "changeinter";
            changeinter.Size = new Size(75, 23);
            changeinter.TabIndex = 6;
            changeinter.Text = "Change";
            changeinter.UseVisualStyleBackColor = false;
            changeinter.Click += changeinter_Click;
            // 
            // inter
            // 
            inter.Location = new Point(301, 401);
            inter.Name = "inter";
            inter.PlaceholderText = "Change Interest";
            inter.Size = new Size(285, 23);
            inter.TabIndex = 5;
            // 
            // ProfileControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(changeinter);
            Controls.Add(inter);
            Controls.Add(passwordbutt);
            Controls.Add(pass);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Name = "ProfileControl";
            Size = new Size(983, 717);
            Load += ProfileControl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private DataGridView dataGridView1;
        private Button passwordbutt;
        private TextBox pass;
        private Button changeinter;
        private TextBox inter;
    }
}
