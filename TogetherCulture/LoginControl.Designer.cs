namespace TogetherCulture
{
    partial class LoginControl
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
            label2 = new Label();
            reg1 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pass = new TextBox();
            email = new TextBox();
            login = new Button();
            err = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(64, 64, 64);
            label2.Font = new Font("Arial Rounded MT Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(60, 496);
            label2.Name = "label2";
            label2.Size = new Size(282, 43);
            label2.TabIndex = 12;
            label2.Text = "Register Now! ";
            // 
            // reg1
            // 
            reg1.BackColor = Color.FromArgb(64, 64, 64);
            reg1.Cursor = Cursors.Hand;
            reg1.FlatStyle = FlatStyle.Flat;
            reg1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reg1.ForeColor = Color.Gold;
            reg1.Location = new Point(130, 566);
            reg1.Name = "reg1";
            reg1.RightToLeft = RightToLeft.No;
            reg1.Size = new Size(142, 43);
            reg1.TabIndex = 11;
            reg1.Text = "REG";
            reg1.UseVisualStyleBackColor = false;
            reg1.Click += reg1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(64, 64, 64);
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(408, 720);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(789, 207);
            label1.Name = "label1";
            label1.Size = new Size(154, 55);
            label1.TabIndex = 9;
            label1.Text = "Login";
            // 
            // pass
            // 
            pass.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pass.Location = new Point(649, 388);
            pass.MinimumSize = new Size(400, 35);
            pass.Name = "pass";
            pass.PlaceholderText = "Password";
            pass.Size = new Size(434, 35);
            pass.TabIndex = 8;
            pass.UseSystemPasswordChar = true;
            // 
            // email
            // 
            email.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            email.Location = new Point(649, 334);
            email.MinimumSize = new Size(400, 35);
            email.Name = "email";
            email.PlaceholderText = "Email";
            email.Size = new Size(434, 35);
            email.TabIndex = 6;
            // 
            // login
            // 
            login.BackColor = Color.FromArgb(64, 64, 64);
            login.Cursor = Cursors.Hand;
            login.FlatStyle = FlatStyle.Popup;
            login.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login.ForeColor = Color.Gold;
            login.Location = new Point(771, 450);
            login.Name = "login";
            login.RightToLeft = RightToLeft.No;
            login.Size = new Size(190, 43);
            login.TabIndex = 7;
            login.Text = "LOGIN";
            login.UseVisualStyleBackColor = false;
            login.Click += login1_Click;
            // 
            // err
            // 
            err.AutoSize = true;
            err.Location = new Point(819, 521);
            err.Name = "err";
            err.Size = new Size(0, 15);
            err.TabIndex = 13;
            // 
            // LoginControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(err);
            Controls.Add(label2);
            Controls.Add(reg1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(pass);
            Controls.Add(email);
            Controls.Add(login);
            Name = "LoginControl";
            Size = new Size(1280, 720);
            Load += LoginControl_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button reg1;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox pass;
        private TextBox email;
        private Button login;
        private Label err;
    }
}
