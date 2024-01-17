using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousing
{
    public class MessageFormat
    {
        public string SenderName { get; set; }
        public string CurrentTime { get; set; }
        public string TextToSave { get; set; }
        public string Status { get; set; } 
        public string ImportantOrNot { get; set; }

        public MessageFormat()
        {
            Status = "Unread"; 
            ImportantOrNot = "Not Important";
        }

        
    }
}
