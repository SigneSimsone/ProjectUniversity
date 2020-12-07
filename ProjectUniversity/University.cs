using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectUniversity
{
    class University
    {
        List<Course> CourseList;
        List<Room> RoomList;
       
        public University()
        {
            CourseList = new List<Course>();
            RoomList = new List<Room>();
        }

        public void AddRoom(Room room)
        {
            RoomList.Add(room);
        }

        public void AddCourse(Course course)
        {
            CourseList.Add(course);
        }

        public void RemoveStudentFromUniversity(Student student)
        {
            
        }
    }
}
