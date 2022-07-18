using FluentNHibernate.Mapping;
using SchoolManagement.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.DB.Mappings
{
    public class StudentMap:ClassMap<Student>
    {
        public StudentMap()
        {
            Id(student=>student.Id);
            Map(student => student.StudentName);
            References(student => student.Department);
        }
    }
}
