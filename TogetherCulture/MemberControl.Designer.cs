namespace TogetherCulture
{
    partial class MemberControl
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
            dash = new Panel();
            pictureBox3 = new PictureBox();
            logout = new Button();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            greet = new Label();
            screen = new Panel();
            label5 = new Label();
            titleLbl = new Label();
            label4 = new Label();
            dash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            screen.SuspendLayout();
            SuspendLayout();
            // 
            // dash
            // 
            dash.BackColor = Color.FromArgb(64, 64, 64);
            dash.Controls.Add(pictureBox3);
            dash.Controls.Add(logout);
            dash.Controls.Add(label3);
            dash.Controls.Add(pictureBox2);
            dash.Controls.Add(label2);
            dash.Controls.Add(pictureBox1);
            dash.Controls.Add(label1);
            dash.Controls.Add(greet);
            dash.Location = new Point(0, 0);
            dash.Name = "dash";
            dash.Size = new Size(271, 720);
            dash.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.user1;
            pictureBox3.Location = new Point(36, 280);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(18, 18);
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // logout
            // 
            logout.BackColor = Color.FromArgb(64, 64, 64);
            logout.Cursor = Cursors.Hand;
            logout.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logout.ForeColor = Color.Black;
            logout.Location = new Point(36, 643);
            logout.Margin = new Padding(0);
            logout.Name = "logout";
            logout.Size = new Size(169, 34);
            logout.TabIndex = 0;
            logout.Text = "LogOut";
            logout.UseVisualStyleBackColor = true;
            logout.Click += logout_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(60, 280);
            label3.Name = "label3";
            label3.Size = new Size(59, 18);
            label3.TabIndex = 10;
            label3.Text = "Profile";
            label3.Click += label3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.dashboard;
            pictureBox2.Location = new Point(36, 213);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(18, 18);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(60, 212);
            label2.Name = "label2";
            label2.Size = new Size(96, 18);
            label2.TabIndex = 8;
            label2.Text = "Dashboard";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.list1;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Location = new Point(36, 249);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(18, 18);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(60, 248);
            label1.Name = "label1";
            label1.Size = new Size(87, 18);
            label1.TabIndex = 6;
            label1.Text = "Event List";
            label1.Click += label1_Click;
            // 
            // greet
            // 
            greet.AutoSize = true;
            greet.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            greet.ForeColor = Color.White;
            greet.Location = new Point(31, 53);
            greet.Name = "greet";
            greet.Size = new Size(186, 22);
            greet.TabIndex = 5;
            greet.Text = "Hello! Lorem Ipsum";
            // 
            // screen
            // 
            screen.BackColor = Color.White;
            screen.Controls.Add(label5);
            screen.Controls.Add(titleLbl);
            screen.Controls.Add(label4);
            screen.Location = new Point(297, 0);
            screen.Name = "screen";
            screen.Size = new Size(983, 717);
            screen.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(334, 431);
            label5.Name = "label5";
            label5.Size = new Size(350, 28);
            label5.TabIndex = 2;
            label5.Text = "Welcome to Together Culture";
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleLbl.Location = new Point(445, 275);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(129, 22);
            titleLbl.TabIndex = 1;
            titleLbl.Text = "Lorem Ipsum";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(413, 247);
            label4.Name = "label4";
            label4.Size = new Size(181, 28);
            label4.TabIndex = 0;
            label4.Text = "Hello! Member";
            label4.Click += label4_Click;
            // 
            // MemberControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(screen);
            Controls.Add(dash);
            Name = "MemberControl";
            Size = new Size(1280, 720);
            dash.ResumeLayout(false);
            dash.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            screen.ResumeLayout(false);
            screen.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel dash;
        private Label greet;
        private Button logout;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label3;
        private Panel screen;
        private Label label5;
        private Label titleLbl;
        private Label label4;
    }
}
