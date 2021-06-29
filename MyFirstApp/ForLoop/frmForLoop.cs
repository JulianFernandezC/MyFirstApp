using MyFirstApp.ForeachLoop;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MyFirstApp.ForLoop
{
    public partial class frmForLoop : Form
    {
        public frmForLoop()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var student = new Student();
            student.StudentId = Convert.ToInt32(txtStudentId.Text);
            student.Name = txtName.Text;
            student.Surname = txtSurname.Text;
            student.Age = Convert.ToInt32(txtAge.Text);

            var studentList = new List<Student>();
            studentList.Add(student);

            for (int i = 0; i< studentList.Count; i++)
            {
                MessageBox.Show(studentList[i].Name + " " + studentList[i].Surname);
            }
        }
    }
}
