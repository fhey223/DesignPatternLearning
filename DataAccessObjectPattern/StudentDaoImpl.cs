using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessObjectPattern
{
    public class StudentDaoImpl : StudentDao
    {
        //列表是当作一个数据库
        private readonly List<Student> students;

        public StudentDaoImpl()
        {
            students = new List<Student>();
            students.Add(new Student("Robert", 0));
            students.Add(new Student("John", 1));
        }

        public void deleteStudent(Student student)
        {
            students?.RemoveAt(student.getRollNo());
            Console.WriteLine($"Student: Roll No {student.getRollNo()}, deleted from database");
        }

        //从数据库中检索学生名单
        public List<Student> getAllStudents() => students;


        public Student getStudent(int rollNo) => students?.ElementAt(rollNo);


        public void updateStudent(Student student)
        {
            students?.ElementAt(student.getRollNo())?.setName(student.getName());
            Console.WriteLine($"Student: Roll No{student.getRollNo()}updated in the database");
        }
    }
}