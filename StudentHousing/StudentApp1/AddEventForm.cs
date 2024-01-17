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

            addButton.MouseEnter += addButton_MouseEnter;
            addButton.MouseLeave += addButton_MouseLeave;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            EventDescription = descriptionTextBox.Text;
            this.DialogResult = DialogResult.OK;
            this.Hide();
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

        //Hover functionality
        private void addButton_MouseEnter(object sender, EventArgs e)
        {
            addButton.BackColor = System.Drawing.Color.LightCoral;
            addButton.ForeColor = System.Drawing.Color.White;
        }

        private void addButton_MouseLeave(object sender, EventArgs e)
        {
            addButton.BackColor = System.Drawing.SystemColors.Control;
            addButton.ForeColor = System.Drawing.Color.Black;
        }
    }
}
