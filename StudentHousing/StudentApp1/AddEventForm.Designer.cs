namespace StudentHousing
{
    partial class AddEventForm
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
            descriptionTextBox = new TextBox();
            addButton = new Button();
            LeftLabel = new Label();
            RightLabel = new Label();
            dateLabel = new Label();
            SuspendLayout();
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Font = new Font("Yu Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            descriptionTextBox.Location = new Point(28, 102);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(297, 41);
            descriptionTextBox.TabIndex = 1;
            // 
            // addButton
            // 
            addButton.BackColor = Color.White;
            addButton.Location = new Point(114, 198);
            addButton.Name = "addButton";
            addButton.Size = new Size(119, 37);
            addButton.TabIndex = 2;
            addButton.Text = "Add an event";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // LeftLabel
            // 
            LeftLabel.AutoSize = true;
            LeftLabel.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold);
            LeftLabel.Location = new Point(15, 9);
            LeftLabel.Name = "LeftLabel";
            LeftLabel.Size = new Size(45, 51);
            LeftLabel.TabIndex = 3;
            LeftLabel.Text = "<";
            LeftLabel.Click += LeftLabel_Click;
            // 
            // RightLabel
            // 
            RightLabel.AutoSize = true;
            RightLabel.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold);
            RightLabel.Location = new Point(308, 9);
            RightLabel.Name = "RightLabel";
            RightLabel.Size = new Size(45, 51);
            RightLabel.TabIndex = 4;
            RightLabel.Text = ">";
            RightLabel.Click += RightLabel_Click;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold);
            dateLabel.Location = new Point(59, 9);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(108, 51);
            dateLabel.TabIndex = 5;
            dateLabel.Text = "Date";
            dateLabel.Click += dateLabel_Click;
            // 
            // AddEventForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(365, 282);
            Controls.Add(dateLabel);
            Controls.Add(RightLabel);
            Controls.Add(LeftLabel);
            Controls.Add(addButton);
            Controls.Add(descriptionTextBox);
            Name = "AddEventForm";
            Text = "AddEventForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox descriptionTextBox;
        private Button addButton;
        private Label LeftLabel;
        private Label RightLabel;
        private Label dateLabel;
    }
}