namespace StudentApp1
{
    partial class ToDoForm
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
            buttonClose = new Button();
            checkedListBoxTasks = new CheckedListBox();
            SuspendLayout();
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(9, 8);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(101, 37);
            buttonClose.TabIndex = 1;
            buttonClose.Text = "Back";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // checkedListBoxTasks
            // 
            checkedListBoxTasks.Anchor = AnchorStyles.None;
            checkedListBoxTasks.FormattingEnabled = true;
            checkedListBoxTasks.Location = new Point(61, 97);
            checkedListBoxTasks.Name = "checkedListBoxTasks";
            checkedListBoxTasks.Size = new Size(542, 364);
            checkedListBoxTasks.TabIndex = 2;
            // 
            // ToDoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = StudentHousing.Properties.Resources.c15;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(680, 537);
            Controls.Add(checkedListBoxTasks);
            Controls.Add(buttonClose);
            Name = "ToDoForm";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ToDoForm";
            ResumeLayout(false);
        }

        #endregion
        private Button buttonClose;
        private CheckedListBox checkedListBoxTasks;
    }
}