    using Microsoft.VisualBasic.ApplicationServices;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace StudentApp1
    {
        public enum TaskType
        {
            Bathroom,
            Kitchen,
            Hallway,
            Clothes,
            Garbage,
            Dishes,
            Paper
        }

        public class Task
        {

            public int taskId;
            public string description;
            public DateTime dateTime;
            public TaskType TaskType { get; private set; } 

            public Task(int taskId, string description, DateTime dateTime, TaskType tasks)
            {
                this.taskId = taskId;
                this.description = description;
                this.dateTime = dateTime;
                this.TaskType = tasks;
            }
            public TaskType GetTasks()
            {
                return this.TaskType;
            }
            public int GetTaskId()
            {
                return this.taskId;
            }
            public string GetDescription()
            {
                return this.description;
            }
            public DateTime GetDateTime()
            {
                return this.dateTime;
            }

        }
    }