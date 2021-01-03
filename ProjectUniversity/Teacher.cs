using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectUniversity
{
    class Teacher
    {
        string Name;
        string Surname;
        double Salary;

        public Teacher(string name, string surname, double salary)
        {
            Name = name;
            Surname = surname;
            Salary = salary;
        }

        public string teacherFullName => $"{Name} {Surname}";
    }
}
