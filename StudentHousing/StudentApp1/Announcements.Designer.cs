namespace StudentApp1
{
    partial class Announcements
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            backLabel = new Label();
            flowLayOutPanelAnnouncements = new FlowLayoutPanel();
            viewDeletedAnnouncementsButton = new Button();
            SuspendLayout();
            // 
            // backLabel
            // 
            backLabel.AutoSize = true;
            backLabel.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold);
            backLabel.Location = new Point(11, 9);
            backLabel.Name = "backLabel";
            backLabel.Size = new Size(82, 38);
            backLabel.TabIndex = 0;
            backLabel.Text = "Back";
            backLabel.Click += backLabel_Click;
            // 
            // flowLayOutPanelAnnouncements
            // 
            flowLayOutPanelAnnouncements.AutoScroll = true;
            flowLayOutPanelAnnouncements.Location = new Point(12, 50);
            flowLayOutPanelAnnouncements.Name = "flowLayOutPanelAnnouncements";
            flowLayOutPanelAnnouncements.Size = new Size(776, 389);
            flowLayOutPanelAnnouncements.TabIndex = 1;
            // 
            // viewDeletedAnnouncementsButton
            // 
            viewDeletedAnnouncementsButton.Location = new Point(264, 9);
            viewDeletedAnnouncementsButton.Name = "viewDeletedAnnouncementsButton";
            viewDeletedAnnouncementsButton.Size = new Size(235, 29);
            viewDeletedAnnouncementsButton.TabIndex = 2;
            viewDeletedAnnouncementsButton.Text = "View deleted announcements";
            viewDeletedAnnouncementsButton.UseVisualStyleBackColor = true;
            viewDeletedAnnouncementsButton.Click += viewDeletedAnnouncementsButton_Click;
            // 
            // Announcements
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(viewDeletedAnnouncementsButton);
            Controls.Add(flowLayOutPanelAnnouncements);
            Controls.Add(backLabel);
            Name = "Announcements";
            Text = "Announcements";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label backLabel;
        private FlowLayoutPanel flowLayOutPanelAnnouncements;
        private Button viewDeletedAnnouncementsButton;
    }
}