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

namespace MyFirstApp.ForeachLoop
{
    public partial class frmForEach : Form
    {
        public frmForEach()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var student = new Student();
            student.StudentId = Convert.ToInt32(txtStudentId.Text);
            student.Name = txtName.Text;
            student.Surname = txtSurname.Text;
            student.Age = Convert.ToInt32(txtAge.Text);

            //siempre y cuando la variable este dentro de un metodo se recomienda hacerlo con var,
            //para el uso dinamico
            var studentList = new ArrayList();
            studentList.Add(student);
            
            foreach (Student studentItem in studentList)
            {
                MessageBox.Show(studentItem.Name + " " + studentItem.Surname);
            }
        }
    }
}
