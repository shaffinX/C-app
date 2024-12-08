namespace TogetherCulture
{
    partial class EventListControl
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
            flowLayoutPanelEvents = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(422, 60);
            label4.Name = "label4";
            label4.Size = new Size(125, 28);
            label4.TabIndex = 1;
            label4.Text = "Event List";
            // 
            // flowLayoutPanelEvents
            // 
            flowLayoutPanelEvents.AutoScroll = true;
            flowLayoutPanelEvents.Location = new Point(0, 107);
            flowLayoutPanelEvents.Name = "flowLayoutPanelEvents";
            flowLayoutPanelEvents.Size = new Size(983, 607);
            flowLayoutPanelEvents.TabIndex = 2;
            // 
            // EventListControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(flowLayoutPanelEvents);
            Controls.Add(label4);
            Name = "EventListControl";
            Size = new Size(983, 717);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private FlowLayoutPanel flowLayoutPanelEvents;
    }
}
