using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp1
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public int Age { get; set; }
        public int Room { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Room UserRoom { get; set; }
    }
}