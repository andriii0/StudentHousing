namespace StudentApp1
{
    public partial class MainForm : Form
    {
        public MainForm(User authenticatedUser)
        {
            InitializeComponent();
            UpdateHelloText();
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
            NoteDisplayForm noteDisplayForm = new NoteDisplayForm(CurrentUser.LoggedInUser);
            this.Close();
            noteDisplayForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Complaints_Click(object sender, EventArgs e)
        {
            Complaints complaints = new Complaints();
            this.Close();
            complaints.Show();
        }

        private void ToDo_Click(object sender, EventArgs e)
        {
            ToDoForm toDoForm = new ToDoForm(CurrentUser.LoggedInUser);
            this.Close();
            toDoForm.Show();
        }
    }
}