using MyFirstAppVueling.EntityStudent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MyFirstAppVueling.While
{
    public partial class frmWhile : Form
    {
        public frmWhile()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Student student = new Student();   
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
        }
    }
}
