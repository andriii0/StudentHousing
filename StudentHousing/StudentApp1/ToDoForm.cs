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
            // Clear ListBox before adding new tasks
            listBoxTasks.Items.Clear();

            foreach (Task task in tasks)
            {
                // Formulate a string for display in the list
                string taskString = $"{task.GetTaskId()}. {task.GetDescription()} - {task.GetDateTime()}";

                // Add the string to the ListBox
                listBoxTasks.Items.Add(taskString);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            // Go back to the MainForm when closing ToDoForm
            MainForm mainForm = new MainForm(currentUser);
            this.Close();
            mainForm.Show();
        }
    }
}
