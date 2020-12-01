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

        public Course()
        {
            CourseRoom = new Room();
            CourseTeacher = new Teacher();
            StudentList = new List<Student>();
        }
    }
}
