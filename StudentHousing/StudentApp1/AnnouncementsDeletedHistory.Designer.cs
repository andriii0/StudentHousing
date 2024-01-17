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
            goBackToAnnouncementsLabel.Location = new Point(11, 9);
            goBackToAnnouncementsLabel.Name = "goBackToAnnouncementsLabel";
            goBackToAnnouncementsLabel.Size = new Size(82, 38);
            goBackToAnnouncementsLabel.TabIndex = 0;
            goBackToAnnouncementsLabel.Text = "Back";
            goBackToAnnouncementsLabel.Click += goBackToAnnouncementsLabel_Click;
            // 
            // flowLayOutPanelHistory
            // 
            flowLayOutPanelHistory.AutoScroll = true;
            flowLayOutPanelHistory.Location = new Point(12, 50);
            flowLayOutPanelHistory.Name = "flowLayOutPanelHistory";
            flowLayOutPanelHistory.Size = new Size(776, 388);
            flowLayOutPanelHistory.TabIndex = 1;
            // 
            // AnnouncementsDeletedHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayOutPanelHistory);
            Controls.Add(goBackToAnnouncementsLabel);
            Name = "AnnouncementsDeletedHistory";
            Text = "AnnouncementsDeletedHistory";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label goBackToAnnouncementsLabel;
        private FlowLayoutPanel flowLayOutPanelHistory;
    }
}