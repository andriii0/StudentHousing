using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace StudentApp1
{
    public partial class NoteDisplayForm : Form
    {
        private readonly User currentUser;
        private readonly Room userRoom;
        private List<Note> notes;

        public NoteDisplayForm(User user, Room room)
        {
            InitializeComponent();
            currentUser = user;
            userRoom = room;
            LoadNotesForCurrentUserRoom();
        }

        private void LoadNotesForCurrentUserRoom()
        {
            if (userRoom != null)
            {
                notes = userRoom.Notes;

                DisplayLatestNotes(notes);
            }
            else
            {
                MessageBox.Show("User is not assigned to any room.");
            }
        }


        private void DisplayLatestNotes(List<Note> notes)
        {
            Panel notesContainer = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
            };

            NotesPanel.Controls.Clear();
            NotesPanel.Controls.Add(notesContainer);

            int startIndex = Math.Max(0, notes.Count - 4);

            for (int i = startIndex, noteNumber = 1; i < notes.Count; i++, noteNumber++)
            {
                Note note = notes[i];
                User currentUser = CurrentUser.LoggedInUser;

                Panel notePanel = new Panel
                {
                    Dock = DockStyle.Top,
                    AutoSize = true,
                    Margin = new Padding(0, 0, 0, 10),
                };

                Label label = new Label
                {
                    Text = $"{noteNumber}. {TruncateText(note.Content, 500)}",
                    AutoSize = true,
                    MaximumSize = new Size(400, 0),
                    Font = new Font("Arial", 12, FontStyle.Regular),
                };

                Button deleteButton = new Button
                {
                    Text = "Delete",
                    Tag = note,
                    Font = new Font("Arial", 10, FontStyle.Regular),
                };

                deleteButton.Click += DeleteNoteButton_Click;

                label.Location = new Point(0, 0);
                notePanel.Controls.Add(label);

                if (label.Right > 400)
                {
                    label.MaximumSize = new Size(400 - deleteButton.Width - 10, 0);
                    deleteButton.Location = new Point(label.Right + 10, 0);
                    notePanel.Controls.Add(deleteButton);
                }
                else
                {
                    deleteButton.Location = new Point(label.Right + 10, 0);
                    notePanel.Controls.Add(label);
                    notePanel.Controls.Add(deleteButton);
                }

                label.Click += (sender, e) => ShowNoteDetails(note);

                notesContainer.Controls.Add(notePanel);
            }

            Panel spacerPanel = new Panel
            {
                Height = 20,
                Dock = DockStyle.Top,
            };

            notesContainer.Controls.Add(spacerPanel);
        }






        private string TruncateText(string text, int maxLength)
        {
            if (text.Length > maxLength)
            {
                return text.Substring(0, maxLength) + "...";
            }
            return text;
        }

        private void ShowNoteDetails(Note note)
        {
            string creatorName = (note.Creator != null) ? note.Creator.Name : "Unknown";

            string message = $"Description: {note.Content}\nCreated by: {creatorName}";
            MessageBox.Show(message, "Note Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }






        private void DeleteNoteButton_Click(object sender, EventArgs e)
        {
            Button deleteButton = (Button)sender;
            Note noteToDelete = (Note)deleteButton.Tag;
            RemoveNote(noteToDelete);
        }

        private void RemoveNote(Note note)
        {
            notes.Remove(note);
            DisplayLatestNotes(notes); 
        }




        private void BackButton_Click(object sender, EventArgs e)
        {
            MainForm form1 = new MainForm(currentUser);
            this.Close();
            form1.Show();
        }

        private void AddNotes_Click(object sender, EventArgs e)
        {
            AddNoteForm addNotesForm = new AddNoteForm(userRoom, currentUser);
            addNotesForm.ShowDialog();

            LoadNotesForCurrentUserRoom();
        }
    }
}
