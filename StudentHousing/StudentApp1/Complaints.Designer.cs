using System.Windows.Forms;

namespace StudentApp1
{
    partial class Complaints
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
            ComplaintBtn = new Button();
            ComplaintsTextBox = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            BackButton = new Button();
            SuspendLayout();
            // 
            // ComplaintBtn
            // 
            ComplaintBtn.BackColor = Color.White;
            ComplaintBtn.Location = new Point(59, 785);
            ComplaintBtn.Margin = new Padding(4, 5, 4, 5);
            ComplaintBtn.Name = "ComplaintBtn";
            ComplaintBtn.Size = new Size(400, 73);
            ComplaintBtn.TabIndex = 1;
            ComplaintBtn.Text = "Leave a complaint";
            ComplaintBtn.UseVisualStyleBackColor = false;
            ComplaintBtn.Click += ComplaintBtn_Click;
            // 
            // ComplaintsTextBox
            // 
            ComplaintsTextBox.BackColor = Color.White;
            ComplaintsTextBox.BorderStyle = BorderStyle.None;
            ComplaintsTextBox.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ComplaintsTextBox.Location = new Point(20, 212);
            ComplaintsTextBox.Margin = new Padding(4, 5, 4, 5);
            ComplaintsTextBox.Name = "ComplaintsTextBox";
            ComplaintsTextBox.Size = new Size(506, 518);
            ComplaintsTextBox.TabIndex = 2;
            ComplaintsTextBox.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(87, 118);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(376, 36);
            label1.TabIndex = 3;
            label1.Text = "Type your complaint here:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.White;
            label2.Location = new Point(87, 158);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(372, 26);
            label2.TabIndex = 4;
            label2.Text = "administrator will see your complaint";
            // 
            // BackButton
            // 
            BackButton.Location = new Point(16, 18);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(136, 68);
            BackButton.TabIndex = 5;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // Complaints
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = StudentHousing.Properties.Resources.banner_with_abstract_background_with_colorful_paper_cutout_waves;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(573, 913);
            Controls.Add(BackButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ComplaintsTextBox);
            Controls.Add(ComplaintBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Complaints";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Complaints";
            Load += Complaints_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ComplaintBtn;
        private RichTextBox ComplaintsTextBox;
        private Label label1;
        private Label label2;
        private Button BackButton;
    }
}