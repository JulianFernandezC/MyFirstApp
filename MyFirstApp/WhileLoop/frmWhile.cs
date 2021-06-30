using MyFirstApp.ForeachLoop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MyFirstApp.WhileLoop
{
    public partial class frmWhile : Form
    {
        public frmWhile()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var student = new Student
            {
                StudentId = Convert.ToInt32(txtStudentId.Text),
                Name = txtName.Text,
                Surname = txtSurname.Text,
                Age = Convert.ToInt32(txtAge.Text)
            };

            var studentDictionary = new Dictionary<Guid, Student>
            {
                { student.Guid, student }
            };

            int i = 0;
            while ( i < studentDictionary.Count)
            {
                KeyValuePair<Guid, Student>  keyValuePair = studentDictionary.ElementAt(i);
                if(keyValuePair.Value.Name.Equals("Pepe"))
                    MessageBox.Show("Guid: " + keyValuePair.Key + " , Nombre:" + keyValuePair.Value.Name + " " + keyValuePair.Value.Surname);

                i++;
            }
            MessageBox.Show("El número de estudiantes es: " + Student.STUDENT_COUNTER);
        }
    }
}
