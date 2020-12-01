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
            CourseList = new List<Course>(); //Course List
            RoomList = new List<Room>();
        }
    }
}
