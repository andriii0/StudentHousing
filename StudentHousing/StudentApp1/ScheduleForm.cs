using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using StudentApp1;

namespace StudentHousing
{
    public partial class ScheduleForm : Form
    {
        private DateTime selectedDate;
        private List<Event> events;
        private List<FlowLayoutPanel> eventPanels;

        private const int MaxEventsPerDay = 5;
        private const int MaxMessageLength = 180;

        private string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\events.json");

        public ScheduleForm(User authenticatedUser)
        {
            InitializeComponent();
            eventPanels = new List<FlowLayoutPanel>();
        }

        private void LeftLabel_Click(object sender, EventArgs e)
        {
            selectedDate = selectedDate.AddDays(-1);
            UpdateDateLabel();
        }

        private void RightLabel_Click(object sender, EventArgs e)
        {
            selectedDate = selectedDate.AddDays(1);
            UpdateDateLabel();
        }

        private void UpdateDateLabel()
        {
            DateTimeLabel.Text = selectedDate.ToString("dd.MM.yyyy");
            LoadEvents();
            DisplayEvents();
        }

        private void DisplayEvents()
        {
            eventsPanel.Controls.Clear();
            eventPanels.Clear();

            if (events != null)
            {
                foreach (Event ev in events.Where(ev => ev.Date.Date == selectedDate.Date).Take(MaxEventsPerDay))
                {
                    FlowLayoutPanel eventPanel = new FlowLayoutPanel
                    {
                        FlowDirection = FlowDirection.LeftToRight,
                        Dock = DockStyle.Top,
                        AutoSize = true,
                    };

                    Label eventLabel = new Label
                    {
                        Text = ev.Description.Length > MaxMessageLength ? ev.Description.Substring(0, MaxMessageLength) + "..." : ev.Description,
                        AutoSize = true,
                        Tag = ev,
                    };

                    Button deleteButton = new Button
                    {
                        Text = "Delete",
                        Tag = ev,
                    };

                    deleteButton.Click += DeleteButton_Click;

                    UpdateFontSize(eventLabel);

                    eventLabel.Click += EventLabel_Click;

                    eventPanel.Controls.Add(eventLabel);
                    eventPanel.Controls.Add(deleteButton);

                    eventPanels.Add(eventPanel);
                    eventsPanel.Controls.Add(eventPanel);
                }
            }
        }

        private void EventLabel_Click(object sender, EventArgs e)
        {
            if (sender is Label label && label.Tag is Event ev)
            {
                string message = $"Description: {ev.Description}\nCreated by: {ev.CreatorName}";
                MessageBox.Show(message, "Event Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdateFontSize(Label label)
        {
            if (label.Text.Length > 150)
            {
                label.Font = new Font("Yu Gothic", 8);
            }
            else if (label.Text.Length > 80)
            {
                label.Font = new Font("Yu Gothic", 12);
            }
            else
            {
                label.Font = new Font("Yu Gothic", 14);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Button deleteButton = (Button)sender;
            Event evToDelete = (Event)deleteButton.Tag;
            RemoveEvent(evToDelete);
        }

        private void RemoveEvent(Event ev)
        {
            events.Remove(ev);
            SaveEvents();
            DisplayEvents();
        }

        private void DateTimeLabel_Click(object sender, EventArgs e)
        {
            OpenCalendarForm();
        }

        private void OpenCalendarForm()
        {
            using (CalendarForm calendarForm = new CalendarForm())
            {
                if (calendarForm.ShowDialog() == DialogResult.OK)
                {
                    selectedDate = calendarForm.SelectedDate;
                    UpdateDateLabel();
                }
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainForm mainform = new MainForm(CurrentUser.LoggedInUser);
            this.Close();
            mainform.Show();
        }

        private void AddEvent_Click(object sender, EventArgs e)
        {
            OpenAddEventForm();
        }

        private void OpenAddEventForm()
        {
            using (AddEventForm addEventForm = new AddEventForm(selectedDate))
            {
                if (addEventForm.ShowDialog() == DialogResult.OK)
                {
                    NewEvent(addEventForm.EventDescription);
                }
            }
        }

        private void NewEvent(string description)
        {
            if (events.Count(ev => ev.Date.Date == selectedDate.Date) < MaxEventsPerDay)
            {
                string truncatedDescription = (description.Length > 300) ? description.Substring(0, 300) + "..." : description;

                Event newEvent = new Event(selectedDate, description, CurrentUser.LoggedInUser.Name);
                events.Add(newEvent);
                SaveEvents();
                DisplayEvents();
            }
            else
            {
                MessageBox.Show("You have reached the limit of events per day.\nTry another day.");
            }
        }

        private void SaveEvents()
        {
            string json = JsonConvert.SerializeObject(events, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        private void LoadEvents()
        {
            events = new List<Event>();
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                events = JsonConvert.DeserializeObject<List<Event>>(json);
            }
        }

        private void ScheduleForm_Load(object sender, EventArgs e)
        {
            selectedDate = DateTime.Today;
            LoadEvents();
            UpdateDateLabel();
        }
    }
}
