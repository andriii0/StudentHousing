using System.Windows.Forms;

namespace StudentApp1
{
    partial class LoginForm
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
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            LoginButton = new Button();
            SuspendLayout();
            // 
            // usernameTextBox
            // 
            usernameTextBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTextBox.Location = new Point(77, 222);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.PlaceholderText = "Name or Email";
            usernameTextBox.Size = new Size(261, 39);
            usernameTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.Location = new Point(77, 343);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.PlaceholderText = "Password";
            passwordTextBox.Size = new Size(261, 39);
            passwordTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Yu Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(144, 67);
            label1.Name = "label1";
            label1.Size = new Size(128, 31);
            label1.TabIndex = 2;
            label1.Text = "Welcome! ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(77, 162);
            label2.Name = "label2";
            label2.Size = new Size(261, 31);
            label2.TabIndex = 3;
            label2.Text = "Please, type your login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(91, 288);
            label3.Name = "label3";
            label3.Size = new Size(226, 31);
            label3.TabIndex = 4;
            label3.Text = "And your password";
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.Snow;
            LoginButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LoginButton.Location = new Point(77, 412);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(261, 50);
            LoginButton.TabIndex = 5;
            LoginButton.Text = "Log in";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = StudentHousing.Properties.Resources.rm222_mind_20;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(430, 608);
            Controls.Add(LoginButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button LoginButton;
    }
}