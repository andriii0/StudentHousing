namespace StudentApp1
{
    partial class AddNoteForm
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
            label1 = new Label();
            textBoxNote = new RichTextBox();
            btnAddNote = new Button();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.Location = new Point(16, 20);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(123, 50);
            BackButton.TabIndex = 1;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Yu Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(218, 108);
            label1.Name = "label1";
            label1.Size = new Size(202, 38);
            label1.TabIndex = 4;
            label1.Text = "Adding a note";
            // 
            // textBoxNote
            // 
            textBoxNote.BackColor = Color.White;
            textBoxNote.BorderStyle = BorderStyle.None;
            textBoxNote.Location = new Point(54, 229);
            textBoxNote.Name = "textBoxNote";
            textBoxNote.Size = new Size(533, 260);
            textBoxNote.TabIndex = 5;
            textBoxNote.Text = "";
            // 
            // btnAddNote
            // 
            btnAddNote.Location = new Point(234, 544);
            btnAddNote.Margin = new Padding(4, 5, 4, 5);
            btnAddNote.Name = "btnAddNote";
            btnAddNote.Size = new Size(201, 97);
            btnAddNote.TabIndex = 6;
            btnAddNote.Text = "Add note";
            btnAddNote.UseVisualStyleBackColor = true;
            btnAddNote.Click += btnAddNote_Click_1;
            // 
            // AddNoteForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            BackgroundImage = StudentHousing.Properties.Resources.v463_aum_69_abstractbackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(640, 855);
            Controls.Add(btnAddNote);
            Controls.Add(textBoxNote);
            Controls.Add(label1);
            Controls.Add(BackButton);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddNoteForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddNoteForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BackButton;
        private Label label1;
        private RichTextBox textBoxNote;
        private Button btnAddNote;
    }
}