namespace StudentApp1
{
    partial class Rules
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

        string Name = "Andrii";
        string Surname = "Matviienko";

        private void InitializeComponent()
        {
            AcceptButton = new Button();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // AcceptButton
            // 
            AcceptButton.BackColor = Color.White;
            AcceptButton.Font = new Font("Segoe UI", 14.25F);
            AcceptButton.Location = new Point(635, 396);
            AcceptButton.Name = "AcceptButton";
            AcceptButton.Size = new Size(136, 42);
            AcceptButton.TabIndex = 9;
            AcceptButton.Text = "Accept";
            AcceptButton.UseVisualStyleBackColor = false;
            AcceptButton.Click += AcceptButton_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.White;
            richTextBox1.Font = new Font("Georgia", 14.25F);
            richTextBox1.Location = new Point(65, 74);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(642, 294);
            richTextBox1.TabIndex = 10;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cambria", 14.25F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(286, 30);
            label1.Name = "label1";
            label1.Size = new Size(223, 22);
            label1.TabIndex = 11;
            label1.Text = "Please, follow rules below!";
            // 
            // Rules
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImage = StudentHousing.Properties.Resources._22;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(AcceptButton);
            Name = "Rules";
            Text = "Rules";
            Load += Rules_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button AcceptButton;
        private RichTextBox richTextBox1;
        private Label label1;
    }
}