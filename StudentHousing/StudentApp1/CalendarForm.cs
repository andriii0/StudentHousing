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

            btnOK.MouseEnter += btnOK_MouseEnter;
            btnOK.MouseLeave += btnOK_MouseLeave;
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            selectedDate = e.Start;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }

        public DateTime SelectedDate
        {
            get { return selectedDate; }
        }

        //Hover functionality
        private void btnOK_MouseEnter(object sender, EventArgs e)
        {
            btnOK.BackColor = System.Drawing.Color.LightCoral;
            btnOK.ForeColor = System.Drawing.Color.White;
        }
        private void btnOK_MouseLeave(object sender, EventArgs e)
        {
            btnOK.BackColor = System.Drawing.SystemColors.Control;
            btnOK.ForeColor = System.Drawing.Color.Black;
        }
    }
}
