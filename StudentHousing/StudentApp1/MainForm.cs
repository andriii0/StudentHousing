using StudentHousing;

namespace StudentApp1
{
    public partial class MainForm : Form
    {
        private User AuthenticatedUser { get; set; }

        public MainForm(User authenticatedUser)
        {
            InitializeComponent();
            this.AuthenticatedUser = authenticatedUser; 

            UpdateHelloText();

            Announcements.MouseEnter += Announcements_MouseEnter;
            Announcements.MouseLeave += Announcements_MouseLeave;
            Rules.MouseEnter += Rules_MouseEnter;
            Rules.MouseLeave += Rules_MouseLeave;
            Notes.MouseEnter += Notes_MouseEnter;
            Notes.MouseLeave += Notes_MouseLeave;
            Complaints.MouseEnter += Complaints_MouseEnter;
            Complaints.MouseLeave += Complaints_MouseLeave;
            ToDo.MouseEnter += ToDo_MouseEnter;
            ToDo.MouseLeave += ToDo_MouseLeave;
            Schedule.MouseEnter += Schedule_MouseEnter;
            Schedule.MouseLeave += Schedule_MouseLeave;
            LogOutLabel.MouseEnter += LogOutLabel_MouseEnter;
            LogOutLabel.MouseLeave += LogOutLabel_MouseLeave;

        }

        private void UpdateHelloText()
        {
            HelloText.Text = $"Hello! {CurrentUser.LoggedInUser.Name} :)";
        }

        private void Announcements_Click(object sender, EventArgs e)
        {
            Announcements announcements = new Announcements();
            this.Hide();
            announcements.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Close();
            loginForm.Show();
        }

        private void Rules_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rules rules = new Rules();
            rules.Show();
        }
        private void Notes_Click(object sender, EventArgs e)
        {
            NoteDisplayForm noteDisplayForm = new NoteDisplayForm(AuthenticatedUser, AuthenticatedUser.UserRoom);
            this.Close();
            noteDisplayForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Complaints_Click(object sender, EventArgs e)
        {
            Complaints complaints = new Complaints(CurrentUser.LoggedInUser, AuthenticatedUser.UserRoom);
            this.Close();
            complaints.Show();
        }

        private void ToDo_Click(object sender, EventArgs e)
        {
            ToDoForm toDoForm = new ToDoForm(AuthenticatedUser, AuthenticatedUser.UserRoom);
            this.Close();
            toDoForm.Show();
        }

        private void Schedule_Click(object sender, EventArgs e)
        {
            ScheduleForm scheduleForm = new ScheduleForm(CurrentUser.LoggedInUser);
            scheduleForm.Show();
            this.Close();
        }

        //Hover functionality
        private void Announcements_MouseEnter(object sender, EventArgs e)
        {
            Announcements.BackColor = System.Drawing.Color.LightCoral;
            Announcements.ForeColor = System.Drawing.Color.White;
        }

        private void Announcements_MouseLeave(object sender, EventArgs e)
        {
            Announcements.BackColor = System.Drawing.SystemColors.Control;
            Announcements.ForeColor = System.Drawing.Color.Black;
        }

        private void Rules_MouseEnter(object sender, EventArgs e)
        {
            Rules.BackColor = System.Drawing.Color.LightCoral;
            Rules.ForeColor = System.Drawing.Color.White;
        }

        private void Rules_MouseLeave(object sender, EventArgs e)
        {
            Rules.BackColor = System.Drawing.SystemColors.Control;
            Rules.ForeColor = System.Drawing.Color.Black;
        }

        private void Notes_MouseEnter(object sender, EventArgs e)
        {
            Notes.BackColor = System.Drawing.Color.LightCoral;
            Notes.ForeColor = System.Drawing.Color.White;
        }

        private void Notes_MouseLeave(object sender, EventArgs e)
        {
            Notes.BackColor = System.Drawing.SystemColors.Control;
            Notes.ForeColor = System.Drawing.Color.Black;
        }

        private void Complaints_MouseEnter(object sender, EventArgs e)
        {
            Complaints.BackColor = System.Drawing.Color.LightCoral;
            Complaints.ForeColor = System.Drawing.Color.White;
        }

        private void Complaints_MouseLeave(object sender, EventArgs e)
        {
            Complaints.BackColor = System.Drawing.SystemColors.Control;
            Complaints.ForeColor = System.Drawing.Color.Black;
        }

        private void ToDo_MouseEnter(object sender, EventArgs e)
        {
            ToDo.BackColor = System.Drawing.Color.LightCoral;
            ToDo.ForeColor = System.Drawing.Color.White;
        }

        private void ToDo_MouseLeave(object sender, EventArgs e)
        {
            ToDo.BackColor = System.Drawing.SystemColors.Control;
            ToDo.ForeColor = System.Drawing.Color.Black;
        }

        private void Schedule_MouseEnter(object sender, EventArgs e)
        {
            Schedule.BackColor = System.Drawing.Color.LightCoral;
            Schedule.ForeColor = System.Drawing.Color.White;
        }

        private void Schedule_MouseLeave(object sender, EventArgs e)
        {
            Schedule.BackColor = System.Drawing.SystemColors.Control;
            Schedule.ForeColor = System.Drawing.Color.Black;
        }
        private void LogOutLabel_MouseEnter(object sender, EventArgs e)
        {
            LogOutLabel.ForeColor = System.Drawing.Color.LightCoral;
        }

        private void LogOutLabel_MouseLeave(object sender, EventArgs e)
        {
            LogOutLabel.ForeColor = System.Drawing.Color.White;
        }

    }
}