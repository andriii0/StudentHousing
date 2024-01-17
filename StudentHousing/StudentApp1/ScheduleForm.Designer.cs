namespace StudentHousing
{
    partial class ScheduleForm
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
            DateTimeLabel = new Label();
            LeftLabel = new Label();
            RightLabel = new Label();
            AddEvent = new Button();
            BackBtn = new Button();
            eventsPanel = new Panel();
            SuspendLayout();
            // 
            // DateTimeLabel
            // 
            DateTimeLabel.AutoSize = true;
            DateTimeLabel.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold);
            DateTimeLabel.Location = new Point(268, 21);
            DateTimeLabel.Name = "DateTimeLabel";
            DateTimeLabel.Size = new Size(108, 51);
            DateTimeLabel.TabIndex = 0;
            DateTimeLabel.Text = "Date";
            DateTimeLabel.Click += DateTimeLabel_Click;
            // 
            // LeftLabel
            // 
            LeftLabel.AutoSize = true;
            LeftLabel.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold);
            LeftLabel.Location = new Point(204, 21);
            LeftLabel.Name = "LeftLabel";
            LeftLabel.Size = new Size(45, 51);
            LeftLabel.TabIndex = 1;
            LeftLabel.Text = "<";
            LeftLabel.Click += LeftLabel_Click;
            // 
            // RightLabel
            // 
            RightLabel.AutoSize = true;
            RightLabel.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold);
            RightLabel.Location = new Point(520, 21);
            RightLabel.Name = "RightLabel";
            RightLabel.Size = new Size(45, 51);
            RightLabel.TabIndex = 2;
            RightLabel.Text = ">";
            RightLabel.Click += RightLabel_Click;
            // 
            // AddEvent
            // 
            AddEvent.Location = new Point(12, 63);
            AddEvent.Name = "AddEvent";
            AddEvent.Size = new Size(91, 29);
            AddEvent.TabIndex = 4;
            AddEvent.Text = "Add an event";
            AddEvent.UseVisualStyleBackColor = true;
            AddEvent.Click += AddEvent_Click;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(12, 21);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(91, 29);
            BackBtn.TabIndex = 5;
            BackBtn.Text = "Go Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // eventsPanel
            // 
            eventsPanel.Location = new Point(133, 101);
            eventsPanel.Name = "eventsPanel";
            eventsPanel.Size = new Size(561, 305);
            eventsPanel.TabIndex = 6;
            // 
            // ScheduleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.abstract_bluish_paint_background_wallpaper;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(749, 450);
            Controls.Add(eventsPanel);
            Controls.Add(BackBtn);
            Controls.Add(AddEvent);
            Controls.Add(RightLabel);
            Controls.Add(LeftLabel);
            Controls.Add(DateTimeLabel);
            Name = "ScheduleForm";
            Text = "ScheduleForm";
            Load += ScheduleForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DateTimeLabel;
        private Label LeftLabel;
        private Label RightLabel;
        private Button AddEvent;
        private Button BackBtn;
        private Panel eventsPanel;
    }
}