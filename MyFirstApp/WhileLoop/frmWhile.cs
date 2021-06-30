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
            var student = new Student();
            student.StudentId = Convert.ToInt32(txtStudentId.Text);
            student.Name = txtName.Text;
            student.Surname = txtSurname.Text;
            student.Age = Convert.ToInt32(txtAge.Text);

            var studentDictionary = new Dictionary<int, Student>();
            studentDictionary.Add(student.StudentId, student);

            int i = 0;
            while ( i < studentDictionary.Count)
            {
                KeyValuePair<int, Student>  keyValuePair = studentDictionary.ElementAt(i);
                if(keyValuePair.Value.Name.Equals("Pepe"))
                    MessageBox.Show(keyValuePair.Value.Name + " " + keyValuePair.Value.Surname);

                i++;
            }
        }
    }
}
