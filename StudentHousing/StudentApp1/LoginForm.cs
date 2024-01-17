using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using static StudentApp1.AdminForm;

namespace StudentApp1
{
    public partial class LoginForm : Form
    {
        private readonly string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\users.json");
        private readonly string roomsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\rooms.json");


        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            UserDatabase userDatabase = LoadUsersFromJson();

            bool isAuthenticated = false;
            bool isAdmin = false;
            int roomNumber = 0;

            foreach (User user in userDatabase.Users)
            {
                if ((user.Username == username && user.Password == password) || (user.Email == username && user.Password == password))
                {
                    isAuthenticated = true;

                    user.UserRoom = LoadRoomsFromJson().FirstOrDefault(room => room.Users.Any(u => u.Id == user.Id));

                    CurrentUser.LoggedInUser = user;

                    if (user.Username == "admin" && user.Password == "admin")
                    {
                        isAdmin = true;
                        break;
                    }
                }
            }

            if (isAuthenticated)
            {
                User authenticatedUser = CurrentUser.LoggedInUser;

                if (!isAdmin)
                {
                    MainForm form1 = new MainForm(authenticatedUser);
                    this.Hide();
                    form1.Show();
                }
                else
                {
                    AdminForm adminForm = new AdminForm();
                    this.Hide();
                    adminForm.Show();
                }
            }
            else MessageBox.Show("Error logging in");
        }
        private UserDatabase LoadUsersFromJson()
        {
            try
            {
                List<Room> rooms = LoadRoomsFromJson();  // Load rooms only once

                string jsonText = File.ReadAllText(filePath);
                UserDatabase userDatabase = JsonConvert.DeserializeObject<UserDatabase>(jsonText);

                if (userDatabase != null && userDatabase.Users != null)
                {
                    foreach (User user in userDatabase.Users)
                    {
                        // Find the user's room and associate it with the user
                        user.UserRoom = rooms.FirstOrDefault(room => room.Users.Any(u => u.Id == user.Id));
                    }

                    return userDatabase;
                }
                else
                {
                    return new UserDatabase { Users = new List<User>() };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong with reading file: " + ex.Message);
                return new UserDatabase { Users = new List<User>() };
            }
        }

        // Add this method to load rooms
        private List<Room> LoadRoomsFromJson()
        {
            try
            {
                if (File.Exists(roomsPath))
                {
                    string jsonText = File.ReadAllText(roomsPath);
                    List<Room> loadedRooms = JsonConvert.DeserializeObject<List<Room>>(jsonText);

                    if (loadedRooms != null)
                    {
                        return loadedRooms;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong with reading room file: " + ex.Message);
            }

            return new List<Room>();
        }
    }
}
