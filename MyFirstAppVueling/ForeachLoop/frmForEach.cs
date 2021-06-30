using System;
using System.Collections;
using System.Windows.Forms;

namespace MyFirstAppVueling.EntityStudent
{
    public partial class frmForEach : Form
    {
        public frmForEach()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var student = new Student(); //good practice in method
            student.StudentId = Convert.ToInt32(textStudentId.Text);
            student.Name = textName.Text;
            student.Surname = textSurname.Text;
            student.Age = Convert.ToInt32(textAge.Text);
            //Boxing-Polymorphism
            var studentList = new ArrayList(); // recommended
            studentList.Add(student);
            
            foreach(var _student in studentList)
            {
                //Unboxing-Polymorphism
                MessageBox.Show(((Student)_student).Name +
                    " " + ((Student)_student).Surname +
                    " " + ((Student)_student).Age);
            }
        }

        private void textSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textStudentId_TextChanged(object sender, EventArgs e)
        {

        }

        private void textAge_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
