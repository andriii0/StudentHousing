using Newtonsoft.Json;
using StudentHousing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            this.FormClosing += (sender, e) => Application.Exit();

            currentUser = user;
            userRoom = room;

            complaints = new List<string>();

            BackButton.MouseEnter += BackButton_MouseEnter;
            BackButton.MouseLeave += BackButton_MouseLeave;
            ComplaintBtn.MouseEnter += ComplaintBtn_MouseEnter;
            ComplaintBtn.MouseLeave += ComplaintBtn_MouseLeave;
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
            this.Hide();
            form1.Show();
        }

        //Hover functonality
        private void BackButton_MouseEnter(object sender, EventArgs e)
        {
            BackButton.BackColor = System.Drawing.Color.LightCoral;
            BackButton.ForeColor = System.Drawing.Color.White;
        }

        private void BackButton_MouseLeave(object sender, EventArgs e)
        {
            BackButton.BackColor = System.Drawing.SystemColors.Control;
            BackButton.ForeColor = System.Drawing.Color.Black;
        }
        private void ComplaintBtn_MouseEnter(object sender, EventArgs e)
        {
            ComplaintBtn.BackColor = System.Drawing.Color.LightCoral;
            ComplaintBtn.ForeColor = System.Drawing.Color.White;
        }
        private void ComplaintBtn_MouseLeave(object sender, EventArgs e)
        {
            ComplaintBtn.BackColor = System.Drawing.SystemColors.Control;
            ComplaintBtn.ForeColor = System.Drawing.Color.Black;
        }
    }
}
