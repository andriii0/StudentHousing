namespace StudentApp1
{
    partial class NoteDisplayForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BackButton = new Button();
            AddNotes = new Button();
            NotesPanel = new Panel();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.Location = new Point(8, 24);
            BackButton.Margin = new Padding(2);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(112, 49);
            BackButton.TabIndex = 1;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // AddNotes
            // 
            AddNotes.Location = new Point(820, 25);
            AddNotes.Margin = new Padding(2);
            AddNotes.Name = "AddNotes";
            AddNotes.Size = new Size(122, 49);
            AddNotes.TabIndex = 2;
            AddNotes.Text = "Add a note";
            AddNotes.UseVisualStyleBackColor = true;
            AddNotes.Click += AddNotes_Click;
            // 
            // NotesPanel
            // 
            NotesPanel.Location = new Point(132, 111);
            NotesPanel.Name = "NotesPanel";
            NotesPanel.Size = new Size(810, 364);
            NotesPanel.TabIndex = 7;
            // 
            // NoteDisplayForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = StudentHousing.Properties.Resources._4853433;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1007, 514);
            Controls.Add(NotesPanel);
            Controls.Add(AddNotes);
            Controls.Add(BackButton);
            Margin = new Padding(2);
            Name = "NoteDisplayForm";
            Text = "NoteDisplayForm";
            ResumeLayout(false);
        }

        #endregion
        private Button BackButton;
        private Button AddNotes;
        private Panel NotesPanel;
    }
}