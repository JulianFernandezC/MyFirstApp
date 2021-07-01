using System.Collections.Generic;

namespace MyFirstApp.Inheritance
{
    public class Teacher : Person
    {
        public string Subject { get; set; }
        public float Salary { get; set; }

        public Teacher()
        {

        }
        public Teacher(string subject, float salary, string name, string surname) : base(name, surname)
        {
            Subject = subject;
            Salary = salary;
        }

        public override bool Equals(object obj)
        {
            return obj is Teacher teacher &&
                   base.Equals(obj) &&
                   Subject == teacher.Subject &&
                   Salary == teacher.Salary;
        }

        public override int GetHashCode()
        {
            var hashCode = -541091664;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Subject);
            hashCode = hashCode * -1521134295 + Salary.GetHashCode();
            return hashCode;
        }
    }
}
