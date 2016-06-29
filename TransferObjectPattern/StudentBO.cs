using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObjectPattern
{
    public class StudentBO
    {

        //列表是当作一个数据库
        List<StudentVO> students;

        public StudentBO()
        {
            students = new List<StudentVO>();
            StudentVO student1 = new StudentVO("Robert", 0);
            StudentVO student2 = new StudentVO("John", 1);
            students.Add(student1);
            students.Add(student2);
        }
        public void deleteStudent(StudentVO student)
        {
            students.RemoveAt(student.getRollNo());
            Console.WriteLine("Student: Roll No "
            + student.getRollNo() + ", deleted from database");
        }

        //从数据库中检索学生名单
        public List<StudentVO> getAllStudents()
        {
            return students;
        }

        public StudentVO getStudent(int rollNo)
        {
            return students.ElementAt(rollNo);
        }

        public void updateStudent(StudentVO student)
        {
            students.ElementAt(student.getRollNo()).setName(student.getName());
            Console.WriteLine("Student: Roll No "
            + student.getRollNo() + ", updated in the database");
        }
    }
}
