using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectUniversity
{
    class Room
    {
        string Name;
        int MaxCapacity;
        string Faculty;
        
        public Room(string name, int maxCapacity, string faculty)
        {
            Name = name;
            MaxCapacity = maxCapacity;
            Faculty = faculty;
        }

        public string courseFaculty => $"{Faculty}";
        public string courseRoom => $"{Name}";
    }
}
