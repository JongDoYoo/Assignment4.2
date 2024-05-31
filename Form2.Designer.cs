namespace Assignment4._2
{
    partial class Form2
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
            AddStudentButton = new Button();
            label = new Label();
            StudentIDTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            StudentNametextBox = new TextBox();
            GPATextBox = new TextBox();
            ExitButton = new Button();
            listView1 = new ListView();
            DeleteStudentButton = new Button();
            SavetoFileButton = new Button();
            SuspendLayout();
            // 
            // AddStudentButton
            // 
            AddStudentButton.Location = new Point(198, 198);
            AddStudentButton.Name = "AddStudentButton";
            AddStudentButton.Size = new Size(115, 34);
            AddStudentButton.TabIndex = 12;
            AddStudentButton.Text = "Add Student";
            AddStudentButton.UseVisualStyleBackColor = true;
            AddStudentButton.Click += LogOnBtn_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(36, 42);
            label.Name = "label";
            label.Size = new Size(59, 15);
            label.TabIndex = 13;
            label.Text = "StudentID";
            // 
            // StudentIDTextBox
            // 
            StudentIDTextBox.Location = new Point(113, 39);
            StudentIDTextBox.Name = "StudentIDTextBox";
            StudentIDTextBox.Size = new Size(200, 23);
            StudentIDTextBox.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 96);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 15;
            label2.Text = "Student Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 155);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 16;
            label3.Text = "GPA";
            // 
            // StudentNametextBox
            // 
            StudentNametextBox.Location = new Point(113, 93);
            StudentNametextBox.Name = "StudentNametextBox";
            StudentNametextBox.Size = new Size(200, 23);
            StudentNametextBox.TabIndex = 17;
            // 
            // GPATextBox
            // 
            GPATextBox.Location = new Point(113, 152);
            GPATextBox.Name = "GPATextBox";
            GPATextBox.Size = new Size(200, 23);
            GPATextBox.TabIndex = 18;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(704, 415);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(75, 23);
            ExitButton.TabIndex = 19;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(343, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(436, 369);
            listView1.TabIndex = 20;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // DeleteStudentButton
            // 
            DeleteStudentButton.Location = new Point(343, 399);
            DeleteStudentButton.Name = "DeleteStudentButton";
            DeleteStudentButton.Size = new Size(116, 39);
            DeleteStudentButton.TabIndex = 21;
            DeleteStudentButton.Text = "Delete Student";
            DeleteStudentButton.UseVisualStyleBackColor = true;
            DeleteStudentButton.Click += DeleteStudentButton_Click;
            // 
            // SavetoFileButton
            // 
            SavetoFileButton.Location = new Point(478, 399);
            SavetoFileButton.Name = "SavetoFileButton";
            SavetoFileButton.Size = new Size(110, 39);
            SavetoFileButton.TabIndex = 22;
            SavetoFileButton.Text = "Save to File";
            SavetoFileButton.UseVisualStyleBackColor = true;
            SavetoFileButton.Click += SavetoFileButton_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SavetoFileButton);
            Controls.Add(DeleteStudentButton);
            Controls.Add(listView1);
            Controls.Add(ExitButton);
            Controls.Add(GPATextBox);
            Controls.Add(StudentNametextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(StudentIDTextBox);
            Controls.Add(label);
            Controls.Add(AddStudentButton);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button AddStudentButton;
        private Label label;
        private TextBox StudentIDTextBox;
        private Label label2;
        private Label label3;
        private TextBox StudentNametextBox;
        private TextBox GPATextBox;
        private Button ExitButton;
        private ListView listView1;
        private Button DeleteStudentButton;
        private Button SavetoFileButton;
    }
}