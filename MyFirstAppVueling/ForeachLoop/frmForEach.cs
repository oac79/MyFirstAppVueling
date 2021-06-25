using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstAppVueling.ForeachLoop
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
    }
}
