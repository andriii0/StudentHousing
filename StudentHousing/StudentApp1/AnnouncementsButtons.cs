using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousing
{
    public class AnnouncementsButtons
    {
        private string jsonFileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\AnnouncementMessage.json");
        private string jsonFileHistory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\AnnouncementsDeletedHistoty.json");
        private FlowLayoutPanel flowLayOutPanelAnnouncements;

        public AnnouncementsButtons(FlowLayoutPanel flowLayoutPanel)
        {
            flowLayOutPanelAnnouncements = flowLayoutPanel;
        }
        public void ChangeStatusToReadButton_Click(object sender, EventArgs e)
        {
            try
            {
                Button clickedButton = sender as Button;

                RichTextBox richTextBox = clickedButton.Tag as RichTextBox;

                if (richTextBox != null)
                {
                    string jsonContent = File.ReadAllText(jsonFileName);

                    MessageFormat[] announcements = JsonConvert.DeserializeObject<MessageFormat[]>(jsonContent);

                    MessageFormat announcementToUpdate = announcements.FirstOrDefault(announcement => $"{announcement.SenderName}     {announcement.CurrentTime}\n{announcement.TextToSave}" == richTextBox.Text);

                    if (announcementToUpdate != null)
                    {
                        announcementToUpdate.Status = "Read";

                        string updatedJsonContent = JsonConvert.SerializeObject(announcements, Formatting.Indented);
                        File.WriteAllText(jsonFileName, updatedJsonContent);

                        Panel panel = richTextBox.Parent as Panel;
                        Label statusLabel = panel.Controls.OfType<Label>().FirstOrDefault();

                        if (statusLabel != null)
                        {
                            statusLabel.Text = "Read";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a Error");
            }
        }


        public void ChangeStatusToUnreadButton_Click(object sender, EventArgs e)
        {
            try
            {
                Button clickedButton = sender as Button;

                RichTextBox richTextBox = clickedButton.Tag as RichTextBox;

                if (richTextBox != null)
                {
                    string jsonContent = File.ReadAllText(jsonFileName);

                    MessageFormat[] announcements = JsonConvert.DeserializeObject<MessageFormat[]>(jsonContent);

                    MessageFormat announcementToUpdate = announcements.FirstOrDefault(announcement => $"{announcement.SenderName}     {announcement.CurrentTime}\n{announcement.TextToSave}" == richTextBox.Text);

                    if (announcementToUpdate != null)
                    {
                        announcementToUpdate.Status = "Unread";

                        string updatedJsonContent = JsonConvert.SerializeObject(announcements, Formatting.Indented);
                        File.WriteAllText(jsonFileName, updatedJsonContent);

                        Panel panel = richTextBox.Parent as Panel;
                        Label statusLabel = panel.Controls.OfType<Label>().FirstOrDefault();

                        if (statusLabel != null)
                        {
                            statusLabel.Text = "Unread";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a Error");
            }
        }

        public void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                Button clickedButton = sender as Button;
                RichTextBox richTextBox = clickedButton.Tag as RichTextBox;

                if (richTextBox != null)
                {
                    string jsonContent = File.ReadAllText(jsonFileName);

                    MessageFormat[] announcements = JsonConvert.DeserializeObject<MessageFormat[]>(jsonContent);

                    MessageFormat announcementToDelete = announcements.FirstOrDefault(announcement =>
                        $"{announcement.SenderName}     {announcement.CurrentTime}\n{announcement.TextToSave}" == richTextBox.Text);

                    if (announcementToDelete != null)
                    {
                        string deletedHistoryFileName = jsonFileHistory;
                        string deletedHistoryFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), deletedHistoryFileName);

                        MessageFormat[] deletedAnnouncements;

                        if (File.Exists(deletedHistoryFilePath))
                        {
                            string historyContent = File.ReadAllText(deletedHistoryFilePath);
                            deletedAnnouncements = JsonConvert.DeserializeObject<MessageFormat[]>(historyContent);
                        }
                        else
                        {
                            deletedAnnouncements = new MessageFormat[0];
                        }

                        deletedAnnouncements = deletedAnnouncements.Concat(new[] { announcementToDelete }).ToArray();

                        string updatedHistoryContent = JsonConvert.SerializeObject(deletedAnnouncements, Formatting.Indented);
                        File.WriteAllText(deletedHistoryFilePath, updatedHistoryContent);

                        announcements = announcements.Where(announcement => announcement != announcementToDelete).ToArray();
                        string updatedJsonContent = JsonConvert.SerializeObject(announcements, Formatting.Indented);
                        File.WriteAllText(jsonFileName, updatedJsonContent);

                        Panel panel = richTextBox.Parent as Panel;
                        flowLayOutPanelAnnouncements.Controls.Remove(panel);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a error!");
            }
        }



        public void MarkImportantButton_Click(object sender, EventArgs e)
        {
            try
            {
                Button clickedButton = sender as Button;

                RichTextBox richTextBox = clickedButton.Tag as RichTextBox;

                if (richTextBox != null)
                {
                    string jsonContent = File.ReadAllText(jsonFileName);

                    MessageFormat[] announcements = JsonConvert.DeserializeObject<MessageFormat[]>(jsonContent);

                    MessageFormat announcementToUpdate = announcements.FirstOrDefault(announcement => $"{announcement.SenderName}     {announcement.CurrentTime}\n{announcement.TextToSave}" == richTextBox.Text);

                    if (announcementToUpdate != null)
                    {
                        announcementToUpdate.ImportantOrNot = "Important";

                        string updatedJsonContent = JsonConvert.SerializeObject(announcements, Formatting.Indented);
                        File.WriteAllText(jsonFileName, updatedJsonContent);

                        Panel panel = richTextBox.Parent as Panel;
                        Label importantOrNotLabel = panel.Controls.OfType<Label>().FirstOrDefault(l => l.Name == "importantOrNotLabel");

                        if (importantOrNotLabel != null)
                        {
                            importantOrNotLabel.Text = "Important";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a error!");
            }
        }

        public void MarkNotImportantButton_Click(object sender, EventArgs e)
        {
            try
            {
                Button clickedButton = sender as Button;

                RichTextBox richTextBox = clickedButton.Tag as RichTextBox;

                if (richTextBox != null)
                {
                    string jsonContent = File.ReadAllText(jsonFileName);

                    MessageFormat[] announcements = JsonConvert.DeserializeObject<MessageFormat[]>(jsonContent);

                    MessageFormat announcementToUpdate = announcements.FirstOrDefault(announcement => $"{announcement.SenderName}     {announcement.CurrentTime}\n{announcement.TextToSave}" == richTextBox.Text);

                    if (announcementToUpdate != null)
                    {
                        announcementToUpdate.ImportantOrNot = "Not Important";

                        string updatedJsonContent = JsonConvert.SerializeObject(announcements, Formatting.Indented);
                        File.WriteAllText(jsonFileName, updatedJsonContent);

                        Panel panel = richTextBox.Parent as Panel;
                        Label importantOrNotLabel = panel.Controls.OfType<Label>().FirstOrDefault(l => l.Name == "importantOrNotLabel");

                        if (importantOrNotLabel != null)
                        {
                            importantOrNotLabel.Text = "Not Important";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a error!");
            }
        }














    }
}