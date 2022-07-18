using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Core
{
    public class Student
    {
        public Student()
        {

        }
        public virtual int Id { get; set; }
        public virtual string? StudentName { get; set; }
        public virtual Department Department { get; set; }
    }
}
