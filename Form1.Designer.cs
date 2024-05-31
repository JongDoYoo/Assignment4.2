namespace Assignment4._2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LogOnButton = new Button();
            label2 = new Label();
            label1 = new Label();
            PasswordTextBox = new TextBox();
            UserIDTextBox = new TextBox();
            SuspendLayout();
            // 
            // LogOnButton
            // 
            LogOnButton.Location = new Point(384, 241);
            LogOnButton.Name = "LogOnButton";
            LogOnButton.Size = new Size(94, 34);
            LogOnButton.TabIndex = 4;
            LogOnButton.Text = "Log on";
            LogOnButton.UseVisualStyleBackColor = true;
            LogOnButton.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(227, 188);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 15;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(237, 120);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 14;
            label1.Text = "User I.D";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(310, 185);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(168, 23);
            PasswordTextBox.TabIndex = 13;
            // 
            // UserIDTextBox
            // 
            UserIDTextBox.Location = new Point(310, 117);
            UserIDTextBox.Name = "UserIDTextBox";
            UserIDTextBox.Size = new Size(168, 23);
            UserIDTextBox.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PasswordTextBox);
            Controls.Add(UserIDTextBox);
            Controls.Add(LogOnButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button LogOnButton;
        private Label label2;
        private Label label1;
        private TextBox PasswordTextBox;
        private TextBox UserIDTextBox;
    }
}
