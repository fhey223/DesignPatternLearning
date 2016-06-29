using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjectPattern
{
    public interface StudentDao
    {
         List<Student> getAllStudents();
         Student getStudent(int rollNo);
         void updateStudent(Student student);
         void deleteStudent(Student student);
    }
}
