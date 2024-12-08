namespace TogetherCulture
{
    partial class CreateEventsControl
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
            ename = new TextBox();
            elocat = new TextBox();
            desc = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(369, 59);
            label1.Name = "label1";
            label1.Size = new Size(233, 28);
            label1.TabIndex = 0;
            label1.Text = "Create New Events";
            // 
            // ename
            // 
            ename.BackColor = Color.WhiteSmoke;
            ename.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ename.Location = new Point(339, 155);
            ename.Name = "ename";
            ename.PlaceholderText = "Event Name";
            ename.Size = new Size(293, 25);
            ename.TabIndex = 1;
            // 
            // elocat
            // 
            elocat.BackColor = Color.WhiteSmoke;
            elocat.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            elocat.Location = new Point(339, 200);
            elocat.Name = "elocat";
            elocat.PlaceholderText = "Location";
            elocat.Size = new Size(293, 25);
            elocat.TabIndex = 2;
            // 
            // desc
            // 
            desc.BackColor = Color.WhiteSmoke;
            desc.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            desc.Location = new Point(339, 245);
            desc.Multiline = true;
            desc.Name = "desc";
            desc.PlaceholderText = "Description";
            desc.Size = new Size(293, 77);
            desc.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.CalendarMonthBackground = Color.WhiteSmoke;
            dateTimePicker1.Location = new Point(339, 343);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(293, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Gold;
            button1.Location = new Point(442, 395);
            button1.Name = "button1";
            button1.Size = new Size(83, 26);
            button1.TabIndex = 5;
            button1.Text = "create";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // CreateEventsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(desc);
            Controls.Add(elocat);
            Controls.Add(ename);
            Controls.Add(label1);
            Name = "CreateEventsControl";
            Size = new Size(983, 717);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox ename;
        private TextBox elocat;
        private TextBox desc;
        private DateTimePicker dateTimePicker1;
        private Button button1;
    }
}
