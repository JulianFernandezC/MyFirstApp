using System;
using System.Collections.Generic;

namespace MyFirstApp.ForeachLoop
{
    public class Student
    {
        public Guid Guid { get; set; }
        public int StudentId { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public int Age { get; set; }

        //Variable estatica asociada a la clase cuando se crea en RAM
        //es compartida por todas las instancias (objetos) de la clase
        public static int STUDENT_COUNTER;

        //constructor de clase statico (inicializa los atributos estaticos de la clase en memoria RAM)
        static Student()
        {
            STUDENT_COUNTER = 0;
        }

        //constructor de objeto
        public Student()
        {
            Guid = Guid.NewGuid();
            STUDENT_COUNTER += 1;
        }

        //el uso de :this() invoca al constructor sin parametros
        public Student(int studentId, string name, string surname, int age) : this()
        {
            StudentId = studentId;
            Name = name;
            Surname = surname;
            Age = age;
        }


        public override bool Equals(object obj)
        {
            return obj is Student student &&
                   StudentId == student.StudentId &&
                   Name == student.Name &&
                   Surname == student.Surname &&
                   Age == student.Age;
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
