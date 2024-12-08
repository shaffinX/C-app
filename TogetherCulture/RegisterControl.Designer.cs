namespace TogetherCulture
{
    partial class RegisterControl
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
            checkedListBox1 = new CheckedListBox();
            err = new Label();
            interest1 = new TextBox();
            lname = new TextBox();
            fname = new TextBox();
            label1 = new Label();
            label2 = new Label();
            log1 = new Button();
            pictureBox1 = new PictureBox();
            pass = new TextBox();
            email = new TextBox();
            register1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.BorderStyle = BorderStyle.None;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Community Member", "Key Access Member", "Creative Workspace Member" });
            checkedListBox1.Location = new Point(779, 422);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(187, 54);
            checkedListBox1.TabIndex = 29;
            // 
            // err
            // 
            err.AutoSize = true;
            err.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            err.ForeColor = Color.FromArgb(192, 0, 0);
            err.Location = new Point(806, 583);
            err.Name = "err";
            err.Size = new Size(0, 16);
            err.TabIndex = 28;
            // 
            // interest1
            // 
            interest1.BackColor = SystemColors.Control;
            interest1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            interest1.Location = new Point(655, 359);
            interest1.MinimumSize = new Size(400, 35);
            interest1.Name = "interest1";
            interest1.PlaceholderText = "Interests";
            interest1.Size = new Size(434, 35);
            interest1.TabIndex = 27;
            // 
            // lname
            // 
            lname.BackColor = SystemColors.Control;
            lname.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lname.Location = new Point(894, 192);
            lname.MinimumSize = new Size(195, 35);
            lname.Name = "lname";
            lname.PlaceholderText = "Last name";
            lname.Size = new Size(195, 35);
            lname.TabIndex = 26;
            // 
            // fname
            // 
            fname.BackColor = SystemColors.Control;
            fname.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fname.Location = new Point(655, 192);
            fname.MinimumSize = new Size(195, 35);
            fname.Name = "fname";
            fname.PlaceholderText = "First name";
            fname.Size = new Size(195, 35);
            fname.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(760, 49);
            label1.Name = "label1";
            label1.Size = new Size(224, 55);
            label1.TabIndex = 24;
            label1.Text = "Register";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(64, 64, 64);
            label2.Font = new Font("Arial Rounded MT Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 447);
            label2.Name = "label2";
            label2.Size = new Size(382, 33);
            label2.TabIndex = 23;
            label2.Text = "Already Have an Account!";
            // 
            // log1
            // 
            log1.BackColor = Color.FromArgb(64, 64, 64);
            log1.Cursor = Cursors.Hand;
            log1.FlatStyle = FlatStyle.Flat;
            log1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            log1.ForeColor = Color.Gold;
            log1.Location = new Point(124, 524);
            log1.Name = "log1";
            log1.RightToLeft = RightToLeft.No;
            log1.Size = new Size(142, 43);
            log1.TabIndex = 22;
            log1.Text = "LOGIN";
            log1.UseVisualStyleBackColor = false;
            log1.Click += log1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(64, 64, 64);
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(408, 720);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // pass
            // 
            pass.BackColor = SystemColors.Control;
            pass.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pass.Location = new Point(655, 299);
            pass.MinimumSize = new Size(400, 35);
            pass.Name = "pass";
            pass.PlaceholderText = "Password";
            pass.Size = new Size(434, 35);
            pass.TabIndex = 20;
            pass.UseSystemPasswordChar = true;
            // 
            // email
            // 
            email.BackColor = SystemColors.Control;
            email.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            email.Location = new Point(655, 245);
            email.MinimumSize = new Size(400, 35);
            email.Name = "email";
            email.PlaceholderText = "Email";
            email.Size = new Size(434, 35);
            email.TabIndex = 18;
            // 
            // register1
            // 
            register1.BackColor = Color.FromArgb(64, 64, 64);
            register1.Cursor = Cursors.Hand;
            register1.FlatStyle = FlatStyle.Popup;
            register1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register1.ForeColor = Color.Gold;
            register1.Location = new Point(777, 514);
            register1.Name = "register1";
            register1.RightToLeft = RightToLeft.No;
            register1.Size = new Size(190, 43);
            register1.TabIndex = 19;
            register1.Text = "REGISTER";
            register1.UseVisualStyleBackColor = false;
            register1.Click += register1_Click;
            // 
            // RegisterControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(checkedListBox1);
            Controls.Add(err);
            Controls.Add(interest1);
            Controls.Add(lname);
            Controls.Add(fname);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(log1);
            Controls.Add(pictureBox1);
            Controls.Add(pass);
            Controls.Add(email);
            Controls.Add(register1);
            Name = "RegisterControl";
            Size = new Size(1280, 720);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkedListBox1;
        private Label err;
        private TextBox interest1;
        private TextBox lname;
        private TextBox fname;
        private Label label1;
        private Label label2;
        private Button log1;
        private PictureBox pictureBox1;
        private TextBox pass;
        private TextBox email;
        private Button register1;
    }
}
