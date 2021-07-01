using System;
using System.Windows.Forms;

namespace MyFirstApp.Inheritance
{
    public partial class frmTeacher : Form
    {
        public frmTeacher()
        {
            InitializeComponent();
        }

        private void FrmTeacher_Load(object sender, EventArgs e)
        {
            Teacher teacher1 = new Teacher();
            teacher1.Name = "Pepe";
            teacher1.Surname = "Soto";
            teacher1.Subject = "Informatica";
            teacher1.Salary = 40000.00f;

            MessageBox.Show("El nombre es: " + teacher1.Name + ", su salario es: $ " + teacher1.Salary);

            //Version polimorfica
            Person person = new Teacher();
            person.Name = "Juan";
            person.Surname = "Suarez";

            ((Teacher)person).Subject = "Matematica";
            ((Teacher)person).Salary = 50000.00f;

            MessageBox.Show("El nombre es: " + person.Name + ", su salario es: $ " + ((Teacher)person).Salary);
        }
    }
}
