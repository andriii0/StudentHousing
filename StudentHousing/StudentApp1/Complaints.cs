using Newtonsoft.Json;
using StudentHousing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
namespace StudentApp1
{
    public partial class Complaints : Form
    {
        public string ComplaintsJson = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\complaints.json");
        private readonly User currentUser;
        private readonly Room userRoom;

        private List<string> complaints = new List<string>();


        public Complaints(User user, Room room)
        {
            InitializeComponent();
            currentUser = user;
            userRoom = room;

            complaints = new List<string>();
        }

        private void Complaints_Load(object sender, EventArgs e)
        {

        }

        private void ComplaintBtn_Click(object sender, EventArgs e)
        {
            string complaintText = ComplaintsTextBox.Text;
            string complaintWithInfo = $"{CurrentUser.LoggedInUser.Name} - Room {userRoom.RoomNumber}: {complaintText}";

            if (!string.IsNullOrEmpty(complaintText))
            {
                complaints.Add(complaintWithInfo);
                ComplaintsTextBox.Clear();

                SaveComplaintsToJson();

                MessageBox.Show("Your complaint has been uploaded!");
            }
            else
            {
                MessageBox.Show("Please enter a complaint before uploading.");
            }
        }

        private void SaveComplaintsToJson()
        {
            string json = JsonConvert.SerializeObject(complaints, Formatting.Indented);
            File.WriteAllText(ComplaintsJson, json);
        }


        private void BackButton_Click(object sender, EventArgs e)
        {
            MainForm form1 = new MainForm(currentUser);
            this.Close();
            form1.Show();
        }
    }
}