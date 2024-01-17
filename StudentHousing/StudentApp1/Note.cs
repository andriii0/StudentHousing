using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace StudentApp1
{
    public class Note
    {
        public string Content { get; set; }
        [JsonIgnore]
        public User Creator { get; set; } 

        public Note(string content, User creator)
        {
            Content = content;
            Creator = creator;
        }
    }
}
