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

        public void AddStudentToCourse(Student student)
        {
            StudentList.Add(student);
        }
        public void RemoveStudentFromCourse(Student student)
        {
            StudentList.Remove(student);
        }
        public void ChangeCourseTeacher(Teacher anotherTeacher)
        {
            CourseTeacher = anotherTeacher;
        }
        public void ChangeCourseRoom(Room anotherRoom)
        {
            CourseRoom = anotherRoom;
        }

    }
}
