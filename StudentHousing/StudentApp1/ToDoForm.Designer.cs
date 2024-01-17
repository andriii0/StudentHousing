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
            buttonClose.Location = new Point(359, 298);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 23);
            buttonClose.TabIndex = 1;
            buttonClose.Text = "button1";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // checkedListBoxTasks
            // 
            checkedListBoxTasks.FormattingEnabled = true;
            checkedListBoxTasks.Location = new Point(178, 132);
            checkedListBoxTasks.Name = "checkedListBoxTasks";
            checkedListBoxTasks.Size = new Size(474, 130);
            checkedListBoxTasks.TabIndex = 2;
            // 
            // ToDoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = StudentHousing.Properties.Resources.c15;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(checkedListBoxTasks);
            Controls.Add(buttonClose);
            Name = "ToDoForm";
            Text = "ToDoForm";
            ResumeLayout(false);
        }

        #endregion
        private Button buttonClose;
        private CheckedListBox checkedListBoxTasks;
    }
}