namespace StudentApp1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        /// 
        private void InitializeComponent()
        {
            HelloText = new Label();
            Schedule = new Button();
            ToDo = new Button();
            Announcements = new Button();
            Rules = new Button();
            LogOutLabel = new Label();
            Complaints = new Button();
            Notes = new Button();
            SuspendLayout();
            // 
            // HelloText
            // 
            HelloText.AutoSize = true;
            HelloText.BackColor = Color.Transparent;
            HelloText.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold);
            HelloText.ForeColor = Color.WhiteSmoke;
            HelloText.Location = new Point(373, 65);
            HelloText.Name = "HelloText";
            HelloText.Size = new Size(45, 29);
            HelloText.TabIndex = 0;
            HelloText.Text = "Hi!";
            // 
            // Schedule
            // 
            Schedule.BackColor = Color.Snow;
            Schedule.Font = new Font("Sylfaen", 14.25F, FontStyle.Bold);
            Schedule.Location = new Point(520, 217);
            Schedule.Name = "Schedule";
            Schedule.Size = new Size(185, 118);
            Schedule.TabIndex = 2;
            Schedule.Text = "Schedule\r\n";
            Schedule.UseVisualStyleBackColor = false;
            Schedule.Click += Schedule_Click;
            // 
            // ToDo
            // 
            ToDo.BackColor = Color.Snow;
            ToDo.Font = new Font("Sylfaen", 14.25F, FontStyle.Bold);
            ToDo.Location = new Point(306, 217);
            ToDo.Name = "ToDo";
            ToDo.Size = new Size(185, 118);
            ToDo.TabIndex = 3;
            ToDo.Text = "To Do List";
            ToDo.UseVisualStyleBackColor = false;
            ToDo.Click += ToDo_Click;
            // 
            // Announcements
            // 
            Announcements.BackColor = Color.Snow;
            Announcements.Font = new Font("Sylfaen", 14.25F, FontStyle.Bold);
            Announcements.Location = new Point(98, 217);
            Announcements.Name = "Announcements";
            Announcements.Size = new Size(185, 118);
            Announcements.TabIndex = 5;
            Announcements.Text = "Announcements";
            Announcements.UseVisualStyleBackColor = false;
            Announcements.Click += Announcements_Click;
            // 
            // Rules
            // 
            Rules.BackColor = Color.Snow;
            Rules.Font = new Font("Sylfaen", 14.25F, FontStyle.Bold);
            Rules.Location = new Point(306, 372);
            Rules.Name = "Rules";
            Rules.RightToLeft = RightToLeft.Yes;
            Rules.Size = new Size(185, 118);
            Rules.TabIndex = 6;
            Rules.Text = "House Rules";
            Rules.UseVisualStyleBackColor = false;
            Rules.Click += Rules_Click;
            // 
            // LogOutLabel
            // 
            LogOutLabel.AutoSize = true;
            LogOutLabel.BackColor = Color.Transparent;
            LogOutLabel.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold);
            LogOutLabel.ForeColor = Color.GhostWhite;
            LogOutLabel.Location = new Point(688, 65);
            LogOutLabel.Name = "LogOutLabel";
            LogOutLabel.Size = new Size(100, 29);
            LogOutLabel.TabIndex = 7;
            LogOutLabel.Text = "Log Out";
            LogOutLabel.Click += label1_Click;
            // 
            // Complaints
            // 
            Complaints.BackColor = Color.Snow;
            Complaints.Font = new Font("Sylfaen", 14.25F, FontStyle.Bold);
            Complaints.Location = new Point(98, 372);
            Complaints.Name = "Complaints";
            Complaints.Size = new Size(185, 118);
            Complaints.TabIndex = 8;
            Complaints.Text = "Leave a complaints";
            Complaints.UseVisualStyleBackColor = false;
            Complaints.Click += Complaints_Click;
            // 
            // Notes
            // 
            Notes.BackColor = Color.Snow;
            Notes.Font = new Font("Sylfaen", 14.25F, FontStyle.Bold);
            Notes.Location = new Point(520, 372);
            Notes.Name = "Notes";
            Notes.RightToLeft = RightToLeft.Yes;
            Notes.Size = new Size(185, 118);
            Notes.TabIndex = 9;
            Notes.Text = "Notes";
            Notes.UseVisualStyleBackColor = false;
            Notes.Click += Notes_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            BackgroundImage = StudentHousing.Properties.Resources._8ecd7a74040c6137d8db25014de3cfaa;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(845, 638);
            Controls.Add(Notes);
            Controls.Add(Complaints);
            Controls.Add(LogOutLabel);
            Controls.Add(Rules);
            Controls.Add(Announcements);
            Controls.Add(ToDo);
            Controls.Add(Schedule);
            Controls.Add(HelloText);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HelloText;
        private Button Schedule;
        private Button ToDo;
        private Button Announcements;
        private Button Rules;
        private Label LogOutLabel;
        private Button Complaints;
        private Button Notes;
    }
}