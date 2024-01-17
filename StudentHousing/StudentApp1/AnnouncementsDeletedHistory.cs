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
            LoadDeletedHistory();
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
            this.Close();
            Announcements announcements = new Announcements();
            announcements.Show();
        }
    }
}
