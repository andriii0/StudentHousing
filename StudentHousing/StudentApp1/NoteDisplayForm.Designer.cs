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
            BackButton.Location = new Point(11, 40);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(160, 82);
            BackButton.TabIndex = 1;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // AddNotes
            // 
            AddNotes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddNotes.Location = new Point(1171, 42);
            AddNotes.Name = "AddNotes";
            AddNotes.Size = new Size(174, 82);
            AddNotes.TabIndex = 2;
            AddNotes.Text = "Add a note";
            AddNotes.UseVisualStyleBackColor = true;
            AddNotes.Click += AddNotes_Click;
            // 
            // NotesPanel
            // 
            NotesPanel.Anchor = AnchorStyles.None;
            NotesPanel.Location = new Point(103, 230);
            NotesPanel.Margin = new Padding(4, 5, 4, 5);
            NotesPanel.Name = "NotesPanel";
            NotesPanel.Size = new Size(1157, 607);
            NotesPanel.TabIndex = 7;
            // 
            // NoteDisplayForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = StudentHousing.Properties.Resources._4853433;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1378, 994);
            Controls.Add(NotesPanel);
            Controls.Add(AddNotes);
            Controls.Add(BackButton);
            Name = "NoteDisplayForm";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NoteDisplayForm";
            ResumeLayout(false);
        }

        #endregion
        private Button BackButton;
        private Button AddNotes;
        private Panel NotesPanel;
    }
}