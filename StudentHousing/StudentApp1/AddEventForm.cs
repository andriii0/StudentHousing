using System;
using System.Windows.Forms;

namespace StudentHousing
{
    public partial class AddEventForm : Form
    {
        public DateTime SelectedDate { get; private set; }
        public string EventDescription { get; private set; }

        public AddEventForm(DateTime selectedDate)
        {
            InitializeComponent();
            SelectedDate = selectedDate;
            dateLabel.Text = selectedDate.ToString("dd.MM.yyyy");
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            EventDescription = descriptionTextBox.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void LeftLabel_Click(object sender, EventArgs e)
        {
            SelectedDate = SelectedDate.AddDays(-1);
            UpdateDateLabel();
        }

        private void RightLabel_Click(object sender, EventArgs e)
        {
            SelectedDate = SelectedDate.AddDays(1);
            UpdateDateLabel();
        }

        private void UpdateDateLabel()
        {
            dateLabel.Text = SelectedDate.ToString("dd.MM.yyyy");
        }

        private void dateLabel_Click(object sender, EventArgs e)
        {
            OpenCalendarForm();
        }

        private void OpenCalendarForm()
        {
            using (CalendarForm calendarForm = new CalendarForm())
            {
                if (calendarForm.ShowDialog() == DialogResult.OK)
                {
                    SelectedDate = calendarForm.SelectedDate;
                    UpdateDateLabel();
                }
            }
        }
    }
}
