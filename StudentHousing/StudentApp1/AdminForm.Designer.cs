namespace StudentApp1
{
    partial class AdminForm
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
            tabPage2 = new TabPage();
            sendAnnouncement_btn = new Button();
            textBox7 = new TextBox();
            LogOutLabel2 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel6 = new Panel();
            textBox6 = new TextBox();
            label7 = new Label();
            panel5 = new Panel();
            textBox5 = new TextBox();
            label6 = new Label();
            panel4 = new Panel();
            textBox4 = new TextBox();
            label5 = new Label();
            panel3 = new Panel();
            textBox3 = new TextBox();
            label4 = new Label();
            panel2 = new Panel();
            textBox2 = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            RegisterButton = new Button();
            LogOutLabel1 = new Label();
            tabPage3 = new TabPage();
            LogOutLabel3 = new Label();
            ComplaintsPanel = new Panel();
            tabPage4 = new TabPage();
            textBoxDescr = new TextBox();
            btnAddTask = new Button();
            numericUpDownRoom = new NumericUpDown();
            btnUpdateTasks = new Button();
            tabPage2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRoom).BeginInit();
            SuspendLayout();
            // 
            // tabPage2
            // 
            tabPage2.BackgroundImage = StudentHousing.Properties.Resources.watercolor_texture_background_light_gray_wallpaper;
            tabPage2.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage2.Controls.Add(sendAnnouncement_btn);
            tabPage2.Controls.Add(textBox7);
            tabPage2.Controls.Add(LogOutLabel2);
            tabPage2.Location = new Point(4, 40);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(656, 405);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Announcements";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // sendAnnouncement_btn
            // 
            sendAnnouncement_btn.Location = new Point(188, 330);
            sendAnnouncement_btn.Margin = new Padding(3, 2, 3, 2);
            sendAnnouncement_btn.Name = "sendAnnouncement_btn";
            sendAnnouncement_btn.Size = new Size(295, 34);
            sendAnnouncement_btn.TabIndex = 11;
            sendAnnouncement_btn.Text = "Send an announcement";
            sendAnnouncement_btn.UseVisualStyleBackColor = true;
            sendAnnouncement_btn.Click += sendAnnouncement_btn_Click;
            // 
            // textBox7
            // 
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Location = new Point(75, 50);
            textBox7.Margin = new Padding(3, 2, 3, 2);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(516, 203);
            textBox7.TabIndex = 10;
            // 
            // LogOutLabel2
            // 
            LogOutLabel2.AutoSize = true;
            LogOutLabel2.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold);
            LogOutLabel2.ForeColor = Color.Black;
            LogOutLabel2.Location = new Point(553, 3);
            LogOutLabel2.Name = "LogOutLabel2";
            LogOutLabel2.Size = new Size(100, 29);
            LogOutLabel2.TabIndex = 9;
            LogOutLabel2.Text = "Log Out";
            LogOutLabel2.Click += LogOutLabel2_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Font = new Font("Sitka Small", 15.75F);
            tabControl1.Location = new Point(1, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(664, 449);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Transparent;
            tabPage1.BackgroundImage = StudentHousing.Properties.Resources.abstract_bluish_paint_background_wallpaper;
            tabPage1.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage1.Controls.Add(panel6);
            tabPage1.Controls.Add(panel5);
            tabPage1.Controls.Add(panel4);
            tabPage1.Controls.Add(panel3);
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(RegisterButton);
            tabPage1.Controls.Add(LogOutLabel1);
            tabPage1.Location = new Point(4, 40);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(656, 405);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Register";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.Controls.Add(textBox6);
            panel6.Controls.Add(label7);
            panel6.Location = new Point(386, 117);
            panel6.Name = "panel6";
            panel6.Size = new Size(210, 49);
            panel6.TabIndex = 16;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(111, 9);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(86, 34);
            textBox6.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 6);
            label7.Name = "label7";
            label7.Size = new Size(102, 31);
            label7.TabIndex = 12;
            label7.Text = "Room№";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.Controls.Add(textBox5);
            panel5.Controls.Add(label6);
            panel5.Location = new Point(16, 263);
            panel5.Name = "panel5";
            panel5.Size = new Size(540, 49);
            panel5.TabIndex = 16;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(117, 6);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(420, 34);
            textBox5.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 6);
            label6.Name = "label6";
            label6.Size = new Size(116, 31);
            label6.TabIndex = 12;
            label6.Text = "Password";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(textBox4);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(16, 196);
            panel4.Name = "panel4";
            panel4.Size = new Size(465, 49);
            panel4.TabIndex = 15;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(84, 6);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(366, 34);
            textBox4.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 6);
            label5.Name = "label5";
            label5.Size = new Size(75, 31);
            label5.TabIndex = 12;
            label5.Text = "Email";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(352, 55);
            panel3.Name = "panel3";
            panel3.Size = new Size(167, 49);
            panel3.TabIndex = 15;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(61, 6);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(86, 34);
            textBox3.TabIndex = 10;
            textBox3.KeyPress += textBox3_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 6);
            label4.Name = "label4";
            label4.Size = new Size(52, 31);
            label4.TabIndex = 12;
            label4.Text = "Age";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(16, 126);
            panel2.Name = "panel2";
            panel2.Size = new Size(340, 49);
            panel2.TabIndex = 14;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(131, 6);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(199, 34);
            textBox2.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 6);
            label3.Name = "label3";
            label3.Size = new Size(122, 31);
            label3.TabIndex = 12;
            label3.Text = "Username";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(16, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(291, 49);
            panel1.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(84, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(199, 34);
            textBox1.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(3, 6);
            label2.Name = "label2";
            label2.Size = new Size(75, 31);
            label2.TabIndex = 12;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Small", 15.75F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(16, 12);
            label1.Name = "label1";
            label1.Size = new Size(405, 31);
            label1.TabIndex = 11;
            label1.Text = "To register a new user, please, type";
            // 
            // RegisterButton
            // 
            RegisterButton.BackColor = Color.Snow;
            RegisterButton.Location = new Point(264, 318);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Padding = new Padding(1);
            RegisterButton.Size = new Size(182, 61);
            RegisterButton.TabIndex = 9;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = false;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // LogOutLabel1
            // 
            LogOutLabel1.AutoSize = true;
            LogOutLabel1.BackColor = Color.Transparent;
            LogOutLabel1.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold);
            LogOutLabel1.ForeColor = Color.GhostWhite;
            LogOutLabel1.Location = new Point(545, 13);
            LogOutLabel1.Name = "LogOutLabel1";
            LogOutLabel1.Size = new Size(100, 29);
            LogOutLabel1.TabIndex = 8;
            LogOutLabel1.Text = "Log Out";
            LogOutLabel1.Click += LogOutLabel1_Click;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.LightPink;
            tabPage3.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage3.Controls.Add(LogOutLabel3);
            tabPage3.Controls.Add(ComplaintsPanel);
            tabPage3.Location = new Point(4, 40);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(656, 405);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Complaints";
            // 
            // LogOutLabel3
            // 
            LogOutLabel3.AutoSize = true;
            LogOutLabel3.BackColor = Color.Transparent;
            LogOutLabel3.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold);
            LogOutLabel3.ForeColor = Color.GhostWhite;
            LogOutLabel3.Location = new Point(531, 0);
            LogOutLabel3.Name = "LogOutLabel3";
            LogOutLabel3.Size = new Size(100, 29);
            LogOutLabel3.TabIndex = 9;
            LogOutLabel3.Text = "Log Out";
            LogOutLabel3.Click += LogOutLabel3_Click;
            // 
            // ComplaintsPanel
            // 
            ComplaintsPanel.Location = new Point(79, 32);
            ComplaintsPanel.Name = "ComplaintsPanel";
            ComplaintsPanel.Size = new Size(528, 378);
            ComplaintsPanel.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(textBoxDescr);
            tabPage4.Controls.Add(btnAddTask);
            tabPage4.Controls.Add(numericUpDownRoom);
            tabPage4.Controls.Add(btnUpdateTasks);
            tabPage4.Location = new Point(4, 40);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(656, 405);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Household duties";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // textBoxDescr
            // 
            textBoxDescr.Location = new Point(65, 101);
            textBoxDescr.Name = "textBoxDescr";
            textBoxDescr.Size = new Size(120, 34);
            textBoxDescr.TabIndex = 4;
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(65, 172);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(165, 45);
            btnAddTask.TabIndex = 3;
            btnAddTask.Text = "Add Task to the room";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // numericUpDownRoom
            // 
            numericUpDownRoom.Location = new Point(65, 29);
            numericUpDownRoom.Name = "numericUpDownRoom";
            numericUpDownRoom.Size = new Size(120, 34);
            numericUpDownRoom.TabIndex = 1;
            // 
            // btnUpdateTasks
            // 
            btnUpdateTasks.Location = new Point(194, 270);
            btnUpdateTasks.Name = "btnUpdateTasks";
            btnUpdateTasks.Size = new Size(292, 56);
            btnUpdateTasks.TabIndex = 0;
            btnUpdateTasks.Text = "Update Weekly Tasks";
            btnUpdateTasks.UseVisualStyleBackColor = true;
            btnUpdateTasks.Click += btnUpdateTasks_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 459);
            Controls.Add(tabControl1);
            Name = "AdminForm";
            Text = "AdminForm";
            Load += AdminForm_Load;
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRoom).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label LogOutLabel1;
        private Label LogOutLabel2;
        private Button RegisterButton;
        private Panel panel1;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private TextBox textBox2;
        private Label label3;
        private Panel panel3;
        private TextBox textBox3;
        private Label label4;
        private Panel panel4;
        private TextBox textBox4;
        private Label label5;
        private Panel panel5;
        private TextBox textBox5;
        private Label label6;
        private Panel panel6;
        private TextBox textBox6;
        private Label label7;
        private Button sendAnnouncement_btn;
        private TextBox textBox7;
        private TabPage tabPage3;
        private Panel ComplaintsPanel;
        private Label LogOutLabel3;
        private TabPage tabPage4;
        private Button btnUpdateTasks;
        private TextBox textBoxDescr;
        private Button btnAddTask;
        private NumericUpDown numericUpDownRoom;
    }
}