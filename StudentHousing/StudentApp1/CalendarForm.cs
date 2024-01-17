using System;
using System.Windows.Forms;

namespace StudentHousing
{
    public partial class CalendarForm : Form
    {
        private DateTime selectedDate;

        public CalendarForm()
        {
            InitializeComponent();
            selectedDate = DateTime.Today;
            monthCalendar1.SelectionStart = selectedDate;
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            selectedDate = e.Start;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public DateTime SelectedDate
        {
            get { return selectedDate; }
        }
    }
}
