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
            Tasks.Clear();

            Array taskTypes = Enum.GetValues(typeof(TaskType));

            foreach (TaskType taskType in taskTypes)
            {
                string taskDescription = GetTaskDescriptionForType(taskType);
                Task newTask = new Task(GetNextTaskId(), taskDescription, DateTime.Now.AddDays(7), taskType);
                Tasks.Add(newTask);
            }
        }
        private string GetTaskDescriptionForType(TaskType taskType)
        {
            switch (taskType)
            {
                case TaskType.Bathroom:
                    return "Clean the bathroom";
                case TaskType.Kitchen:
                    return "Clean the kitchen";
                case TaskType.Hallway:
                    return "Sweep and mop the hallway";
                case TaskType.Clothes:
                    return "Do laundry";
                case TaskType.Garbage:
                    return "Take out the garbage";
                case TaskType.Dishes:
                    return "Wash the dishes";
                case TaskType.Paper:
                    return "Buy toilet paper";
                case TaskType.Other:
                    return "Buy household cleaning products";
                default:
                    return "Perform a task";
            }
        }
        public void AddTask(string description, DateTime dateTime, TaskType taskType)
        {
            int nextTaskId = GetNextTaskId();
            Task newTask = new Task(nextTaskId, description, dateTime, taskType);
            Tasks.Add(newTask);
        }

        public int GetNextTaskId()
        {
            int maxTaskId = Tasks.Count > 0 ? Tasks.Max(task => task.GetTaskId()) : 0;
            return maxTaskId + 1;
        }

    }
}