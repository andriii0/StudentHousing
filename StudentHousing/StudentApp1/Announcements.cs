using Newtonsoft.Json;
using StudentHousing;
using System;
using System.IO;
using System.Net.Http.Json;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace StudentApp1
{
    public partial class Announcements : Form
    {
        private string jsonFileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\AnnouncementMessage.json");
        private AnnouncementsButtons announcementsButtons;

        public Announcements()
        {
            InitializeComponent();
            announcementsButtons = new AnnouncementsButtons(flowLayOutPanelAnnouncements);
            LoadAnnouncements();
        }

        private void LoadAnnouncements()
        {
            try
            {
                string jsonContent = File.ReadAllText(jsonFileName);

                MessageFormat[] announcements = JsonConvert.DeserializeObject<MessageFormat[]>(jsonContent);

                Array.Reverse(announcements);

                foreach (MessageFormat announcement in announcements)
                {
                    FlowLayoutPanel(announcement);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a error!");
            }
        }

        private void FlowLayoutPanel(MessageFormat announcement)
        {
            Panel panel = new Panel();
            panel.Dock = DockStyle.Top;
            panel.Height = 170;
            panel.Width = 750;

            Label statusLabel = new Label();
            statusLabel.Text = announcement.Status;
            statusLabel.Dock = DockStyle.None;
            statusLabel.BackColor = Color.DodgerBlue;
            statusLabel.Height = 120;
            statusLabel.Width = 15;

            Label importantOrNotLabel = new Label();
            importantOrNotLabel.Text = announcement.ImportantOrNot;
            importantOrNotLabel.Dock = DockStyle.Right;
            importantOrNotLabel.Width = 110;
            importantOrNotLabel.AutoSize = true;

            RichTextBox richTextBox = new RichTextBox();
            richTextBox.Text = $"{announcement.SenderName}     {announcement.CurrentTime}\n{announcement.TextToSave}";
            richTextBox.ReadOnly = true;
            richTextBox.Height = 120;
            richTextBox.Width = 740;

            FlowLayoutPanel buttonFlowLayoutPanel = new FlowLayoutPanel();
            buttonFlowLayoutPanel.Dock = DockStyle.Bottom;
            buttonFlowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
            buttonFlowLayoutPanel.Height = 50;

            Button changeStatusToReadButton = new Button();
            changeStatusToReadButton.Text = "Mark as read";
            changeStatusToReadButton.Width = 130;
            changeStatusToReadButton.Height = 40;
            changeStatusToReadButton.Tag = richTextBox;
            changeStatusToReadButton.Click += announcementsButtons.ChangeStatusToReadButton_Click;

            Button changeStatusToUnreadButton = new Button();
            changeStatusToUnreadButton.Text = "Mark as Unread";
            changeStatusToUnreadButton.Width = 130;
            changeStatusToUnreadButton.Height = 40;
            changeStatusToUnreadButton.Tag = richTextBox;
            changeStatusToUnreadButton.Click += announcementsButtons.ChangeStatusToUnreadButton_Click;

            Button deleteButton = new Button();
            deleteButton.Text = "Delete";
            deleteButton.Width = 130;
            deleteButton.Height = 40;
            deleteButton.Tag = richTextBox;
            deleteButton.Click += announcementsButtons.DeleteButton_Click;

            Button markImportantButton = new Button();
            markImportantButton.Text = "Mark as important";
            markImportantButton.Width = 160;
            markImportantButton.Height = 40;
            markImportantButton.Tag = richTextBox;
            markImportantButton.Click += announcementsButtons.MarkImportantButton_Click;

            Button markNotImportantButton = new Button();
            markNotImportantButton.Text = "Mark as unimportant";
            markNotImportantButton.Width = 160;
            markNotImportantButton.Height = 40;
            markNotImportantButton.Tag = richTextBox;
            markNotImportantButton.Click += announcementsButtons.MarkNotImportantButton_Click;

            buttonFlowLayoutPanel.Controls.Add(changeStatusToReadButton);
            buttonFlowLayoutPanel.Controls.Add(changeStatusToUnreadButton);
            buttonFlowLayoutPanel.Controls.Add(deleteButton);
            buttonFlowLayoutPanel.Controls.Add(markImportantButton);
            buttonFlowLayoutPanel.Controls.Add(markNotImportantButton);

            richTextBox.Location = new Point(statusLabel.Width, 0);

            richTextBox.Controls.Add(importantOrNotLabel);

            panel.Controls.Add(statusLabel);
            panel.Controls.Add(richTextBox);
            panel.Controls.Add(buttonFlowLayoutPanel);
            flowLayOutPanelAnnouncements.Controls.Add(panel);
        }



        private void backLabel_Click(object sender, EventArgs e)
        {
            MainForm form1 = new MainForm(CurrentUser.LoggedInUser);
            this.Close();
            form1.Show();
        }

        private void viewDeletedAnnouncementsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnnouncementsDeletedHistory announcementsDeletedHistory = new AnnouncementsDeletedHistory();
            announcementsDeletedHistory.Show();
        }

        private void Announcements_Load(object sender, EventArgs e)
        {
        }
    }
}