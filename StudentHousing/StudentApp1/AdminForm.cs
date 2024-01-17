<<<<<<< Updated upstream
﻿using System;
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
            if (rooms.Count == 0)
            {
                InitializeRooms();
                SaveRoomsToJson();
            }
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
                Height = 40,
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

        private void btnUpdateTasks_Click(object sender, EventArgs e)
        {
            foreach (Room room in rooms)
            {
                room.AssignTasksRandomly();
            }

            SaveRoomsToJson();
            MessageBox.Show("Tasks assigned randomly to all rooms.");
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            int roomNumber = (int)numericUpDownRoom.Value;
            Room selectedRoom = rooms.FirstOrDefault(room => room.RoomNumber == roomNumber);

            if (selectedRoom != null)
            {
                string taskDescription = textBoxDescr.Text;
                DateTime taskDateTime = DateTime.Now.AddDays(7);
                TaskType taskType = TaskType.Other;

                selectedRoom.AddTask(taskDescription, taskDateTime, taskType);
                SaveRoomsToJson();
                MessageBox.Show("Task added to the selected room.");
            }
            else
            {
                MessageBox.Show("Invalid room number. Please enter a valid room number.");
            }
        }
    }
}
=======
﻿using System;
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
            if (rooms.Count == 0)
            {
                InitializeRooms();
                SaveRoomsToJson();
            }
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

            string newUsername = textBox2.Text;
            string newEmail = textBox4.Text;

            if (IsUsernameTaken(newUsername))
            {
                MessageBox.Show("Username already exists. Please choose a different one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsEmailTaken(newEmail))
            {
                MessageBox.Show("Email already exists. Please use a different one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(textBox6.Text, out int enteredRoomNumber) || enteredRoomNumber < 1 || enteredRoomNumber > 10)
            {
                MessageBox.Show("Invalid room number. Please enter a number between 1 and 10.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User newUser = new User
            {
                Id = userDatabase.Users.Count,
                Name = textBox1.Text,
                Username = newUsername,
                Age = int.Parse(textBox3.Text),
                Email = newEmail,
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

        private bool IsUsernameTaken(string username)
        {
            return userDatabase.Users.Any(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase));
        }

        private bool IsEmailTaken(string email)
        {
            return userDatabase.Users.Any(u => u.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
        }
        private void sendAnnouncement_btn_Click(object sender, EventArgs e)
        {
            string senderName = CurrentUser.LoggedInUser.Username;
            string currentTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string textToSave = sendAnnouncementAdminTextBox.Text;

            if (!string.IsNullOrEmpty(sendAnnouncementAdminTextBox.Text))
            {
                MessageFormat message = new MessageFormat
                {
                    SenderName = senderName,
                    CurrentTime = currentTime,
                    TextToSave = textToSave
                };

                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), messageFilePath);

                SaveMessageToJsonFile(message, filePath);

                MessageBox.Show("Announcement has been sent successfully");
                sendAnnouncementAdminTextBox.Clear();
            }

            else
            {
                MessageBox.Show("There was no input");
            }
        }
        private void SaveMessageToJsonFile(MessageFormat message, string filePath)
        {
            try
            {
                string existingJson = File.Exists(filePath) ? File.ReadAllText(filePath) : "";
                List<MessageFormat> messages = JsonConvert.DeserializeObject<List<MessageFormat>>(existingJson) ?? new List<MessageFormat>();
                messages.Add(message);
                string updatedJson = JsonConvert.SerializeObject(messages, Formatting.Indented);
                File.WriteAllText(filePath, updatedJson);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving message to JSON file: {ex.Message}");
            }
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
                MessageBox.Show("Something went wrong with reading json file:  " + ex.Message);
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
                Height = 40,
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

        private void btnUpdateTasks_Click(object sender, EventArgs e)
        {
            foreach (Room room in rooms)
            {
                room.AssignTasksRandomly();
            }

            SaveRoomsToJson();
            MessageBox.Show("Tasks assigned randomly to all rooms.");
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            int roomNumber = (int)numericUpDownRoom.Value;
            Room selectedRoom = rooms.FirstOrDefault(room => room.RoomNumber == roomNumber);

            if (selectedRoom != null)
            {
                string taskDescription = textBoxDescr.Text;
                DateTime taskDateTime = DateTime.Now.AddDays(7);
                TaskType taskType = TaskType.Other;

                Task addedTask = new Task
                {
                    Description = taskDescription,
                    DateTime = taskDateTime,
                    TaskType = taskType,
                    IsCompleted = false
                };

                addedTasks.Add(addedTask);

                selectedRoom.AddTask(taskDescription, taskDateTime, taskType);
                SaveRoomsToJson();
                MessageBox.Show("Task added to the selected room.");
            }
            else
            {
                MessageBox.Show("Invalid room number. Please enter a valid room number.");
            }
        }

        private List<Task> addedTasks = new List<Task>();

        private void DisplayAddedTasks()
        {
            addedTasksPanel.Controls.Clear();

            foreach (Task addedTask in addedTasks)
            {
                Panel taskPanel = new Panel
                {
                    Dock = DockStyle.Top,
                    AutoSize = true,
                    Margin = new Padding(0, 0, 0, 10),
                };

                Label label = new Label
                {
                    Text = addedTask.Description,
                    AutoSize = true,
                    Font = new Font("Arial", 12, FontStyle.Regular),
                    ForeColor = Color.Black,
                };

                Button deleteButton = new Button
                {
                    Text = "Delete",
                    Tag = addedTask,
                    Font = new Font("Arial", 10, FontStyle.Regular),
                    BackColor = Color.White,
                };

                deleteButton.Click += DeleteAddedTaskButton_Click;

                taskPanel.Controls.Add(label);
                taskPanel.Controls.Add(deleteButton);

                addedTasksPanel.Controls.Add(taskPanel);
            }
        }

        private void DeleteAddedTaskButton_Click(object sender, EventArgs e)
        {
            Button deleteButton = (Button)sender;
            Task taskToDelete = (Task)deleteButton.Tag;
            RemoveAddedTask(taskToDelete);
        }

        private void RemoveAddedTask(Task task)
        {
            addedTasks.Remove(task);
            DisplayAddedTasks();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
>>>>>>> Stashed changes
