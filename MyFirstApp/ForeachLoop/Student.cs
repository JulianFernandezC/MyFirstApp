using System;
using System.Collections.Generic;

namespace MyFirstApp.ForeachLoop
{
    public class Student
    {
        public int StudentId { get; set; } //una prop genera una variable privada por defecto
        public String Name { get; set; }
        public String Surname { get; set; }
        public int Age { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Student student &&
                   StudentId == student.StudentId &&
                   Name == student.Name &&
                   Surname == student.Surname &&
                   Age == student.Age;
        }

        public Student(int studentId, string name, string surname, int age)
        {
            StudentId = studentId;
            Name = name;
            Surname = surname;
            Age = age;
        }

        public override int GetHashCode()
        {
            var hashCode = -1235398547;
            hashCode = hashCode * -1521134295 + StudentId.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Surname);
            hashCode = hashCode * -1521134295 + Age.GetHashCode();
            return hashCode;
        }
    }
}
