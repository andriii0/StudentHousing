﻿namespace StudentHousing
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
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // DateTimeLabel
            // 
            DateTimeLabel.AutoSize = true;
            DateTimeLabel.BackColor = Color.White;
            DateTimeLabel.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold);
            DateTimeLabel.Location = new Point(112, 55);
            DateTimeLabel.Margin = new Padding(4, 0, 4, 0);
            DateTimeLabel.Name = "DateTimeLabel";
            DateTimeLabel.Size = new Size(161, 78);
            DateTimeLabel.TabIndex = 0;
            DateTimeLabel.Text = "Date";
            DateTimeLabel.Click += DateTimeLabel_Click;
            // 
            // LeftLabel
            // 
            LeftLabel.AutoSize = true;
            LeftLabel.BackColor = Color.White;
            LeftLabel.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold);
            LeftLabel.Location = new Point(27, 55);
            LeftLabel.Margin = new Padding(4, 0, 4, 0);
            LeftLabel.Name = "LeftLabel";
            LeftLabel.Size = new Size(67, 78);
            LeftLabel.TabIndex = 1;
            LeftLabel.Text = "<";
            LeftLabel.Click += LeftLabel_Click;
            // 
            // RightLabel
            // 
            RightLabel.AutoSize = true;
            RightLabel.BackColor = Color.White;
            RightLabel.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold);
            RightLabel.Location = new Point(609, 55);
            RightLabel.Margin = new Padding(4, 0, 4, 0);
            RightLabel.Name = "RightLabel";
            RightLabel.Size = new Size(67, 78);
            RightLabel.TabIndex = 2;
            RightLabel.Text = ">";
            RightLabel.Click += RightLabel_Click;
            // 
            // AddEvent
            // 
            AddEvent.Location = new Point(39, 100);
            AddEvent.Margin = new Padding(4, 5, 4, 5);
            AddEvent.Name = "AddEvent";
            AddEvent.Size = new Size(176, 77);
            AddEvent.TabIndex = 4;
            AddEvent.Text = "Add an event";
            AddEvent.UseVisualStyleBackColor = true;
            AddEvent.Click += AddEvent_Click;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(39, 5);
            BackBtn.Margin = new Padding(4, 5, 4, 5);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(176, 72);
            BackBtn.TabIndex = 5;
            BackBtn.Text = "Go Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // eventsPanel
            // 
            eventsPanel.Anchor = AnchorStyles.None;
            eventsPanel.Location = new Point(311, 277);
            eventsPanel.Margin = new Padding(4, 5, 4, 5);
            eventsPanel.Name = "eventsPanel";
            eventsPanel.Size = new Size(801, 508);
            eventsPanel.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(LeftLabel);
            panel1.Controls.Add(DateTimeLabel);
            panel1.Controls.Add(RightLabel);
            panel1.Location = new Point(322, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(732, 198);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(BackBtn);
            panel2.Controls.Add(AddEvent);
            panel2.Location = new Point(23, 22);
            panel2.Name = "panel2";
            panel2.Size = new Size(255, 205);
            panel2.TabIndex = 8;
            // 
            // ScheduleForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.abstract_bluish_paint_background_wallpaper;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1378, 994);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(eventsPanel);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ScheduleForm";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ScheduleForm";
            Load += ScheduleForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label DateTimeLabel;
        private Label LeftLabel;
        private Label RightLabel;
        private Button AddEvent;
        private Button BackBtn;
        private Panel eventsPanel;
        private Panel panel1;
        private Panel panel2;
    }
}