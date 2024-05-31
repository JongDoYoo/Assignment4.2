namespace Assignment4._2
{
    public partial class Form1 : Form
    {
        Teacher teacher = new Teacher();       //instantiate teacher class
        Student student = new Student();        //instantiate student class
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            teacher.TeacherName = "Teacher";         //TeacherName is from the Teacher class
            teacher.TeacherPassword = "Admin";        //TeacherPassword is from the Teacher class
            if (teacher.TeacherName == UserIDTextBox.Text && teacher.TeacherPassword == PasswordTextBox.Text)
            {
                //this.Hide();                             //this hides form1
                Form2 studentForm = new Form2();         //intantiate the second form. Pretty much binding the two forms togther. You need to instantiate in order fo you to use it
                studentForm.Show();                        //If I make more forms, I need to instantiate them if I want to use them
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }
        }
    }
}
