namespace StudentHousing
{
    partial class AnnouncementsDeletedHistory
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
            goBackToAnnouncementsLabel = new Label();
            flowLayOutPanelHistory = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // goBackToAnnouncementsLabel
            // 
            goBackToAnnouncementsLabel.AutoSize = true;
            goBackToAnnouncementsLabel.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold);
            goBackToAnnouncementsLabel.Location = new Point(51, 49);
            goBackToAnnouncementsLabel.Margin = new Padding(4, 0, 4, 0);
            goBackToAnnouncementsLabel.Name = "goBackToAnnouncementsLabel";
            goBackToAnnouncementsLabel.Size = new Size(97, 44);
            goBackToAnnouncementsLabel.TabIndex = 0;
            goBackToAnnouncementsLabel.Text = "Back";
            goBackToAnnouncementsLabel.Click += goBackToAnnouncementsLabel_Click;
            // 
            // flowLayOutPanelHistory
            // 
            flowLayOutPanelHistory.Anchor = AnchorStyles.None;
            flowLayOutPanelHistory.AutoScroll = true;
            flowLayOutPanelHistory.Location = new Point(217, 276);
            flowLayOutPanelHistory.Margin = new Padding(4);
            flowLayOutPanelHistory.Name = "flowLayOutPanelHistory";
            flowLayOutPanelHistory.Size = new Size(970, 485);
            flowLayOutPanelHistory.TabIndex = 1;
            // 
            // AnnouncementsDeletedHistory
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.abstract_background_blue_wallpaper_image1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1378, 994);
            Controls.Add(flowLayOutPanelHistory);
            Controls.Add(goBackToAnnouncementsLabel);
            Margin = new Padding(4);
            Name = "AnnouncementsDeletedHistory";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AnnouncementsDeletedHistory";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label goBackToAnnouncementsLabel;
        private FlowLayoutPanel flowLayOutPanelHistory;
    }
}