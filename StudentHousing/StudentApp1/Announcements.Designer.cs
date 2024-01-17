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
            backLabel.Location = new Point(71, 56);
            backLabel.Name = "backLabel";
            backLabel.Size = new Size(65, 29);
            backLabel.TabIndex = 0;
            backLabel.Text = "Back";
            backLabel.Click += backLabel_Click;
            // 
            // flowLayOutPanelAnnouncements
            // 
            flowLayOutPanelAnnouncements.Anchor = AnchorStyles.None;
            flowLayOutPanelAnnouncements.AutoScroll = true;
            flowLayOutPanelAnnouncements.Location = new Point(89, 152);
            flowLayOutPanelAnnouncements.Margin = new Padding(3, 2, 3, 2);
            flowLayOutPanelAnnouncements.Name = "flowLayOutPanelAnnouncements";
            flowLayOutPanelAnnouncements.Size = new Size(819, 338);
            flowLayOutPanelAnnouncements.TabIndex = 1;
            // 
            // viewDeletedAnnouncementsButton
            // 
            viewDeletedAnnouncementsButton.Anchor = AnchorStyles.Top;
            viewDeletedAnnouncementsButton.Location = new Point(388, 106);
            viewDeletedAnnouncementsButton.Margin = new Padding(3, 2, 3, 2);
            viewDeletedAnnouncementsButton.Name = "viewDeletedAnnouncementsButton";
            viewDeletedAnnouncementsButton.Size = new Size(206, 22);
            viewDeletedAnnouncementsButton.TabIndex = 2;
            viewDeletedAnnouncementsButton.Text = "View deleted announcements";
            viewDeletedAnnouncementsButton.UseVisualStyleBackColor = true;
            viewDeletedAnnouncementsButton.Click += viewDeletedAnnouncementsButton_Click;
            // 
            // Announcements
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = StudentHousing.Properties.Resources.watercolor_texture_background_light_gray_wallpaper;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(965, 596);
            Controls.Add(viewDeletedAnnouncementsButton);
            Controls.Add(flowLayOutPanelAnnouncements);
            Controls.Add(backLabel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Announcements";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Announcements";
            Load += Announcements_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label backLabel;
        private FlowLayoutPanel flowLayOutPanelAnnouncements;
        private Button viewDeletedAnnouncementsButton;
    }
}