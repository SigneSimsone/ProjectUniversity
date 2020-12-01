using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectUniversity
{
    class Course
    {
        string CourseName;
        int MaxStudentCount;
        Room CourseRoom;
        Teacher CourseTeacher;
        List<Student> StudentList;

        public Course(string courseName, int maxStudentCount, Room courseRoom, Teacher courseTeacher)
        {
            CourseName = courseName;
            MaxStudentCount = maxStudentCount;
            CourseRoom = courseRoom;
            CourseTeacher = courseTeacher;
            StudentList = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            StudentList.Add(student);
        }
    }
}
