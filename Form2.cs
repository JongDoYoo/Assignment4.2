using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4._2
{
    public partial class Form2 : Form
    {   
        Student newStudent = new Student();                 //instantiate student class here to use    //we created a object named newStudent. Now we use the object to create new students. 
                                                            //remember Student is a new data type we created in order to access all the properties of that data
        public Form2()
        {
            InitializeComponent();
        }

        private void LogOnBtn_Click(object sender, EventArgs e)
        {
            if (StudentIDTextBox.Text != "")
            {
                newStudent.StudentID = StudentIDTextBox.Text;
            }
            else
            {
                MessageBox.Show("Please enter student ID");         //"MessageBox.Show" shows message 
            }
            if (StudentNametextBox.Text != "")
            {
                newStudent.StudentName = StudentNametextBox.Text;
            }
            else
            {
                MessageBox.Show("Please enter student Name");
            }
            if (GPATextBox.Text != "")
            {
                newStudent.GPA = Convert.ToDouble(GPATextBox.Text);  //Convert to double bc thats the data type I used in student class for GPA
            }
            else
            {
                MessageBox.Show("Please enter student GPA");
            }
            Program.studentlist.Add(newStudent);                                 //this is going to add student to the student list I instantiated on line 15

            StudentIDTextBox.Text= "";
            StudentNametextBox.Text = "";
            GPATextBox.Text = "";
        }




        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();                   //this just exits the program
        }
       

        private void SavetoFileButton_Click(object sender, EventArgs e)
        {
           
            using StreamWriter sw = new StreamWriter("C:\\MSSA-CCAD14\\Assignment4.2.txt");
            foreach (Student student in Program.studentlist)
            {
                sw.WriteLine($"{student.StudentName}, {student.StudentID}, {student.GPA}");
                //Program is the class its coming from and studentlist is where its intantiated. Hence Program.studenlist
                
            }
            sw.Close();
        }

        private void DeleteStudentButton_Click(object sender, EventArgs e)
        {

        }
    }
}
