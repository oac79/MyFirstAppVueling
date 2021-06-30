using MyFirstAppVueling.ForeachLoop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstAppVueling.WhileLoop
{
    public partial class frmWhile : Form
    {
        public frmWhile()
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
            var students = new Dictionary<int, Student>();

            students.Add(student.StudentId, student);

            int i = 0;
            while (i < students.Count)
            {
                KeyValuePair<int, Student> entry = students.ElementAt(i);
                if (entry.Value.Name.Equals("PEPE"))
                {
                    MessageBox.Show("PEPE IS FOUND : " + entry.Value.Name);
                }
                MessageBox.Show(entry.Key + " : " + entry.Value);
                i++;
            }
        }
    }
}