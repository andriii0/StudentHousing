using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using StudentApp1;

namespace StudentHousing
{
    public partial class AnnouncementsDeletedHistory : Form
    {
        private string jsonFileHistory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\AnnouncementsDeletedHistoty.json");

        public AnnouncementsDeletedHistory()
        {
            InitializeComponent();
            this.FormClosing += (sender, e) => Application.Exit();

            LoadDeletedHistory();

            goBackToAnnouncementsLabel.MouseEnter += goBackToAnnouncementsLabel_MouseEnter;
            goBackToAnnouncementsLabel.MouseLeave += goBackToAnnouncementsLabel_MouseLeave;
        }

        private void LoadDeletedHistory()
        {
            try
            {
                string jsonContent = File.ReadAllText(jsonFileHistory);

                MessageFormat[] announcements = JsonConvert.DeserializeObject<MessageFormat[]>(jsonContent);

                Array.Reverse(announcements);

                foreach (MessageFormat announcement in announcements)
                {
                    FlowLayoutPanelAnnouncement(announcement);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading announcements: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FlowLayoutPanelAnnouncement(MessageFormat announcement)
        {
            RichTextBox richTextBox = new RichTextBox();
            richTextBox.Text = $"{announcement.SenderName}     {announcement.CurrentTime}\n{announcement.TextToSave}";
            richTextBox.ReadOnly = true;
            richTextBox.Height = 120;
            richTextBox.Width = 755;
            flowLayOutPanelHistory.Controls.Add(richTextBox);
        }

        private void goBackToAnnouncementsLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Announcements announcements = new Announcements();
            announcements.Show();
        }

        //Hover functionality
        private void goBackToAnnouncementsLabel_MouseEnter(object sender, EventArgs e)
        {
            goBackToAnnouncementsLabel.BackColor = System.Drawing.Color.LightCoral;
            goBackToAnnouncementsLabel.ForeColor = System.Drawing.Color.White;
        }

        private void goBackToAnnouncementsLabel_MouseLeave(object sender, EventArgs e)
        {
            goBackToAnnouncementsLabel.BackColor = System.Drawing.SystemColors.Control;
            goBackToAnnouncementsLabel.ForeColor = System.Drawing.Color.Black;
        }
    }
}
