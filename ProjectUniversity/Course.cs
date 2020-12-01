using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectUniversity
{
    class Course
    {
        string CourseName;
        int MaxStudentCount;
        string CourseRoom;
        string CourseTeacher;
        List<Student> StudentList;

        public Course(string courseName, int maxStudentCount, string room, string teacher)
        {
            CourseName = courseName;
            MaxStudentCount = maxStudentCount;
            CourseRoom = room;
            CourseTeacher = teacher;
            StudentList = new List<Student>();
        }
    }
}
