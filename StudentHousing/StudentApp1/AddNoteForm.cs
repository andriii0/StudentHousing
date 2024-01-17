using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace StudentApp1
{
    public partial class AddNoteForm : Form
    {
        private readonly Room userRoom;
        private readonly User creator;

        public AddNoteForm(Room room, User creator)
        {
            InitializeComponent();
            userRoom = room;
            this.creator = creator;
        }


        private void SaveRoomToJson()
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

                currentRoom.Notes = userRoom.Notes;
                string updatedJson = JsonConvert.SerializeObject(rooms, Formatting.Indented);
                File.WriteAllText(roomsFilePath, updatedJson);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving room to JSON file: {ex.Message}");
            }
        }

        private void btnAddNote_Click_1(object sender, EventArgs e)
        {
            string noteContent = textBoxNote.Text;

            if (!string.IsNullOrEmpty(noteContent))
            {
                Note newNote = new Note(noteContent, creator);
                userRoom.Notes.Add(newNote);

                SaveRoomToJson();

                MessageBox.Show("Note added successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a note before adding.");
            }
        }

    }
}
