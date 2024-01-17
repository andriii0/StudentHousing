using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StudentApp1
{
    public partial class ToDoForm : Form
    {
        private readonly User currentUser;
        private readonly Room userRoom;

        public ToDoForm(User user, Room room)
        {
            InitializeComponent();
            currentUser = user;
            userRoom = room;
            LoadTasksForCurrentUserRoom();

            buttonClose.MouseEnter += ButtonClose_MouseEnter;
            buttonClose.MouseLeave += ButtonClose_MouseLeave;
        }

        private void LoadTasksForCurrentUserRoom()
        {
            if (userRoom != null)
            {
                List<Task> tasksForRoom = userRoom.Tasks;

                DisplayTasks(tasksForRoom);
            }
            else
            {
                MessageBox.Show("User is not assigned to any room.");
            }
        }

        private void DisplayTasks(List<Task> tasks)
        {
            checkedListBoxTasks.Items.Clear();

            foreach (Task task in tasks)
            {
                string taskString = $"{task.GetTaskId()}. {task.GetDescription()} - {task.GetDateTime()}";

                checkedListBoxTasks.Items.Add(taskString, task.IsCompleted);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < userRoom.Tasks.Count; i++)
            {
                userRoom.Tasks[i].IsCompleted = checkedListBoxTasks.GetItemChecked(i);
            }
            SaveRoom1ToJson();
            MainForm mainForm = new MainForm(currentUser);
            this.Close();
            mainForm.Show();
        }
        private void SaveRoom1ToJson()
        {
            string roomsFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\rooms.json");

            try
            {
                string existingJson = File.Exists(roomsFilePath) ? File.ReadAllText(roomsFilePath) : "";

                List<Room> rooms = JsonConvert.DeserializeObject<List<Room>>(existingJson) ?? new List<Room>();

                Room currentRoom = rooms.FirstOrDefault(r => r.RoomNumber == userRoom.RoomNumber);
                if (currentRoom == null)
                {
                    currentRoom = new Room(userRoom.RoomNumber);
                    rooms.Add(currentRoom);
                }

                currentRoom.Tasks = userRoom.Tasks;

                int index = rooms.FindIndex(r => r.RoomNumber == currentRoom.RoomNumber);
                if (index != -1)
                {
                    rooms[index] = currentRoom;
                }
                else
                {
                    rooms.Add(currentRoom);
                }

                string updatedJson = JsonConvert.SerializeObject(rooms, Formatting.Indented);
                File.WriteAllText(roomsFilePath, updatedJson);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving room to JSON file: {ex.Message}");
            }
        }

        //Hover functionality
        private void ButtonClose_MouseEnter(object sender, EventArgs e)
        {
            buttonClose.BackColor = System.Drawing.Color.LightCoral;
            buttonClose.ForeColor = System.Drawing.Color.White;
        }

        private void ButtonClose_MouseLeave(object sender, EventArgs e)
        {
            buttonClose.BackColor = System.Drawing.SystemColors.Control;
            buttonClose.ForeColor = System.Drawing.Color.Black;
        }
    }
}
