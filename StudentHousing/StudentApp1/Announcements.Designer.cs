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
            backLabel.Location = new Point(101, 93);
            backLabel.Margin = new Padding(4, 0, 4, 0);
            backLabel.Name = "backLabel";
            backLabel.Size = new Size(97, 44);
            backLabel.TabIndex = 0;
            backLabel.Text = "Back";
            backLabel.Click += backLabel_Click;
            // 
            // flowLayOutPanelAnnouncements
            // 
            flowLayOutPanelAnnouncements.Anchor = AnchorStyles.None;
            flowLayOutPanelAnnouncements.AutoScroll = true;
            flowLayOutPanelAnnouncements.Location = new Point(214, 281);
            flowLayOutPanelAnnouncements.Margin = new Padding(4, 3, 4, 3);
            flowLayOutPanelAnnouncements.Name = "flowLayOutPanelAnnouncements";
            flowLayOutPanelAnnouncements.Size = new Size(970, 487);
            flowLayOutPanelAnnouncements.TabIndex = 1;
            // 
            // viewDeletedAnnouncementsButton
            // 
            viewDeletedAnnouncementsButton.Anchor = AnchorStyles.Top;
            viewDeletedAnnouncementsButton.Location = new Point(555, 177);
            viewDeletedAnnouncementsButton.Margin = new Padding(4, 3, 4, 3);
            viewDeletedAnnouncementsButton.Name = "viewDeletedAnnouncementsButton";
            viewDeletedAnnouncementsButton.Size = new Size(294, 37);
            viewDeletedAnnouncementsButton.TabIndex = 2;
            viewDeletedAnnouncementsButton.Text = "View deleted announcements";
            viewDeletedAnnouncementsButton.UseVisualStyleBackColor = true;
            viewDeletedAnnouncementsButton.Click += viewDeletedAnnouncementsButton_Click;
            // 
            // Announcements
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = StudentHousing.Properties.Resources.watercolor_texture_background_light_gray_wallpaper;
            ClientSize = new Size(1378, 994);
            Controls.Add(viewDeletedAnnouncementsButton);
            Controls.Add(flowLayOutPanelAnnouncements);
            Controls.Add(backLabel);
            Margin = new Padding(4, 3, 4, 3);
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