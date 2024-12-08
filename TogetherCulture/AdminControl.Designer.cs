namespace TogetherCulture
{
    partial class AdminControl
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
            label4 = new Label();
            label2 = new Label();
            track = new Button();
            button1 = new Button();
            search = new Button();
            createev = new Button();
            addmem = new Button();
            label1 = new Label();
            screen = new Panel();
            label5 = new Label();
            titleLbl = new Label();
            label3 = new Label();
            dash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            screen.SuspendLayout();
            SuspendLayout();
            // 
            // dash
            // 
            dash.BackColor = Color.FromArgb(64, 64, 64);
            dash.Controls.Add(pictureBox3);
            dash.Controls.Add(logout);
            dash.Controls.Add(label4);
            dash.Controls.Add(label2);
            dash.Controls.Add(track);
            dash.Controls.Add(button1);
            dash.Controls.Add(search);
            dash.Controls.Add(createev);
            dash.Controls.Add(addmem);
            dash.Location = new Point(0, 0);
            dash.Name = "dash";
            dash.Size = new Size(271, 720);
            dash.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.user1;
            pictureBox3.Location = new Point(78, 601);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(18, 18);
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // logout
            // 
            logout.BackColor = Color.FromArgb(64, 64, 64);
            logout.Cursor = Cursors.Hand;
            logout.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logout.ForeColor = Color.Black;
            logout.Location = new Point(48, 641);
            logout.Margin = new Padding(0);
            logout.Name = "logout";
            logout.Size = new Size(169, 34);
            logout.TabIndex = 3;
            logout.Text = "LogOut";
            logout.UseVisualStyleBackColor = true;
            logout.Click += logout_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(102, 601);
            label4.Name = "label4";
            label4.Size = new Size(59, 18);
            label4.TabIndex = 12;
            label4.Text = "Profile";
            label4.Click += label4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(44, 50);
            label2.Name = "label2";
            label2.Size = new Size(178, 28);
            label2.TabIndex = 5;
            label2.Text = "Admin Control";
            // 
            // track
            // 
            track.BackColor = Color.FromArgb(64, 64, 64);
            track.Cursor = Cursors.Hand;
            track.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            track.ForeColor = Color.Black;
            track.Location = new Point(48, 451);
            track.Margin = new Padding(0);
            track.Name = "track";
            track.Size = new Size(169, 34);
            track.TabIndex = 4;
            track.Text = "Track Events";
            track.UseVisualStyleBackColor = true;
            track.Click += track_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(48, 386);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(169, 34);
            button1.TabIndex = 3;
            button1.Text = "Analyze Trends";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // search
            // 
            search.BackColor = Color.FromArgb(64, 64, 64);
            search.Cursor = Cursors.Hand;
            search.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            search.ForeColor = Color.Black;
            search.Location = new Point(48, 321);
            search.Margin = new Padding(0);
            search.Name = "search";
            search.Size = new Size(169, 34);
            search.TabIndex = 2;
            search.Text = "Search";
            search.UseVisualStyleBackColor = true;
            search.Click += search_Click;
            // 
            // createev
            // 
            createev.BackColor = Color.FromArgb(64, 64, 64);
            createev.Cursor = Cursors.Hand;
            createev.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createev.ForeColor = Color.Black;
            createev.Location = new Point(48, 256);
            createev.Margin = new Padding(0);
            createev.Name = "createev";
            createev.Size = new Size(169, 34);
            createev.TabIndex = 1;
            createev.Text = "Create Events";
            createev.UseVisualStyleBackColor = true;
            createev.Click += createev_Click;
            // 
            // addmem
            // 
            addmem.BackColor = Color.FromArgb(64, 64, 64);
            addmem.Cursor = Cursors.Hand;
            addmem.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addmem.ForeColor = Color.Black;
            addmem.Location = new Point(48, 191);
            addmem.Margin = new Padding(0);
            addmem.Name = "addmem";
            addmem.Size = new Size(169, 34);
            addmem.TabIndex = 0;
            addmem.Text = "Add Members";
            addmem.UseVisualStyleBackColor = true;
            addmem.Click += addmem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(60, 30);
            label1.Name = "label1";
            label1.Size = new Size(141, 22);
            label1.TabIndex = 2;
            label1.Text = "Admin Control";
            // 
            // screen
            // 
            screen.BackColor = Color.White;
            screen.Controls.Add(label5);
            screen.Controls.Add(titleLbl);
            screen.Controls.Add(label3);
            screen.Location = new Point(297, 0);
            screen.Name = "screen";
            screen.Size = new Size(983, 717);
            screen.TabIndex = 0;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(386, 247);
            label3.Name = "label3";
            label3.Size = new Size(246, 28);
            label3.TabIndex = 0;
            label3.Text = "Hello! Administrator";
            // 
            // AdminControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(screen);
            Controls.Add(dash);
            Name = "AdminControl";
            Size = new Size(1280, 720);
            Load += AdminControl_Load;
            dash.ResumeLayout(false);
            dash.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            screen.ResumeLayout(false);
            screen.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel dash;
        private Panel screen;
        private Label label1;
        private Button addmem;
        private Button createev;
        private Button search;
        private Button button1;
        private Button track;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label titleLbl;
        private Button logout;
        private PictureBox pictureBox3;
        private Label label4;
    }
}
