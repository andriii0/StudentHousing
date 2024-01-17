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
            AcceptButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AcceptButton.BackColor = Color.White;
            AcceptButton.Font = new Font("Segoe UI", 14.25F);
            AcceptButton.Location = new Point(1134, 891);
            AcceptButton.Margin = new Padding(4, 5, 4, 5);
            AcceptButton.Name = "AcceptButton";
            AcceptButton.Size = new Size(194, 70);
            AcceptButton.TabIndex = 9;
            AcceptButton.Text = "Accept";
            AcceptButton.UseVisualStyleBackColor = false;
            AcceptButton.Click += AcceptButton_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.None;
            richTextBox1.BackColor = Color.White;
            richTextBox1.Font = new Font("Georgia", 14.25F);
            richTextBox1.Location = new Point(216, 265);
            richTextBox1.Margin = new Padding(4, 5, 4, 5);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(915, 487);
            richTextBox1.TabIndex = 10;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cambria", 14.25F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(523, 66);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(339, 34);
            label1.TabIndex = 11;
            label1.Text = "Please, follow rules below!";
            // 
            // Rules
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImage = StudentHousing.Properties.Resources._22;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1378, 994);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(AcceptButton);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Rules";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
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