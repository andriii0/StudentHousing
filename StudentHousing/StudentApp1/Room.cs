using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StudentApp1
{
    public class Room
    {
        private int taskIdCounter = 1;
        public int RoomNumber { get; set; }
        public List<User> Users { get; set; } = new List<User>();
        public List<Task> Tasks { get; set; } = new List<Task>();
        public List<Note> Notes { get; set; } = new List<Note>();


        public Room(int roomNumber)
        {
            RoomNumber = roomNumber;
        }
        public void Register(User user)
        {
            Users.Add(user);
        }

        public List<User> GetUsersInRoom()
        {
            return Users;
        }
        public void AssignTasksRandomly()
        {

            Array taskTypes = Enum.GetValues(typeof(TaskType));

            foreach (TaskType taskType in taskTypes)
            {
                Task newTask = new Task(GetNextTaskId(), $"Perform {taskType} task", DateTime.Now.AddDays(7), taskType);
                Tasks.Add(newTask);
            }
        }

        private int GetNextTaskId()
        {
            return taskIdCounter++;
        }

    }
}