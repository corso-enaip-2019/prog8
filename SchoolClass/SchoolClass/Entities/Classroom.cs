using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClass.Entities
{
    class Classroom
    {
        List<Student> _students = new List<Student>();

        public Classroom(int grade)
        {
            Grade = grade;
        }
        public int Grade { get; }

        public void AddStudent(Student student)
        {
            _students.Add(student);
            student.AttendedClassroom = this;
        }

    }
}
