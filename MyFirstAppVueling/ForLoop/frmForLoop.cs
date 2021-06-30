using MyFirstAppVueling.EntityStudent;
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

namespace MyFirstAppVueling.ForLoop
{
    public partial class frmForLoop : Form
    {
        public frmForLoop()
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
            //Generic Collectioins
            var studentList = new List<Student>(); // recommended
            studentList.Add(student);

            var students = new Dictionary<Guid, Student>();
            students.Add(student.Guid, student);

            int _i = 0;
            while (_i < students.Count)
            {
                KeyValuePair<Guid, Student> entry = students.ElementAt(_i);
                if (entry.Value.Name.Equals("Pepe"))
                {
                    _ = MessageBox.Show("Pepe is found: " + entry.Value.Name +
                       " is welcome, and his Guid is " +
                       entry.Value.Guid.ToString());
                }
                _i++;
            }

            for (int i = 0; i < studentList.Count; i++)
            {
                MessageBox.Show(studentList[i].Name);
            }
            foreach (var _student in studentList)
            {
                //Unboxing-Polymorphism
                MessageBox.Show(((Student)_student).Name +
                    " " + ((Student)_student).Surname +
                    " " + ((Student)_student).Age);
            }
        }
    }
}
