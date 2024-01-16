using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using StudentHousing;
using Button = System.Windows.Forms.Button;



namespace StudentApp1
{
    public partial class AdminForm : Form
    {
        private string roomsFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\rooms.json");
        private string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\users.json");
        private string messageFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\AnnouncementMessage.json");
        public string ComplaintsJson = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\complaints.json");
        private UserDatabase userDatabase;
        private List<Room> rooms = new List<Room>();
        private List<string> complaints = new List<string>();


        public AdminForm()
        {
            InitializeComponent();
            LoadUserData();
            rooms = LoadRoomsFromJson();
            InitializeRooms();

        }
        private void InitializeRooms()
        {
            for (int i = 1; i <= 10; i++)
            {
                rooms.Add(new Room(i));
            }
        }

        private void LoadUserData()
        {
            if (File.Exists(jsonFilePath))
            {
                string json = File.ReadAllText(jsonFilePath);
                userDatabase = JsonConvert.DeserializeObject<UserDatabase>(json);
                if (userDatabase != null && userDatabase.Users != null)
                {
                    return;
                }
            }
            userDatabase = new UserDatabase { Users = new List<User>() };
        }


        private void SaveUserData()
        {
            string json = JsonConvert.SerializeObject(userDatabase);
            File.WriteAllText(jsonFilePath, json);

            SaveRoomsToJson();
        }

        private void SaveTextToJsonFile(string text, string filePath)
        {
            try
            {
                string existingJson = File.Exists(filePath) ? File.ReadAllText(filePath) : "";
                List<string> messages = JsonConvert.DeserializeObject<List<string>>(existingJson) ?? new List<string>();
                messages.Add(text);
                string updatedJson = JsonConvert.SerializeObject(messages, Formatting.Indented);
                File.WriteAllText(filePath, updatedJson);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving text to JSON file: {ex.Message}");
            }
        }

        private void LogOut()
        {
            LoginForm loginForm = new LoginForm();
            this.Close();
            loginForm.Show();
        }

        private void LogOutLabel1_Click(object sender, EventArgs e)
        {
            LogOut();
        }

        private void LogOutLabel2_Click(object sender, EventArgs e)
        {
            LogOut();
        }

        private void LogOutLabel3_Click(object sender, EventArgs e)
        {
            LogOut();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public class UserDatabase
        {
            public List<User> Users { get; set; }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) ||
                string.IsNullOrEmpty(textBox2.Text) ||
                string.IsNullOrEmpty(textBox3.Text) ||
                string.IsNullOrEmpty(textBox4.Text) ||
                string.IsNullOrEmpty(textBox5.Text) ||
                string.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            User newUser = new User
            {
                Id = userDatabase.Users.Count,
                Name = textBox1.Text,
                Username = textBox2.Text,
                Age = int.Parse(textBox3.Text),
                Email = textBox4.Text,
                Password = textBox5.Text,
                Room = int.Parse(textBox6.Text)
            };
            int roomNumber = int.Parse(textBox6.Text);
            if (rooms[roomNumber - 1].GetUsersInRoom().Count == 0)
            {
                rooms[roomNumber - 1].AssignTasksRandomly();
            }
            rooms[roomNumber - 1].Register(newUser);


            userDatabase.Users.Add(newUser);
            SaveUserData();

            MessageBox.Show("User has been added!");

        }
        private void sendAnnouncement_btn_Click(object sender, EventArgs e)
        {
            string textToSave = textBox7.Text;
            string currentTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string textWithTime = $"{textToSave}          Time: {currentTime}";
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), messageFilePath);

            SaveTextToJsonFile(textWithTime, filePath);

            MessageBox.Show("Saved to JSON file!");
        }
        private void SaveRoomsToJson()
        {
            string json = JsonConvert.SerializeObject(rooms);
            File.WriteAllText(roomsFilePath, json);
        }
        private List<Room> LoadRoomsFromJson()
        {
            try
            {
                if (File.Exists(roomsFilePath))
                {
                    string jsonText = File.ReadAllText(roomsFilePath);

                    if (!string.IsNullOrWhiteSpace(jsonText))
                    {
                        List<Room> loadedRooms = JsonConvert.DeserializeObject<List<Room>>(jsonText);

                        if (loadedRooms != null)
                        {
                            return loadedRooms;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так при чтении файла комнат: " + ex.Message);
            }

            return new List<Room>();
        }
        private void LoadComplaintsFromJson()
        {
            if (File.Exists(ComplaintsJson))
            {
                string json = File.ReadAllText(ComplaintsJson);
                complaints = JsonConvert.DeserializeObject<List<string>>(json) ?? new List<string>();
            }
        }

        private void DisplayLatestComplaints(List<string> complaints)
        {
            Panel complaintsContainer = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
            };

            ComplaintsPanel.Controls.Clear();
            ComplaintsPanel.Controls.Add(complaintsContainer);

            int startIndex = Math.Max(0, complaints.Count - 4);

            for (int i = 0; i < complaints.Count; i++)
            {
                string complaint = complaints[i];

                Panel complaintPanel = new Panel
                {
                    Dock = DockStyle.Top,
                    AutoSize = true,
                    Margin = new Padding(0, 0, 0, 10),
                };

                Button deleteButton = new Button
                {
                    Text = "Delete",
                    Tag = complaint,
                    Font = new Font("Arial", 10, FontStyle.Regular),
                    BackColor = Color.White,

            };

                deleteButton.Click += DeleteComplaintButton_Click;

                Label label = new Label
                {
                    Text = $"{i + 1}. {TruncateText(complaint, 200)}",
                    AutoSize = true,
                    MaximumSize = new Size(400 - deleteButton.Width - 10, 0),
                    Font = new Font("Arial", 12, FontStyle.Regular),
                    ForeColor = Color.White,
                };

                label.Location = new Point(0, 0);

                label.Click += (sender, e) => ShowComplaintDetails(complaint);

                complaintPanel.Controls.Add(label);

                deleteButton.Location = new Point(Math.Min(label.Right + 10, 400 - deleteButton.Width), 0);
                complaintPanel.Controls.Add(deleteButton);

                complaintsContainer.Controls.Add(complaintPanel);
            }

            Panel spacerPanel = new Panel
            {
                Height = 20,
                Dock = DockStyle.Top,
            };

            Panel bottomSpacerPanel = new Panel
            {
                Height = 20,
                Dock = DockStyle.Bottom,
            };

            complaintsContainer.Controls.Add(spacerPanel);
        }

        private void ShowComplaintDetails(string complaint)
        {
            string message = $"Complaint: {complaint}";
            MessageBox.Show(message, "Complaint Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void DeleteComplaintButton_Click(object sender, EventArgs e)
        {
            Button deleteButton = (Button)sender;
            string complaintToDelete = (string)deleteButton.Tag;
            RemoveComplaint(complaintToDelete);
        }

        private void RemoveComplaint(string complaint)
        {
            complaints.Remove(complaint);
            SaveComplaintsToJson(); 
            DisplayLatestComplaints(complaints);
        }

        private void SaveComplaintsToJson()
        {
            try
            {
                string json = JsonConvert.SerializeObject(complaints);
                File.WriteAllText(ComplaintsJson, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving complaints to JSON file: {ex.Message}");
            }
        }


        private string TruncateText(string text, int maxLength)
        {
            if (text.Length > maxLength)
            {
                return text.Substring(0, maxLength) + "...";
            }
            return text;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            LoadComplaintsFromJson();
            DisplayLatestComplaints(complaints);
        }
    }
}
