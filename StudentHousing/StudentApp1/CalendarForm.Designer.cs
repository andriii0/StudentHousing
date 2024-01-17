namespace StudentHousing
{
    partial class CalendarForm
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
            monthCalendar1 = new MonthCalendar();
            btnOK = new Button();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.BackColor = Color.LightCoral;
            monthCalendar1.CalendarDimensions = new Size(2, 2);
            monthCalendar1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            monthCalendar1.Location = new Point(5, 9);
            monthCalendar1.Margin = new Padding(13, 15, 13, 15);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            monthCalendar1.TitleBackColor = Color.MediumPurple;
            monthCalendar1.TitleForeColor = Color.SkyBlue;
            monthCalendar1.DateSelected += monthCalendar1_DateSelected;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(121, 537);
            btnOK.Margin = new Padding(4, 5, 4, 5);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(206, 80);
            btnOK.TabIndex = 1;
            btnOK.Text = "Choose date";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // CalendarForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(470, 652);
            Controls.Add(btnOK);
            Controls.Add(monthCalendar1);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CalendarForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CalendarForm";
            ResumeLayout(false);
        }


        #endregion

        private MonthCalendar monthCalendar1;
        private Button btnOK;
    }
}