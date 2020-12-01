using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectUniversity
{
    class Student
    {
        string Name;
        string Surname;
        int Age;
        string CurrentLevel;

        public Student(string name, string surname, int age, string currentLevel)
        {
            Name = name;
            Surname = surname;
            Age = age;
            CurrentLevel = currentLevel;
        }
    }
}
