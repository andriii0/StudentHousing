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



namespace StudentApp1
{
    public partial class AdminForm : Form
    {
        private string roomsFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\rooms.json");
        private string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\users.json");
        private string messageFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\AnnouncementMessage.json");
        private UserDatabase userDatabase;
        private List<Room> rooms = new List<Room>();


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
                MessageBox.Show("There was a Error");
            }

            return new List<Room>();
        }

    }
}
