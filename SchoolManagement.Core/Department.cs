using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Core
{
    public class Department
    {
        public List<Course> Courses { get; set; }
        public List<Lecturer> Lecturers { get; set; }
    }
}
